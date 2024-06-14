using Kubernetes.Controller;
using Kubernetes.Model.Deployments;
using Kubernetes.Model.Namespaces;
using Kubernetes.Model.Node;
using Kubernetes.Model.PodList;
using Kubernetes.Model.Service;
using Kubernetes.Utils;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace Kubernetes
{
    public partial class Wizard : Form
    {
        private readonly HttpClient httpClient;
        private string _baseUrl;
        private string _ipaddr;
        private string _token;
        private int _control;
        private KubernetesService kubernetesService;
        private NamespaceItem namespaceItem;
        private Validator validator;
        private PodItem podItem;
        private DeploymentItem deploymentItem;

        private NamespaceList namespaceList;
        private PodList podList;
        private DeploymentsList deploymentsList;
        private int previousIndex;

        public Wizard(string ipAddress, string token, int control, string baseUrl)
        {
            InitializeComponent();
            _ipaddr = ipAddress;
            _baseUrl = baseUrl;
            _token = token;
            _control = control;
            validator = new Validator();
        }

        private async void Wizard_Load(object sender, EventArgs e)
        {
            InitiateConnection(_baseUrl, _token, _control, _ipaddr);
            AddButtonToTabPages();
            UpdateButtonStates();
            tabControl1.SelectedIndexChanged += TabControl1_SelectedIndexChanged;
            previousIndex = tabControl1.SelectedIndex; // Initialize previous index
            PopulateImageCombobox();
        }

        private async void InitiateConnection(string baseUrl, string token, int control, string ipAddress)
        {

            try
            {

                // Instantiate MethodsController class with user credentials and base URL
                kubernetesService = new KubernetesService(baseUrl, token, control);

                // Attempt to connect to the router
                baseUrl = ipAddress;
                if (control == 1)
                {
                    //string credentials = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{token}"));
                    httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                }
                await kubernetesService.TestConnection(); // Test connection asynchronously

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


        private void AddButtonToTabPages()
        {
            foreach (TabPage tabPage in tabControl1.TabPages)
            {
                Button backButton = new Button();
                backButton.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                backButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
                backButton.Location = new Point(8, tabPage.Height - 40); // Ajuste conforme necessário
                backButton.Name = "backButton";
                backButton.Size = new Size(75, 24);
                backButton.TabIndex = 1;
                backButton.Text = "&Back\r\n";
                backButton.UseVisualStyleBackColor = true;
                backButton.Click += new EventHandler(backButton_Click);


                // Botão "Next"
                Button nextButton = new Button();
                nextButton.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                nextButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
                nextButton.Location = new Point(89, tabPage.Height - 40); // Ajuste conforme necessário
                nextButton.Name = "nextButton";
                nextButton.Size = new Size(75, 24);
                nextButton.TabIndex = 0;
                nextButton.Text = "&Next";
                nextButton.UseVisualStyleBackColor = true;
                nextButton.Click += new EventHandler(nextButton_Click);

                // Botão "Finish"
                Button finishButton = new Button();
                finishButton.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                finishButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
                finishButton.Location = new Point(tabPage.Width - 90, tabPage.Height - 40); // Ajuste conforme necessário
                finishButton.Name = "finishButton";
                finishButton.Size = new Size(75, 24);
                finishButton.TabIndex = 2;
                finishButton.Text = "&Finish";
                finishButton.UseVisualStyleBackColor = true;
                finishButton.Click += new EventHandler(finishButton_Click);


                tabPage.Controls.Add(backButton);
                tabPage.Controls.Add(nextButton);
                tabPage.Controls.Add(finishButton);
            }
        }
        private void UpdateButtonStates()
        {
            foreach (TabPage tabPage in tabControl1.TabPages)
            {
                var backButton = tabPage.Controls.OfType<Button>().FirstOrDefault(b => b.Name == "backButton");
                var nextButton = tabPage.Controls.OfType<Button>().FirstOrDefault(b => b.Name == "nextButton");

                if (tabControl1.SelectedIndex == 0)
                {
                    backButton.Enabled = false;
                    nextButton.Enabled = true;
                }
                else if (tabControl1.SelectedIndex == tabControl1.TabCount - 1)
                {
                    backButton.Enabled = true;
                    nextButton.Enabled = false;
                }
                else
                {
                    backButton.Enabled = true;
                    nextButton.Enabled = true;
                }
            }
        }

        private async void finishButton_Click(object sender, EventArgs e)
        {
            if(namespaceItem == null)
            {
                MessageBox.Show("Please Create a Namespace");
                tabControl1.SelectedIndex = 1;
                return;
            }
            if (podItem == null)
            {
                MessageBox.Show("Please Create a Pod");
                tabControl1.SelectedIndex = 2;
                return;
            }
            if (deploymentItem == null)
            {
                MessageBox.Show("Please Create a Deployment");
                tabControl1.SelectedIndex = 3;
                return;
            }
            await kubernetesService.CreateNamespace(namespaceItem);
            await kubernetesService.CreatePod(podItem, namespaceItem.Metadata.Name);
            await kubernetesService.CreateDeployment(deploymentItem, namespaceItem.Metadata.Name);
            Close();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex < tabControl1.TabCount - 1)
            {
                tabControl1.SelectedIndex++;
                UpdateButtonStates();

            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex > 0)
            {
                tabControl1.SelectedIndex--;
                UpdateButtonStates();

            }
        }
        private async void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateButtonStates();
            TabControl tabControl1 = (TabControl)sender;

            // Get the current tab index
            int currentIndex = tabControl1.SelectedIndex;

            // Validate based on the current tab index
            switch (currentIndex)
            {
                case 0:
                    // This is the first tab, no validation needed to move forward
                    break;
                case 1:
                    break;
                case 2:
                    namespaceList = await kubernetesService.RetrieveNamespaces();
                    // Validation for the second tab (namespace)
                    if (textBoxNamespaceName.Text.Trim() == "" || !validator.ValidateNamespace(textBoxNamespaceName.Text))
                    {
                        MessageBox.Show("Please Choose a Valid name for a Namespace");
                        tabControl1.SelectedIndex = previousIndex;
                        return;
                    }
                    foreach (var namespaceLocal in namespaceList.Items)
                    {
                        if (textBoxNamespaceName.Text == namespaceLocal.Metadata.Name)
                        {
                            MessageBox.Show($"Namespace: {textBoxNamespaceName.Text} already exists.");
                            tabControl1.SelectedIndex = previousIndex;

                            return;
                        }
                    }
                    if (!validator.ValidateLabels(textBoxNamespaceLabels.Text))
                    {
                        MessageBox.Show("Please Choose a valid labels");
                        tabControl1.SelectedIndex = previousIndex;
                        return;
                    }
                    if (!validator.ValidateAnnotations(textBoxNamespacesAnnotations.Text))
                    {
                        MessageBox.Show("Please Choose a valid annotation");
                        tabControl1.SelectedIndex = previousIndex;
                        return;
                    }
                    namespaceItem = CreateNamespaceFromForms();
                    break;
                case 3:
                    podList = await kubernetesService.RetrievePods(textBoxNamespaceName.Text);
                    if (textBoxPodName.Text.Trim() == "" || !validator.ValidateNamespace(textBoxPodName.Text))
                    {
                        MessageBox.Show("Please Choose a Valid name");
                        tabControl1.SelectedIndex = previousIndex;
                        return;
                    }
                    if (containerNameText.Text.Trim() == "" || !validator.ValidateNamespace(containerNameText.Text))
                    {
                        MessageBox.Show("Please Choose a Valid name");
                        tabControl1.SelectedIndex = previousIndex;
                        return;
                    }
                    // Check if podList is null before accessing it
                    if (podList == null || podList.Items == null)
                    {
                        MessageBox.Show("Pod list is not initialized. Please try again.");
                        tabControl1.SelectedIndex = previousIndex;
                        return;
                    }

                    foreach (var podLocal in podList.Items)
                    {
                        if (textBoxPodName.Text == podLocal.Metadata.Name)
                        {
                            MessageBox.Show($"Pod: {textBoxPodName.Text} already exists.");
                            tabControl1.SelectedIndex = previousIndex;
                            return;
                        }
                    }

                    if (!validator.ValidateLabels(textBoxPodLabel.Text))
                    {
                        MessageBox.Show("Please Choose valid labels");
                        tabControl1.SelectedIndex = previousIndex;
                        return;
                    }

                    if (imagePodCombobox.SelectedItem.ToString() == null)
                    {
                        MessageBox.Show("Please select an image");
                        tabControl1.SelectedIndex = previousIndex;
                        return;
                    }
                    podItem = CreatePodFromForms();
                    break;
                case 4:
                    if (textBoxNamespaceName.Text.Trim() == "")
                    {
                        MessageBox.Show("Please select a namespace");
                        tabControl1.SelectedIndex = previousIndex;
                        return;
                    }
                    if (textBoxDeploymentName.Text.Trim() == "" || !validator.ValidateNamespace(textBoxDeploymentName.Text))
                    {
                        MessageBox.Show("Please Choose a Valid name");
                        tabControl1.SelectedIndex = previousIndex;
                        return;
                    }
                    if (containerNameDeploy.Text.Trim() == "" || !validator.ValidateNamespace(containerNameDeploy.Text))
                    {
                        MessageBox.Show("Please Choose a Valid name");
                        tabControl1.SelectedIndex = previousIndex;
                        return;
                    }
                    deploymentsList = await kubernetesService.RetrieveDeployments(textBoxNamespaceName.Text);
                    // Check if podList is null before accessing it
                    if (deploymentsList == null || deploymentsList.Items == null)
                    {
                        MessageBox.Show("Deployments list is not initialized. Please try again.");
                        tabControl1.SelectedIndex = previousIndex;
                        return;
                    }

                    foreach (var deployment in deploymentsList.Items)
                    {
                        if (textBoxDeploymentName.Text == deployment.Metadata.Name)
                        {
                            MessageBox.Show($"Deployment: {textBoxDeploymentName.Text} already exists.");
                            tabControl1.SelectedIndex = previousIndex;
                            return;
                        }
                    }

                    if (!validator.ValidateLabels(textBoxDeploymentLabel.Text))
                    {
                        MessageBox.Show("Please Choose valid labels");
                        tabControl1.SelectedIndex = previousIndex;
                        return;
                    }
                    if (!validator.ValidatePorts(PortsDeploy.Text))
                    {
                        MessageBox.Show("Please type ports correctly example: 80,443,(...)");
                        tabControl1.SelectedIndex = previousIndex;
                        return;
                    }

                    if (imageDeployment.SelectedItem.ToString() == null)
                    {
                        MessageBox.Show("Please select an image");
                        tabControl1.SelectedIndex = previousIndex;
                        return;
                    }
                    deploymentItem = CreateDeploymentFromForms();
                    break;

            }
            previousIndex = currentIndex;

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
                    Namespace = textBoxNamespaceName.Text,
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

        private DeploymentItem CreateDeploymentFromForms()
        {
            // Create a DeploymentItem object
            DeploymentItem deploymentItem = new DeploymentItem
            {
                Metadata = new DeploymentMetadata
                {
                    Name = textBoxDeploymentName.Text.Trim(),
                    Namespace = textBoxNamespaceName.Text,
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



    }
}
