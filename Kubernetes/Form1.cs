using Kubernetes.Controller;
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
        private NodeList node;


        public Form1()
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            httpClient = new HttpClient();
            //token = getToken();
            InitializeComponent();
            pictureBox1.BackColor = Color.Transparent;
            textBoxLoginIp.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
            textBoxLoginToken.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);

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
                case 2:
                    PopulateNodeInfoAsync();
                    break;
                case 3:
                    PopulateListViewNamespaces();
                    break;
                case 4:
                    PopulatePods("default");
                    break;
            }

        }


        private async Task Connect(string ipAddress, string token, int control)
        {
            baseUrl = ipAddress;
            if(control == 1)
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

            if(control == 1)
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
            if(checkBoxHttps.Checked)
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
                NamespaceList namespaceList = await kubernetesService.RetrieveNamespaces();
                if (namespaceList == null)
                {
                    throw new Exception("Namespace list is null");
                }

                // Clear existing items in the ListView
                listViewNamespaces.Items.Clear();

                // Add new items or update existing items in the ListView
                foreach (var ns in namespaceList.Items)
                {
                    ListViewItem item = new ListViewItem(new[]
                    {
                ns.Metadata.Name,
                ns.Metadata.Labels != null ? string.Join(", ", ns.Metadata.Labels.Select(l => l.Key + "=" + l.Value)) : "",
                ns.Metadata.CreationTimestamp.ToString("yyyy-MM-ddTHH:mm:ssZ"),
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

                // Clear existing items in the ListView
                listViewPods.Items.Clear();

                // Add new items or update existing items in the ListView
                foreach (var pod in podList.Items)
                {
                    ListViewItem item = new ListViewItem(new[]
                    {
                pod.Metadata?.Name ?? "N/A",
                pod.Metadata?.Namespace ?? "N/A",
                pod.Metadata?.CreationTimestamp.ToString("yyyy-MM-ddTHH:mm:ssZ") ?? "N/A",
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

            var ports = containers.SelectMany(c => c.Ports).Select(p => p.ContainerPort.ToString());
            return ports.Any() ? string.Join(", ", ports) : "N/A";
        }

        // Helper method to get ports string
        private string GetPortsString(List<PodPort> ports)
        {
            if (ports == null || ports.Count == 0)
            {
                return "N/A";
            }

            var portNumbers = ports.Select(port => port.ContainerPort.ToString());
            return string.Join(", ", portNumbers);
        }


        private async void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            // Update ListView data for namespaces
            Invoke((MethodInvoker)delegate {
                PopulateListViewNamespaces();
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

        private async void comboBoxNamespacePod_Enter(object sender, EventArgs e)
        {
            try
            {
                // Fetch namespaces from the Kubernetes service
                IEnumerable<string> namespaces = await kubernetesService.GetNamespaceNames();

                // Clear existing items in the combo box
                comboBoxNamespacePod.Items.Clear();

                // Add fetched namespaces to the combo box
                foreach (string ns in namespaces)
                {
                    comboBoxNamespacePod.Items.Add(ns);
                }
            }
            catch (Exception ex)
            {
                // Handle the exception or display an error message
                MessageBox.Show("Error fetching namespaces: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxNamespacePod_SelectedIndexChanged(object sender, EventArgs e)
        {
           string nameSpaceSelected= comboBoxNamespacePod.SelectedItem.ToString();
           PopulatePods(nameSpaceSelected);
        }
        private async void PopulateNodeInfoAsync()
        {
            try
            {
                NodeList nodeList = await kubernetesService.RetrieveNodes();

                // Clear existing items
                listViewNodes.Items.Clear();

                foreach (var node in nodeList.Items)
                {
                    ListViewItem item = new ListViewItem(node.Metadata.Name);

                    // Labels (if available)
                    //string labels = string.Join(", ", node.Metadata.Labels?.Select(kv => $"{kv.Key}: {kv.Value}") ?? Enumerable.Empty<string>());
                    string labels = node.Metadata.Labels != null ? string.Join
                        (", ", node.Metadata.Labels.Select(l => l.Key + "=" + l.Value)) : "N/A";
                    item.SubItems.Add(labels);

                    // Type (if available)
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

        
    }
}
