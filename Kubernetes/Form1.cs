﻿using Kubernetes.Controller;
using Kubernetes.Model.Node;
using Kubernetes.Model.Namespaces;
using Kubernetes.Model.PodList;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Kubernetes.Model.Service;
using Kubernetes.Model.Deployments;
using System.Xml.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text.RegularExpressions;
using Kubernetes.Utils;
using System.Reflection.Emit;
using Newtonsoft.Json.Linq;
using Kubernetes.Model.PodMetrics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms.DataVisualization.Charting;

namespace Kubernetes
{
    public partial class Form1 : Form
    {
        private readonly HttpClient httpClient;
        private string baseUrl;
        private bool isConnected = false;
        private string token;
        private KubernetesService kubernetesService;
        private System.Timers.Timer timer;
        private NamespaceList namespaceList;
        private PodList podList;
        private NodeList nodeList;
        private ServiceList serviceList;
        private DeploymentsList deployments;
        private Validator validator = new Validator();


        private string selectedNamespace;

        public Form1()
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            httpClient = new HttpClient();
            //token = getToken();
            InitializeComponent();
            pictureBox1.BackColor = Color.Transparent;
            textBoxLoginIp.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
            textBoxLoginToken.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
            podList = new PodList { Items = new List<PodItem>() };
            deployments = new DeploymentsList { Items = new List<DeploymentItem>() };


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the Enter key was pressed
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Prevent the default beep sound
                e.Handled = true;

                // Trigger the login button click event
                buttonLogin.PerformClick();
            }

        }

        private void tabControl1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Check if connected to router before allowing access to other tabs
            if (!isConnected && tabControl1.SelectedIndex != 0)
            {
                MessageBox.Show("Please connect to the microk8s first.");
                tabControl1.SelectedIndex = 0; // Switch back to the connection tab
            }

            TabControl tabControl = (TabControl)sender;
            switch (tabControl.SelectedIndex)
            {
                case 1:
                    PopulateComboBoxesNameSpace();
                    break;
                case 2:
                    PopulateNodeInfoAsync();
                    break;
                case 3:
                    PopulateListViewNamespaces();
                    PopulateComboBoxesNameSpace();
                    break;
                case 4:
                    PopulatePods("default");
                    PopulateComboBoxesNameSpace();
                    break;
                case 5:
                    PopulateComboBoxesNameSpace();
                    break;
                case 6:
                    PopulateServiceAsync();
                    break;
            }

        }



        private async Task Connect(string ipAddress, string token, int control)
        {
            baseUrl = ipAddress;
            if (control == 1)
            {
                //string credentials = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{token}"));
                httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            }
            await kubernetesService.TestConnection(); // Test connection asynchronously
            isConnected = true;
            textBoxLoginIp.Enabled = false; // IP Address textbox
            textBoxLoginToken.Enabled = false; // Token textbox
            MessageBox.Show("Connected to Management Interface successfully!");
            InitializeTimer();
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            // Reset isConnected flag to indicate disconnection
            isConnected = false;

            // Optionally, dispose of the HttpClient instance to release associated resources
            httpClient.Dispose();
            // Disable the textboxes after successful connection
            textBoxLoginIp.Enabled = true; // Username textbox
            timer.Stop();
            if (checkBoxHttps.Checked)
            {
                textBoxLoginToken.Enabled = true; // token textbox
            }
            else
            {
                textBoxLoginToken.Enabled = false; // token textbox
            }

            MessageBox.Show("Disconnected from router.");

        }



        private async void buttonLogin_Click(object sender, EventArgs e)
        {

            string ipAddress = textBoxLoginIp.Text.Trim();
            string token = textBoxLoginToken.Text.Trim();

            // Determine the protocol (HTTP or HTTPS) based on user selection
            string protocol = (checkBoxHttps.Checked) ? "https://" : "http://";
            string port = (checkBoxHttps.Checked) ? ":16443" : ":8001";
            int control = (checkBoxHttps.Checked) ? 1 : 0;

            if (control == 1)
            {
                //token = getToken(ipAddress);
            }

            try
            {
                // Construct the base URL using the determined protocol and IP address
                //string baseUrl = protocol + ipAddress;
                string baseUrl = protocol + ipAddress + port;

                // Instantiate MethodsController class with user credentials and base URL
                kubernetesService = new KubernetesService(baseUrl, token, control);

                // Attempt to connect to the router
                await Connect(baseUrl, token, control);
                // If connection successful, display success message
                MessageBox.Show("Connected to " + ipAddress, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Proceed with populating DHCP tab or other necessary actions
            }
            catch (Exception ex)
            {
                // If an error occurs during connection, display error message
                MessageBox.Show("Error connecting to router: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void checkBoxHttps_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHttps.Checked)
            {
                textBoxLoginToken.Enabled = true;
            }
            else
            {
                textBoxLoginToken.Enabled = false;
            }
        }

        private async void PopulateListViewNamespaces()
        {
            try
            {
                // Fetch namespaces from the Kubernetes service
                namespaceList = await kubernetesService.RetrieveNamespaces();
                if (namespaceList == null)
                {
                    throw new Exception("Namespace list is null");
                }

                // List of default namespaces to exclude
                var defaultNamespaces = new HashSet<string> { "kube-system", "kube-public", "kube-node-lease", "default" };

                // Clear existing items in the ListView
                listViewNamespaces.Items.Clear();

                // Add new items or update existing items in the ListView
                foreach (var ns in namespaceList.Items)
                {
                    // Skip default namespaces
                    if (defaultNamespaces.Contains(ns.Metadata?.Name))
                    {
                        continue;
                    }

                    ListViewItem item = new ListViewItem(new[]
                    {
                ns.Metadata.Name,
                ns.Metadata.Labels != null ? string.Join(", ", ns.Metadata.Labels.Select(l => l.Key + "=" + l.Value)) : "",
                ns.Metadata.CreationTimestamp.ToString("yyyy-MM-ddTHH:mm:ss"),
                ns.Spec.Finalizers != null ? string.Join(", ", ns.Spec.Finalizers) : "",
                ns.Status.Phase,
            });
                    listViewNamespaces.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                // Handle the exception or display an error message
                MessageBox.Show("Error fetching namespaces: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void PopulatePods(string namespaceText)
        {
            try
            {
                // Fetch pods from the Kubernetes service for the specified namespace
                PodList podList = await kubernetesService.RetrievePods(namespaceText);
                if (podList == null || podList.Items == null)
                {
                    throw new Exception("Pod list is null or empty");
                }

                // List of default namespaces to exclude
                var defaultNamespaces = new HashSet<string> { "kube-system", "kube-public", "kube-node-lease", "default" };

                // Clear existing items in the ListView
                listViewPods.Items.Clear();

                // Add new items or update existing items in the ListView
                foreach (var pod in podList.Items)
                {
                    // Skip pods that belong to default namespaces
                    if (defaultNamespaces.Contains(pod.Metadata?.Namespace))
                    {
                        continue;
                    }

                    ListViewItem item = new ListViewItem(new[]
                    {
                pod.Metadata?.Name ?? "N/A",
                pod.Metadata?.Namespace ?? "N/A",
                pod.Metadata?.CreationTimestamp.ToString("yyyy-MM-ddTHH:mm:ss") ?? "N/A",
                GetImageString(pod.Spec?.Containers) ?? "N/A", // Use helper method to get image string
                GetPortsString(pod.Spec?.Containers) ?? "N/A", // Use helper method to get ports string
                pod.Spec?.NodeName ?? "N/A",
                pod.Status?.Phase ?? "N/A"
            });
                    listViewPods.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                // Handle the exception or display an error message
                MessageBox.Show("Error fetching pods: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Helper method to get image string
        private string GetImageString(List<PodContainer> containers)
        {
            if (containers == null)
            {
                return "N/A";
            }

            var images = containers.Select(c => c.Image);
            return images.Any() ? string.Join(", ", images) : "N/A";
        }

        // Helper method to get ports string
        private string GetPortsString(List<PodContainer> containers)
        {
            if (containers == null)
            {
                return "N/A";
            }

            var ports = containers
                .SelectMany(c => c.Ports?.Select(p => p.ContainerPort.ToString()) ?? Enumerable.Empty<string>())
                .ToList();

            return ports.Any() ? string.Join(", ", ports) : "N/A";
        }


        private async void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            // Update ListView data for namespaces
            Invoke((MethodInvoker)delegate
            {
                PopulateListViewNamespaces();
                PopulateNodeInfoAsync();
                PopulateServiceAsync();
                PopulateComboBoxesNameSpace();
                PopulateImageCombobox();

            });
        }
        private void InitializeTimer()
        {
            timer = new System.Timers.Timer();
            timer.Interval = 5000; // 5000 milliseconds = 5 seconds
            timer.Elapsed += Timer_Elapsed;
            timer.AutoReset = true; // Make the timer continuously repeat
            timer.Start();
        }


        private async void PopulateComboBoxesNameSpace()
        {
            try
            {
                // Fetch namespaces from the Kubernetes service
                IEnumerable<string> namespaces = await kubernetesService.GetNamespaceNames();

                // List of default namespaces to exclude
                var defaultNamespaces = new HashSet<string> { "kube-system", "kube-public", "kube-node-lease", "default" };

                // Save current selections
                var selectedNamespacePod = comboBoxNamespacePod.SelectedItem;
                var selectedNamespaceChart = comboNameSpaceChart.SelectedItem;
                var selectedDeploymentNamespace = comboBoxDeploymentNamespace.SelectedItem;

                // Clear existing items in the combo boxes
                comboBoxNamespacePod.Items.Clear();
                comboNameSpaceChart.Items.Clear();
                comboBoxDeploymentNamespace.Items.Clear();

                // Add fetched namespaces to the combo boxes, excluding default namespaces
                foreach (string ns in namespaces)
                {
                    if (!defaultNamespaces.Contains(ns))
                    {
                        comboBoxNamespacePod.Items.Add(ns);
                        comboNameSpaceChart.Items.Add(ns);
                        comboBoxDeploymentNamespace.Items.Add(ns);
                    }
                }

                // Restore previous selections if they still exist in the items
                if (selectedNamespacePod != null && comboBoxNamespacePod.Items.Contains(selectedNamespacePod))
                {
                    comboBoxNamespacePod.SelectedItem = selectedNamespacePod;
                }
                if (selectedNamespaceChart != null && comboNameSpaceChart.Items.Contains(selectedNamespaceChart))
                {
                    comboNameSpaceChart.SelectedItem = selectedNamespaceChart;
                }
                if (selectedDeploymentNamespace != null && comboBoxDeploymentNamespace.Items.Contains(selectedDeploymentNamespace))
                {
                    comboBoxDeploymentNamespace.SelectedItem = selectedDeploymentNamespace;
                }

            }
            catch (Exception ex)
            {
                // Handle the exception or display an error message
                MessageBox.Show("Error fetching namespaces: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async void PopulateNodeInfoAsync()
        {
            try
            {
                nodeList = await kubernetesService.RetrieveNodes();

                // Clear existing items
                listViewNodes.Items.Clear();


                foreach (var node in nodeList.Items)
                {
                    ListViewItem item = new ListViewItem(node.Metadata.Name);


                    // Labels (if available)
                    string labels = node.Metadata.Labels != null ? string.Join
                        (",", node.Metadata.Labels.Select(l => l.Key + "=" + l.Value)) : "N/A";
                    item.SubItems.Add(labels);


                    // CreationTimeStamp (if available)
                    string created = node.Metadata.creationTimestamp.ToString("yyyy-MM-ddTHH:mm:ss");
                    item.SubItems.Add(created);

                    // Used CPU (if available)
                    string usedCpu = "N/A";
                    if (node.Status.Capacity != null && node.Status.Allocatable != null
                        && node.Status.Capacity.ContainsKey("cpu") && node.Status.Allocatable.ContainsKey("cpu"))
                    {
                        if (double.TryParse(node.Status.Capacity["cpu"], out double capacity)
                            && double.TryParse(node.Status.Allocatable["cpu"], out double allocatable))
                        {
                            double used = capacity - allocatable;
                            usedCpu = used >= 0 ? used.ToString() : "N/A";
                        }
                    }
                    item.SubItems.Add(usedCpu);

                    // Available CPU (if available)
                    string allocatableCpu = node.Status.Allocatable?.ContainsKey("cpu") == true ? node.Status.Capacity["cpu"] : "0";
                    item.SubItems.Add(allocatableCpu);


                    // Address Type and Address (if available)
                    if (node.Status.Addresses != null && node.Status.Addresses.Count > 0)
                    {
                        string addressType = node.Status.Addresses[0].Type;
                        string address = node.Status.Addresses[0].IpAddress;
                        item.SubItems.Add(addressType);
                        item.SubItems.Add(address);
                    }
                    else
                    {
                        item.SubItems.Add("N/A");
                        item.SubItems.Add("N/A");
                    }

                    // OS, OSImage, and Architecture (if available)
                    item.SubItems.Add(node.Status.NodeInfo?.OS ?? "N/A");
                    item.SubItems.Add(node.Status.NodeInfo?.OSImage ?? "N/A");
                    item.SubItems.Add(node.Status.NodeInfo?.Architecture ?? "N/A");

                    // Add the ListViewItem to the ListView
                    listViewNodes.Items.Add(item);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Populating List: " + ex.Message);
            }
        }

        private async void PopulateServiceAsync()
        {
            try
            {
                serviceList = await kubernetesService.RetrieveServices();

                //Clear existing items
                listViewServices.Items.Clear();

                foreach (var service in serviceList.Items)
                {
                    //Name
                    ListViewItem listView = new ListViewItem(service.Metadata.Name);

                    //namespace
                    listView.SubItems.Add(service.Metadata.Namespace);

                    //CreationTimeStamp
                    string created = service.Metadata.CreationTimeStamp.ToString("yyyy-MM-ddTHH:mm:ss");
                    listView.SubItems.Add(created);

                    // Labels (if available)
                    //string labels = string.Join(", ", node.Metadata.Labels?.Select(kv => $"{kv.Key}: {kv.Value}") ?? Enumerable.Empty<string>());
                    string labels = service.Metadata.Labels != null ? string.Join
                        (", ", service.Metadata.Labels.Select(l => l.Key + "=" + l.Value)) : "N/A";
                    listView.SubItems.Add(labels);

                    //Port
                    string ports = service.Spec.Ports != null
                     ? string.Join(", ", service.Spec.Ports.Select(p => $"{p.Name} ({p.Protocol}): {p.IpPort}->{p.TargetPort}"))
                     : "N/A";
                    listView.SubItems.Add(ports);

                    //ClusterIps
                    listView.SubItems.Add(service.Spec.ClusterIP);

                    // Add the ListViewItem to the ListView
                    listViewServices.Items.Add(listView);

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Populating List: " + ex.Message);
            }
            //throw new NotImplementedException();
        }



        private void comboNameSpaceChart_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if the selected item is not null
            if (comboNameSpaceChart.SelectedItem != null)
            {
                // Update the selected namespace
                selectedNamespace = comboNameSpaceChart.SelectedItem.ToString();

                // Populate the pods combo box with pods in the selected namespace
                if (!string.IsNullOrEmpty(selectedNamespace))
                {
                    // (selectedNamespace);
                }
            }
        }

        private void comboNameSpaceChart_Enter(object sender, EventArgs e)
        {
            PopulateComboBoxesNameSpace();
        }

        private async void buttonNamespaceCreate_Click(object sender, EventArgs e)
        {

            if (textBoxNamespaceName.Text.Trim() == "" || !validator.ValidateNamespace(textBoxNamespaceName.Text))
            {
                MessageBox.Show("Please Choose a Valid name");
                return;
            }

            foreach (var namespaceLocal in namespaceList.Items)
            {
                if (textBoxNamespaceName.Text == namespaceLocal.Metadata.Name)
                {
                    MessageBox.Show($"Namespace: {textBoxNamespaceName.Text} already exists.");
                    return;
                }
            }
            if (!validator.ValidateLabels(textBoxNamespaceLabels.Text))
            {
                MessageBox.Show("Please Choose a valid labels");
                return;
            }
            if (!validator.ValidateAnnotations(textBoxNamespacesAnnotations.Text))
            {
                MessageBox.Show("Please Choose a valid annotation");
                return;
            }

            NamespaceItem namespaceItem = CreateNamespaceFromForms();
            await kubernetesService.CreateNamespace(namespaceItem);
        }

        private NamespaceItem CreateNamespaceFromForms()
        {
            NamespaceItem namespaceItem = new NamespaceItem();
            namespaceItem.Metadata = new Model.Namespaces.Metadata();
            namespaceItem.Metadata.Name = textBoxNamespaceName.Text;

            string[] lines = textBoxNamespaceLabels.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string line in lines)
            {
                // Split the line into key and value
                string[] parts = line.Trim().Split(':');
                if (parts.Length == 2)
                {
                    string key = parts[0].Trim().Trim('"');
                    string value = parts[1].Trim().Trim('"');
                    Dictionary<string, string> Labels = new Dictionary<string, string>
                            {
                                { key, value }
                            };
                    namespaceItem.Metadata.Labels = Labels;
                }
            }
            string[] anno = textBoxNamespacesAnnotations.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string ann in anno)
            {
                // Split the line into key and value
                string[] parts = ann.Trim().Split(':');
                if (parts.Length == 2)
                {
                    string key = parts[0].Trim().Trim('"');
                    string value = parts[1].Trim().Trim('"');
                    Dictionary<string, string> Annotations = new Dictionary<string, string>
                            {
                                { key, value }
                            };
                    namespaceItem.Metadata.Annotations = Annotations;
                }
            }

            return namespaceItem;

        }

        private PodItem CreatePodFromForms()
        {
            PodItem podItem = new PodItem
            {
                Metadata = new PodMetadata
                {
                    Name = textBoxPodName.Text,
                    Namespace = comboBoxNamespacePod.SelectedItem.ToString(),
                    Labels = new Dictionary<string, string>()
                },
                Spec = new PodSpec
                {
                    Containers = new List<PodContainer>
            {
                new PodContainer
                {
                    Name = containerNameText.Text,
                    Image = imagePodCombobox.SelectedItem.ToString()
                }
            }
                }
            };

            string[] lines = textBoxPodLabel.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string line in lines)
            {
                string[] parts = line.Trim().Split(':');
                if (parts.Length == 2)
                {
                    string key = parts[0].Trim().Trim('"');
                    string value = parts[1].Trim().Trim('"');
                    podItem.Metadata.Labels[key] = value;
                }
            }

            return podItem;
        }


        private void comboBoxNamespacePod_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nameSpaceSelected = comboBoxNamespacePod.SelectedItem.ToString();
            PopulatePods(nameSpaceSelected);
        }

        private async void buttonPodCreate_Click(object sender, EventArgs e)
        {

            if (comboBoxNamespacePod.SelectedItem == null)
            {
                MessageBox.Show("Please select a namespace");
                return;
            }
            if (textBoxPodName.Text.Trim() == "" || !validator.ValidateNamespace(textBoxPodName.Text))
            {
                MessageBox.Show("Please Choose a Valid name");
                return;
            }
            if (containerNameText.Text.Trim() == "" || !validator.ValidateNamespace(containerNameText.Text))
            {
                MessageBox.Show("Please Choose a Valid name");
                return;
            }

            // Check if podList is null before accessing it
            if (podList == null || podList.Items == null)
            {
                MessageBox.Show("Pod list is not initialized. Please try again.");
                return;
            }

            foreach (var podLocal in podList.Items)
            {
                if (textBoxPodName.Text == podLocal.Metadata.Name)
                {
                    MessageBox.Show($"Pod: {textBoxPodName.Text} already exists.");
                    return;
                }
            }

            if (!validator.ValidateLabels(textBoxPodLabel.Text))
            {
                MessageBox.Show("Please Choose valid labels");
                return;
            }

            if (imagePodCombobox.SelectedItem.ToString() == null)
            {
                MessageBox.Show("Please select an image");
                return;
            }

            string namespaceItem = comboBoxNamespacePod.SelectedItem.ToString().Trim();

            PodItem podItem = CreatePodFromForms();
            await kubernetesService.CreatePod(podItem, namespaceItem);
        }

        private async void buttonNamespaceDelete_Click(object sender, EventArgs e)
        {
            // Check if any namespace is selected in the ListView
            if (listViewNamespaces.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select one or more namespaces to delete.");
                return;
            }

            // Confirm with the user before deleting namespaces and their pods
            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected namespaces and their pods? This action cannot be undone.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    // Iterate over each selected item in the ListView
                    foreach (ListViewItem item in listViewNamespaces.SelectedItems)
                    {
                        string namespaceToDelete = item.SubItems[0].Text; // Assuming the namespace is in the first column

                        // Delete the namespace and its pods
                        await kubernetesService.DeleteNamespace(namespaceToDelete);
                    }

                    // Refresh the ListView after deleting the namespaces and their pods
                    PopulateListViewNamespaces();

                    MessageBox.Show("Selected namespaces and their pods deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to delete namespaces: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        List<string> defaultImages = new List<string>
        {
            "nginx:latest",
            "nginx:stable",
            "nginx:alpine",
            "redis:latest",
            "redis:alpine",
            "mysql:latest",
            "mysql:5.7",
            "mysql:8.0",
            "postgres:latest",
            "postgres:alpine",
            "postgres:12",
            "ubuntu:latest",
            "ubuntu:18.04",
            "ubuntu:20.04",
            "alpine:latest",
            "alpine:3.12",
            "alpine:3.13",
            "busybox:latest",
            "busybox:1.32",
            "node:latest",
            "node:alpine",
            "node:14",
            "node:16",
            "python:latest",
            "python:3.8",
            "python:3.9",
            "mongo:latest",
            "mongo:4.4",
            "mongo:5.0"
        };
        private void PopulateImageCombobox()
        {
            foreach (string image in defaultImages)
            {
                imageDeployment.Items.Add(image);
                imagePodCombobox.Items.Add(image);
            }
        }

        private async void buttonPodDelete_Click(object sender, EventArgs e)
        {
            // Get the selected namespace from the ComboBox
            string selectedNamespace = comboBoxNamespacePod.SelectedItem?.ToString();

            // Check if a namespace is selected
            if (string.IsNullOrEmpty(selectedNamespace))
            {
                MessageBox.Show("Please select a namespace.");
                return;
            }

            // Get the selected pod names from the ListView
            List<string> selectedPodNames = new List<string>();
            foreach (ListViewItem item in listViewPods.SelectedItems)
            {
                selectedPodNames.Add(item.Text); // Assuming the pod name is in the first column
            }

            // Check if any pod is selected
            if (selectedPodNames.Count == 0)
            {
                MessageBox.Show("Please select at least one pod to delete.");
                return;
            }

            // Confirm with the user before deleting pods
            DialogResult result = MessageBox.Show($"Are you sure you want to delete {selectedPodNames.Count} pod(s)?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                // Delete each selected pod
                foreach (string podName in selectedPodNames)
                {
                    await kubernetesService.DeletePod(selectedNamespace, podName);
                }

                // Refresh the ListView after deleting pods
                PopulatePods(selectedNamespace);

                MessageBox.Show("Pod(s) deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void comboBoxDeploymentNamespace_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nameSpaceSelected = comboBoxDeploymentNamespace.SelectedItem.ToString();
            PopulateDeployments(nameSpaceSelected);
        }
        private async void PopulateDeployments(string namespaceText)
        {
            try
            {
                // Fetch deployments from the Kubernetes service for the specified namespace
                DeploymentsList deploymentList = await kubernetesService.RetrieveDeployments(namespaceText);
                if (deploymentList == null || deploymentList.Items == null)
                {
                    return;
                }
                var defaultNamespaces = new HashSet<string> { "kube-system", "kube-public", "kube-node-lease", "default" };

                // Clear existing items in the ListView
                listViewDeployments.Items.Clear();

                // Add new items or update existing items in the ListView
                foreach (var deployment in deploymentList.Items)
                {
                    // Skip deployments that belong to default namespaces
                    if (defaultNamespaces.Contains(deployment.Metadata?.Namespace))
                    {
                        continue;
                    }

                    string containerImage = GetContainerImage(deployment.Spec?.Template?.Spec?.Containers);
                    string containerPorts = GetContainerPorts(deployment.Spec?.Template?.Spec?.Containers);

                    ListViewItem item = new ListViewItem(new[]
                    {
                deployment.Metadata?.Name ?? "N/A",
                deployment.Metadata?.Namespace ?? "N/A",
                deployment.Metadata?.CreationTimestamp?.ToString("yyyy-MM-ddTHH:mm:ss") ?? "N/A",
                deployment.Metadata.Labels != null ? string.Join(", ", deployment.Metadata.Labels.Select(l => l.Key + "=" + l.Value)) : "N/A",
                "Deployment",
                containerImage,
                containerPorts
            });
                    listViewDeployments.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                // Handle the exception or display an error message
                MessageBox.Show("Error fetching deployments: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetContainerImage(List<DeploymentContainer> containers)
        {
            if (containers == null || containers.Count == 0)
            {
                return "N/A";
            }

            return containers[0]?.Image ?? "N/A";
        }

        private string GetContainerPorts(List<DeploymentContainer> containers)
        {
            if (containers == null || containers.Count == 0)
            {
                return "N/A";
            }

            var ports = containers.SelectMany(c => c.Ports?.Select(p => p.ContainerPort.ToString()) ?? Enumerable.Empty<string>()).ToList();

            return ports.Any() ? string.Join(", ", ports) : "N/A";
        }

        private async void buttonDeploymentCreate_Click(object sender, EventArgs e)
        {

            if (comboBoxDeploymentNamespace.SelectedItem == null)
            {
                MessageBox.Show("Please select a namespace");
                return;
            }
            if (textBoxDeploymentName.Text.Trim() == "" || !validator.ValidateNamespace(textBoxDeploymentName.Text))
            {
                MessageBox.Show("Please Choose a Valid name");
                return;
            }
            if (containerNameDeploy.Text.Trim() == "" || !validator.ValidateNamespace(containerNameDeploy.Text))
            {
                MessageBox.Show("Please Choose a Valid name");
                return;
            }

            // Check if podList is null before accessing it
            if (deployments == null || deployments.Items == null)
            {
                MessageBox.Show("Deployments list is not initialized. Please try again.");
                return;
            }

            foreach (var deployment in deployments.Items)
            {
                if (textBoxDeploymentName.Text == deployment.Metadata.Name)
                {
                    MessageBox.Show($"Pod: {textBoxDeploymentName.Text} already exists.");
                    return;
                }
            }

            if (!validator.ValidateLabels(textBoxDeploymentLabel.Text))
            {
                MessageBox.Show("Please Choose valid labels");
                return;
            }
            if(!validator.ValidatePorts(PortsDeploy.Text))
            {
                MessageBox.Show("Please type ports correctly example: 80,443,(...)");
                return;
            }

            if (imageDeployment.SelectedItem.ToString() == null)
            {
                MessageBox.Show("Please select an image");
                return;
            }

            string namespaceItem = comboBoxDeploymentNamespace.SelectedItem.ToString().Trim();

            DeploymentItem deploymentItem = CreateDeployment();
            await kubernetesService.CreateDeployment(deploymentItem, namespaceItem);
        }

        private DeploymentItem CreateDeployment()
        {
            // Create a DeploymentItem object
            DeploymentItem deploymentItem = new DeploymentItem
            {
                Metadata = new DeploymentMetadata
                {
                    Name = textBoxDeploymentName.Text.Trim(),
                    Namespace = comboBoxDeploymentNamespace.SelectedItem.ToString().Trim(),
                    Labels = new Dictionary<string, string>()
                },
                Spec = new DeploymentSpec
                {
                    Replicas = int.Parse(replicasUpDownDeploy.Text.Trim()), // Assuming you have a textbox for replicas
                    Template = new DeploymentTemplate
                    {
                        Metadata = new DeploymentMetadata
                        {
                            Labels = new Dictionary<string, string>()
                        },
                        Spec = new DeploymentPodSpec
                        {
                            Containers = new List<DeploymentContainer>
                    {
                        new DeploymentContainer
                        {
                            Name = containerNameDeploy.Text.Trim(),
                            Image = imageDeployment.SelectedItem.ToString().Trim(),
                            Ports = new List<DeploymentPort>() // Initialize an empty list for ports
                        }
                    }
                        }
                    }
                }
            };

            // Add labels to metadata
            string[] labelLines = textBoxDeploymentLabel.Text.Trim().Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string line in labelLines)
            {
                string[] parts = line.Trim().Split(':');
                string key = parts[0].Trim().Trim('"');
                string value = parts[1].Trim().Trim('"');
                deploymentItem.Metadata.Labels.Add(key, value);
                deploymentItem.Spec.Template.Metadata.Labels.Add(key, value);
            }

            // Add ports to the container
            string[] ports = PortsDeploy.Text.Trim().Split(',');
            foreach (string port in ports)
            {
                int portNumber;
                if (int.TryParse(port.Trim(), out portNumber))
                {
                    deploymentItem.Spec.Template.Spec.Containers[0].Ports.Add(new DeploymentPort { ContainerPort = portNumber });
                }
            }

            return deploymentItem;
        }

        private async void buttonDeploymentDelete_Click(object sender, EventArgs e)
        {
            // Get the selected namespace from the ComboBox
            string selectedNamespace = comboBoxDeploymentNamespace.SelectedItem?.ToString();

            // Check if a namespace is selected
            if (string.IsNullOrEmpty(selectedNamespace))
            {
                MessageBox.Show("Please select a namespace.");
                return;
            }

            // Get the selected pod names from the ListView
            List<string> selectedDeployments = new List<string>();
            foreach (ListViewItem item in listViewDeployments.SelectedItems)
            {
                selectedDeployments.Add(item.Text); // Assuming the pod name is in the first column
            }

            // Check if any pod is selected
            if (selectedDeployments.Count == 0)
            {
                MessageBox.Show("Please select at least one pod to delete.");
                return;
            }

            // Confirm with the user before deleting pods
            DialogResult result = MessageBox.Show($"Are you sure you want to delete {selectedDeployments.Count} deployments(s)?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                // Delete each selected pod
                foreach (string deploymentName in selectedDeployments)
                {
                    await kubernetesService.DeleteDeployment(selectedNamespace, deploymentName);
                }

                // Refresh the ListView after deleting pods
                PopulatePods(selectedNamespace);

                MessageBox.Show("Deployments(s) deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
