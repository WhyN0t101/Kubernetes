namespace Kubernetes
{
    partial class Wizard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Wizard));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.IntroductionTab = new System.Windows.Forms.TabPage();
            this.namespaceTab = new System.Windows.Forms.TabPage();
            this.podTab = new System.Windows.Forms.TabPage();
            this.deploymentTab = new System.Windows.Forms.TabPage();
            this.ConclusionTab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBoxNamespacesAnnotations = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.textBoxNamespaceName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxNamespaceLabels = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.containerNameText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.imagePodCombobox = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxPodLabel = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxPodName = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.containerNameDeploy = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.PortsDeploy = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.imageDeployment = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.replicasUpDownDeploy = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxDeploymentLabel = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxDeploymentName = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.IntroductionTab.SuspendLayout();
            this.namespaceTab.SuspendLayout();
            this.podTab.SuspendLayout();
            this.deploymentTab.SuspendLayout();
            this.ConclusionTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.replicasUpDownDeploy)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.IntroductionTab);
            this.tabControl1.Controls.Add(this.namespaceTab);
            this.tabControl1.Controls.Add(this.podTab);
            this.tabControl1.Controls.Add(this.deploymentTab);
            this.tabControl1.Controls.Add(this.ConclusionTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(962, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // IntroductionTab
            // 
            this.IntroductionTab.Controls.Add(this.panel1);
            this.IntroductionTab.Controls.Add(this.textBox1);
            this.IntroductionTab.Controls.Add(this.label1);
            this.IntroductionTab.Location = new System.Drawing.Point(4, 27);
            this.IntroductionTab.Name = "IntroductionTab";
            this.IntroductionTab.Padding = new System.Windows.Forms.Padding(3);
            this.IntroductionTab.Size = new System.Drawing.Size(954, 419);
            this.IntroductionTab.TabIndex = 0;
            this.IntroductionTab.Text = "Introduction";
            this.IntroductionTab.UseVisualStyleBackColor = true;
            // 
            // namespaceTab
            // 
            this.namespaceTab.Controls.Add(this.textBoxNamespacesAnnotations);
            this.namespaceTab.Controls.Add(this.label22);
            this.namespaceTab.Controls.Add(this.textBoxNamespaceName);
            this.namespaceTab.Controls.Add(this.label8);
            this.namespaceTab.Controls.Add(this.label7);
            this.namespaceTab.Controls.Add(this.textBoxNamespaceLabels);
            this.namespaceTab.Controls.Add(this.textBox2);
            this.namespaceTab.Controls.Add(this.label2);
            this.namespaceTab.Location = new System.Drawing.Point(4, 27);
            this.namespaceTab.Name = "namespaceTab";
            this.namespaceTab.Padding = new System.Windows.Forms.Padding(3);
            this.namespaceTab.Size = new System.Drawing.Size(954, 419);
            this.namespaceTab.TabIndex = 1;
            this.namespaceTab.Text = "Namespace";
            this.namespaceTab.UseVisualStyleBackColor = true;
            // 
            // podTab
            // 
            this.podTab.Controls.Add(this.label23);
            this.podTab.Controls.Add(this.containerNameText);
            this.podTab.Controls.Add(this.label6);
            this.podTab.Controls.Add(this.imagePodCombobox);
            this.podTab.Controls.Add(this.label13);
            this.podTab.Controls.Add(this.textBoxPodLabel);
            this.podTab.Controls.Add(this.label14);
            this.podTab.Controls.Add(this.textBoxPodName);
            this.podTab.Controls.Add(this.textBox3);
            this.podTab.Controls.Add(this.label3);
            this.podTab.Location = new System.Drawing.Point(4, 27);
            this.podTab.Name = "podTab";
            this.podTab.Padding = new System.Windows.Forms.Padding(3);
            this.podTab.Size = new System.Drawing.Size(954, 419);
            this.podTab.TabIndex = 2;
            this.podTab.Text = "Pod";
            this.podTab.UseVisualStyleBackColor = true;
            // 
            // deploymentTab
            // 
            this.deploymentTab.Controls.Add(this.label26);
            this.deploymentTab.Controls.Add(this.containerNameDeploy);
            this.deploymentTab.Controls.Add(this.label25);
            this.deploymentTab.Controls.Add(this.PortsDeploy);
            this.deploymentTab.Controls.Add(this.label24);
            this.deploymentTab.Controls.Add(this.imageDeployment);
            this.deploymentTab.Controls.Add(this.label9);
            this.deploymentTab.Controls.Add(this.replicasUpDownDeploy);
            this.deploymentTab.Controls.Add(this.label15);
            this.deploymentTab.Controls.Add(this.textBoxDeploymentLabel);
            this.deploymentTab.Controls.Add(this.label16);
            this.deploymentTab.Controls.Add(this.textBoxDeploymentName);
            this.deploymentTab.Controls.Add(this.textBox4);
            this.deploymentTab.Controls.Add(this.label4);
            this.deploymentTab.Location = new System.Drawing.Point(4, 27);
            this.deploymentTab.Name = "deploymentTab";
            this.deploymentTab.Padding = new System.Windows.Forms.Padding(3);
            this.deploymentTab.Size = new System.Drawing.Size(954, 419);
            this.deploymentTab.TabIndex = 3;
            this.deploymentTab.Text = "Deployment";
            this.deploymentTab.UseVisualStyleBackColor = true;
            // 
            // ConclusionTab
            // 
            this.ConclusionTab.Controls.Add(this.textBox5);
            this.ConclusionTab.Controls.Add(this.label5);
            this.ConclusionTab.Location = new System.Drawing.Point(4, 27);
            this.ConclusionTab.Name = "ConclusionTab";
            this.ConclusionTab.Padding = new System.Windows.Forms.Padding(3);
            this.ConclusionTab.Size = new System.Drawing.Size(954, 419);
            this.ConclusionTab.TabIndex = 4;
            this.ConclusionTab.Text = "Conclusion";
            this.ConclusionTab.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(354, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to the Kubernetes setup Wizard";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(354, 72);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(427, 186);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Welcome to the Kubernetes Setup Wizard! \r\n\r\nThis wizard will guide you through th" +
    "e process of setting up a Kubernetes environment, creating a namespace, deployin" +
    "g a pod, and deploying an application.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kubernetes.Properties.Resources.tool;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(8, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 363);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Step 1: Create Namespace";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Step 2: Create Pod\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Step 3: Deploy Application\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Step 4: Conclusion";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(6, 56);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(624, 316);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // textBoxNamespacesAnnotations
            // 
            this.textBoxNamespacesAnnotations.Location = new System.Drawing.Point(639, 294);
            this.textBoxNamespacesAnnotations.Multiline = true;
            this.textBoxNamespacesAnnotations.Name = "textBoxNamespacesAnnotations";
            this.textBoxNamespacesAnnotations.Size = new System.Drawing.Size(288, 78);
            this.textBoxNamespacesAnnotations.TabIndex = 21;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(636, 277);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(88, 14);
            this.label22.TabIndex = 22;
            this.label22.Text = "Annotations:";
            // 
            // textBoxNamespaceName
            // 
            this.textBoxNamespaceName.Location = new System.Drawing.Point(639, 76);
            this.textBoxNamespaceName.Name = "textBoxNamespaceName";
            this.textBoxNamespaceName.Size = new System.Drawing.Size(115, 26);
            this.textBoxNamespaceName.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(636, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 14);
            this.label8.TabIndex = 20;
            this.label8.Text = "Labels:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(636, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 14);
            this.label7.TabIndex = 18;
            this.label7.Text = "Name:";
            // 
            // textBoxNamespaceLabels
            // 
            this.textBoxNamespaceLabels.Location = new System.Drawing.Point(639, 142);
            this.textBoxNamespaceLabels.Multiline = true;
            this.textBoxNamespaceLabels.Name = "textBoxNamespaceLabels";
            this.textBoxNamespaceLabels.Size = new System.Drawing.Size(288, 117);
            this.textBoxNamespaceLabels.TabIndex = 19;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(6, 56);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(642, 316);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = resources.GetString("textBox3.Text");
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(6, 56);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox4.Size = new System.Drawing.Size(641, 316);
            this.textBox4.TabIndex = 4;
            this.textBox4.Text = resources.GetString("textBox4.Text");
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(6, 56);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(624, 316);
            this.textBox5.TabIndex = 4;
            this.textBox5.Text = "Congratulations! \r\nYou have successfully configured your Kubernetes environment u" +
    "sing the Setup Wizard. Below is a summary of your setup:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(800, 97);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(113, 14);
            this.label23.TabIndex = 32;
            this.label23.Text = "Container name:";
            // 
            // containerNameText
            // 
            this.containerNameText.Location = new System.Drawing.Point(803, 118);
            this.containerNameText.Name = "containerNameText";
            this.containerNameText.Size = new System.Drawing.Size(100, 26);
            this.containerNameText.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(657, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 14);
            this.label6.TabIndex = 30;
            this.label6.Text = "Image:";
            // 
            // imagePodCombobox
            // 
            this.imagePodCombobox.FormattingEnabled = true;
            this.imagePodCombobox.Location = new System.Drawing.Point(658, 189);
            this.imagePodCombobox.Name = "imagePodCombobox";
            this.imagePodCombobox.Size = new System.Drawing.Size(121, 26);
            this.imagePodCombobox.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(655, 234);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 14);
            this.label13.TabIndex = 28;
            this.label13.Text = "Labels:";
            // 
            // textBoxPodLabel
            // 
            this.textBoxPodLabel.Location = new System.Drawing.Point(658, 255);
            this.textBoxPodLabel.Multiline = true;
            this.textBoxPodLabel.Name = "textBoxPodLabel";
            this.textBoxPodLabel.Size = new System.Drawing.Size(288, 117);
            this.textBoxPodLabel.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(657, 97);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 14);
            this.label14.TabIndex = 26;
            this.label14.Text = "Name:";
            // 
            // textBoxPodName
            // 
            this.textBoxPodName.Location = new System.Drawing.Point(660, 118);
            this.textBoxPodName.Name = "textBoxPodName";
            this.textBoxPodName.Size = new System.Drawing.Size(115, 26);
            this.textBoxPodName.TabIndex = 25;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.Location = new System.Drawing.Point(822, 114);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(114, 14);
            this.label26.TabIndex = 45;
            this.label26.Text = "Container Name:";
            // 
            // containerNameDeploy
            // 
            this.containerNameDeploy.Location = new System.Drawing.Point(825, 135);
            this.containerNameDeploy.Name = "containerNameDeploy";
            this.containerNameDeploy.Size = new System.Drawing.Size(115, 26);
            this.containerNameDeploy.TabIndex = 44;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(655, 114);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(45, 14);
            this.label25.TabIndex = 43;
            this.label25.Text = "Ports:";
            // 
            // PortsDeploy
            // 
            this.PortsDeploy.Location = new System.Drawing.Point(658, 135);
            this.PortsDeploy.Name = "PortsDeploy";
            this.PortsDeploy.Size = new System.Drawing.Size(115, 26);
            this.PortsDeploy.TabIndex = 42;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(822, 163);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(52, 14);
            this.label24.TabIndex = 41;
            this.label24.Text = "Image:";
            // 
            // imageDeployment
            // 
            this.imageDeployment.FormattingEnabled = true;
            this.imageDeployment.Location = new System.Drawing.Point(825, 184);
            this.imageDeployment.Name = "imageDeployment";
            this.imageDeployment.Size = new System.Drawing.Size(121, 26);
            this.imageDeployment.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(655, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 14);
            this.label9.TabIndex = 40;
            this.label9.Text = "Replicas:";
            // 
            // replicasUpDownDeploy
            // 
            this.replicasUpDownDeploy.Location = new System.Drawing.Point(658, 185);
            this.replicasUpDownDeploy.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.replicasUpDownDeploy.Name = "replicasUpDownDeploy";
            this.replicasUpDownDeploy.Size = new System.Drawing.Size(120, 26);
            this.replicasUpDownDeploy.TabIndex = 38;
            this.replicasUpDownDeploy.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(655, 234);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 14);
            this.label15.TabIndex = 37;
            this.label15.Text = "Labels:";
            // 
            // textBoxDeploymentLabel
            // 
            this.textBoxDeploymentLabel.Location = new System.Drawing.Point(658, 255);
            this.textBoxDeploymentLabel.Multiline = true;
            this.textBoxDeploymentLabel.Name = "textBoxDeploymentLabel";
            this.textBoxDeploymentLabel.Size = new System.Drawing.Size(288, 117);
            this.textBoxDeploymentLabel.TabIndex = 36;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(655, 64);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 14);
            this.label16.TabIndex = 35;
            this.label16.Text = "Name:";
            // 
            // textBoxDeploymentName
            // 
            this.textBoxDeploymentName.Location = new System.Drawing.Point(658, 85);
            this.textBoxDeploymentName.Name = "textBoxDeploymentName";
            this.textBoxDeploymentName.Size = new System.Drawing.Size(115, 26);
            this.textBoxDeploymentName.TabIndex = 34;
            // 
            // Wizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Wizard";
            this.Text = "Wizard";
            this.Load += new System.EventHandler(this.Wizard_Load);
            this.tabControl1.ResumeLayout(false);
            this.IntroductionTab.ResumeLayout(false);
            this.IntroductionTab.PerformLayout();
            this.namespaceTab.ResumeLayout(false);
            this.namespaceTab.PerformLayout();
            this.podTab.ResumeLayout(false);
            this.podTab.PerformLayout();
            this.deploymentTab.ResumeLayout(false);
            this.deploymentTab.PerformLayout();
            this.ConclusionTab.ResumeLayout(false);
            this.ConclusionTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.replicasUpDownDeploy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage IntroductionTab;
        private System.Windows.Forms.TabPage namespaceTab;
        private System.Windows.Forms.TabPage podTab;
        private System.Windows.Forms.TabPage deploymentTab;
        private System.Windows.Forms.TabPage ConclusionTab;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxNamespacesAnnotations;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBoxNamespaceName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxNamespaceLabels;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox containerNameText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox imagePodCombobox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxPodLabel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxPodName;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox containerNameDeploy;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox PortsDeploy;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox imageDeployment;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown replicasUpDownDeploy;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxDeploymentLabel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxDeploymentName;
    }
}