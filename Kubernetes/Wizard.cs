using Kubernetes.Controller;
using Kubernetes.Model.Deployments;
using Kubernetes.Model.Namespaces;
using Kubernetes.Model.PodList;
using Kubernetes.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Kubernetes
{
    public partial class Wizard : Form
    {
        private KubernetesService kubernetesService;
        private NamespaceItem namespaceItem;
        private Validator validator;
        private PodItem podItem;
        private DeploymentItem deploymentItem;

        private NamespaceList namespaceList;

        public Wizard()
        {
            InitializeComponent();
        }

        private void Wizard_Load(object sender, EventArgs e)
        {
            AddButtonToTabPages();
            UpdateButtonStates();
            tabControl1.SelectedIndexChanged += TabControl1_SelectedIndexChanged;
        }

        

        private void AddButtonToTabPages()
        {
            foreach (TabPage tabPage in tabControl1.TabPages)
            {
                Button backButton = new Button();
                backButton.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                backButton.Location = new Point(8, 388);
                backButton.Name = "backButton";
                backButton.Size = new Size(75, 23);
                backButton.TabIndex = 1;
                backButton.Text = "&Back\r\n";
                backButton.UseVisualStyleBackColor = true;
                backButton.Click += new EventHandler(backButton_Click);


                Button nextButton = new Button();
                nextButton.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                nextButton.Location = new Point(89, 388);
                nextButton.Name = "nextButton";
                nextButton.Size = new Size(75, 23);
                nextButton.TabIndex = 0;
                nextButton.Text = "&Next";
                nextButton.UseVisualStyleBackColor = true;
                nextButton.Click += new EventHandler(nextButton_Click);


                Button finishButton = new Button();
                finishButton.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                finishButton.Location = new Point(688, 388);
                finishButton.Name = "finishButton";
                finishButton.Size = new Size(75, 23);
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

        private void finishButton_Click(object sender, EventArgs e)
        {
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
            TabControl tabControl = (TabControl)sender;

            // Get the current tab index
            int currentIndex = tabControl.SelectedIndex;

            // Validate based on the current tab index
            switch (currentIndex)
            {
                case 0:
                    // This is the first tab, no validation needed to move forward
                    break;
                case 1:
                    namespaceList = await kubernetesService.RetrieveNamespaces();
                    // Validation for the second tab (namespace)
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
                    break;
                case 2:
                    // Additional cases for other tabs if needed
                    break;
                case 3:
                    break;
                    // Add more cases as needed for other tabs
            }

            // If validation passes or no validation is needed, move to the next tab
            if (currentIndex < tabControl.TabCount - 1)
            {
                tabControl.SelectedIndex = currentIndex + 1;
            }
        }

    }
}
