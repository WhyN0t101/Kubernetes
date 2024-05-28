﻿namespace Kubernetes
{
    partial class Form1
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.loginTab = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLoginToken = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLoginIp = new System.Windows.Forms.TextBox();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.checkBoxHttps = new System.Windows.Forms.CheckBox();
            this.ResourcesTab = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.comboNameSpaceChart = new System.Windows.Forms.ComboBox();
            this.NodesTab = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listViewNodes = new System.Windows.Forms.ListView();
            this.columnHeaderNodeName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNodeLabels = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNodeCreation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNodeCpuUsed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNodeCpuAvai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNodeAddrType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNodeAddr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNodeOS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNodeOSImg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNodeArch = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.NamespacesTab = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonNamespaceDelete = new System.Windows.Forms.Button();
            this.listViewNamespaces = new System.Windows.Forms.ListView();
            this.columnHeaderNamespaceName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNamespaceLabels = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNamespaceCreationTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNamespaceFinalizers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNamespacePhase = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonNamespaceCreate = new System.Windows.Forms.Button();
            this.textBoxNamespaceName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxNamespaceLabels = new System.Windows.Forms.TextBox();
            this.PodsTab = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonPodDelete = new System.Windows.Forms.Button();
            this.listViewPods = new System.Windows.Forms.ListView();
            this.columnHeaderPodName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPodNamespace = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPodCreationTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPodNamespaceImg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPodPorts = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPodNodename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPodPhase = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonPodCreate = new System.Windows.Forms.Button();
            this.comboBoxNamespacePod = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxPodLabel = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxPodName = new System.Windows.Forms.TextBox();
            this.DeploymentsTab = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.listViewDeployments = new System.Windows.Forms.ListView();
            this.columnHeaderDeploymentName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDeploymentLabels = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDeploymentNamespace = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDeploymentCreationTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDeploymentType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonDeploymentDelete = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonDeploymentCreate = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBoxDeploymentOpcao = new System.Windows.Forms.ComboBox();
            this.textBoxDeploymentLabel = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.comboBoxDeploymentType = new System.Windows.Forms.ComboBox();
            this.textBoxDeploymentName = new System.Windows.Forms.TextBox();
            this.labelDeployment = new System.Windows.Forms.Label();
            this.ServiceIngressTab = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.listViewServices = new System.Windows.Forms.ListView();
            this.columnHeaderServiceName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderServiceNamespace = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderServiceCreationTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderServiceLabels = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderServicePort = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderServiceClusterIp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonServiceDelete = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.buttonServiceCreate = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxServicesName = new System.Windows.Forms.TextBox();
            this.textBoxServicesLabels = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBoxNamespacesAnnotations = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.loginTab.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ResourcesTab.SuspendLayout();
            this.panel2.SuspendLayout();
            this.NodesTab.SuspendLayout();
            this.panel3.SuspendLayout();
            this.NamespacesTab.SuspendLayout();
            this.panel4.SuspendLayout();
            this.PodsTab.SuspendLayout();
            this.panel5.SuspendLayout();
            this.DeploymentsTab.SuspendLayout();
            this.panel6.SuspendLayout();
            this.ServiceIngressTab.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.loginTab);
            this.tabControl1.Controls.Add(this.ResourcesTab);
            this.tabControl1.Controls.Add(this.NodesTab);
            this.tabControl1.Controls.Add(this.NamespacesTab);
            this.tabControl1.Controls.Add(this.PodsTab);
            this.tabControl1.Controls.Add(this.DeploymentsTab);
            this.tabControl1.Controls.Add(this.ServiceIngressTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1107, 487);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged_1);
            // 
            // loginTab
            // 
            this.loginTab.BackgroundImage = global::Kubernetes.Properties.Resources.background1;
            this.loginTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginTab.Controls.Add(this.panel1);
            this.loginTab.Location = new System.Drawing.Point(4, 27);
            this.loginTab.Name = "loginTab";
            this.loginTab.Padding = new System.Windows.Forms.Padding(3);
            this.loginTab.Size = new System.Drawing.Size(1099, 456);
            this.loginTab.TabIndex = 0;
            this.loginTab.Text = "Login";
            this.loginTab.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxLoginToken);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxLoginIp);
            this.panel1.Controls.Add(this.buttonDisconnect);
            this.panel1.Controls.Add(this.buttonLogin);
            this.panel1.Controls.Add(this.checkBoxHttps);
            this.panel1.Location = new System.Drawing.Point(308, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 371);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Kubernetes.Properties.Resources.kuber1;
            this.pictureBox1.Location = new System.Drawing.Point(148, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(56, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Token:";
            // 
            // textBoxLoginToken
            // 
            this.textBoxLoginToken.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLoginToken.Enabled = false;
            this.textBoxLoginToken.Location = new System.Drawing.Point(148, 263);
            this.textBoxLoginToken.Name = "textBoxLoginToken";
            this.textBoxLoginToken.Size = new System.Drawing.Size(175, 26);
            this.textBoxLoginToken.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(98, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "IP:";
            // 
            // textBoxLoginIp
            // 
            this.textBoxLoginIp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLoginIp.Location = new System.Drawing.Point(148, 215);
            this.textBoxLoginIp.Name = "textBoxLoginIp";
            this.textBoxLoginIp.Size = new System.Drawing.Size(175, 26);
            this.textBoxLoginIp.TabIndex = 1;
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisconnect.Location = new System.Drawing.Point(251, 299);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(144, 40);
            this.buttonDisconnect.TabIndex = 7;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(56, 299);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(147, 40);
            this.buttonLogin.TabIndex = 3;
            this.buttonLogin.Text = "Connect";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // checkBoxHttps
            // 
            this.checkBoxHttps.AutoSize = true;
            this.checkBoxHttps.BackColor = System.Drawing.Color.Gainsboro;
            this.checkBoxHttps.Location = new System.Drawing.Point(329, 266);
            this.checkBoxHttps.Name = "checkBoxHttps";
            this.checkBoxHttps.Size = new System.Drawing.Size(70, 22);
            this.checkBoxHttps.TabIndex = 6;
            this.checkBoxHttps.Text = "https";
            this.checkBoxHttps.UseVisualStyleBackColor = false;
            this.checkBoxHttps.CheckedChanged += new System.EventHandler(this.checkBoxHttps_CheckedChanged);
            // 
            // ResourcesTab
            // 
            this.ResourcesTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ResourcesTab.Controls.Add(this.panel2);
            this.ResourcesTab.Location = new System.Drawing.Point(4, 27);
            this.ResourcesTab.Name = "ResourcesTab";
            this.ResourcesTab.Padding = new System.Windows.Forms.Padding(3);
            this.ResourcesTab.Size = new System.Drawing.Size(1099, 456);
            this.ResourcesTab.TabIndex = 1;
            this.ResourcesTab.Text = "Resources";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.comboNameSpaceChart);
            this.panel2.Location = new System.Drawing.Point(8, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1067, 375);
            this.panel2.TabIndex = 7;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(23, 152);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(45, 18);
            this.label21.TabIndex = 10;
            this.label21.Text = "Pod:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(23, 31);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(109, 18);
            this.label20.TabIndex = 9;
            this.label20.Text = "Namespace:";
            // 
            // comboNameSpaceChart
            // 
            this.comboNameSpaceChart.FormattingEnabled = true;
            this.comboNameSpaceChart.Location = new System.Drawing.Point(23, 63);
            this.comboNameSpaceChart.Name = "comboNameSpaceChart";
            this.comboNameSpaceChart.Size = new System.Drawing.Size(184, 31);
            this.comboNameSpaceChart.TabIndex = 7;
            this.comboNameSpaceChart.SelectedIndexChanged += new System.EventHandler(this.comboNameSpaceChart_SelectedIndexChanged);
            this.comboNameSpaceChart.Enter += new System.EventHandler(this.comboNameSpaceChart_Enter);
            // 
            // NodesTab
            // 
            this.NodesTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NodesTab.Controls.Add(this.panel3);
            this.NodesTab.Location = new System.Drawing.Point(4, 27);
            this.NodesTab.Name = "NodesTab";
            this.NodesTab.Padding = new System.Windows.Forms.Padding(3);
            this.NodesTab.Size = new System.Drawing.Size(1099, 456);
            this.NodesTab.TabIndex = 2;
            this.NodesTab.Text = "Nodes";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.listViewNodes);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(8, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1085, 447);
            this.panel3.TabIndex = 7;
            // 
            // listViewNodes
            // 
            this.listViewNodes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNodeName,
            this.columnHeaderNodeLabels,
            this.columnHeaderNodeCreation,
            this.columnHeaderNodeCpuUsed,
            this.columnHeaderNodeCpuAvai,
            this.columnHeaderNodeAddrType,
            this.columnHeaderNodeAddr,
            this.columnHeaderNodeOS,
            this.columnHeaderNodeOSImg,
            this.columnHeaderNodeArch});
            this.listViewNodes.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "listViewGroup1";
            this.listViewNodes.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.listViewNodes.HideSelection = false;
            this.listViewNodes.Location = new System.Drawing.Point(11, 55);
            this.listViewNodes.Name = "listViewNodes";
            this.listViewNodes.Size = new System.Drawing.Size(1063, 387);
            this.listViewNodes.TabIndex = 0;
            this.listViewNodes.UseCompatibleStateImageBehavior = false;
            this.listViewNodes.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderNodeName
            // 
            this.columnHeaderNodeName.Text = "Name";
            this.columnHeaderNodeName.Width = 55;
            // 
            // columnHeaderNodeLabels
            // 
            this.columnHeaderNodeLabels.Text = "Labels";
            this.columnHeaderNodeLabels.Width = 58;
            // 
            // columnHeaderNodeCreation
            // 
            this.columnHeaderNodeCreation.Text = "Created";
            // 
            // columnHeaderNodeCpuUsed
            // 
            this.columnHeaderNodeCpuUsed.Text = "Used CPU";
            this.columnHeaderNodeCpuUsed.Width = 85;
            // 
            // columnHeaderNodeCpuAvai
            // 
            this.columnHeaderNodeCpuAvai.Text = "Available CPU";
            this.columnHeaderNodeCpuAvai.Width = 111;
            // 
            // columnHeaderNodeAddrType
            // 
            this.columnHeaderNodeAddrType.Text = "Address Type";
            this.columnHeaderNodeAddrType.Width = 114;
            // 
            // columnHeaderNodeAddr
            // 
            this.columnHeaderNodeAddr.Text = "Address";
            this.columnHeaderNodeAddr.Width = 71;
            // 
            // columnHeaderNodeOS
            // 
            this.columnHeaderNodeOS.Text = "OS";
            this.columnHeaderNodeOS.Width = 35;
            // 
            // columnHeaderNodeOSImg
            // 
            this.columnHeaderNodeOSImg.Text = "OS Image";
            this.columnHeaderNodeOSImg.Width = 88;
            // 
            // columnHeaderNodeArch
            // 
            this.columnHeaderNodeArch.Text = "Architecture";
            this.columnHeaderNodeArch.Width = 104;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(8, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nodes:";
            // 
            // NamespacesTab
            // 
            this.NamespacesTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NamespacesTab.Controls.Add(this.panel4);
            this.NamespacesTab.Location = new System.Drawing.Point(4, 27);
            this.NamespacesTab.Name = "NamespacesTab";
            this.NamespacesTab.Padding = new System.Windows.Forms.Padding(3);
            this.NamespacesTab.Size = new System.Drawing.Size(1099, 456);
            this.NamespacesTab.TabIndex = 3;
            this.NamespacesTab.Text = "Namespaces";
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.textBoxNamespacesAnnotations);
            this.panel4.Controls.Add(this.label22);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.buttonNamespaceDelete);
            this.panel4.Controls.Add(this.listViewNamespaces);
            this.panel4.Controls.Add(this.buttonNamespaceCreate);
            this.panel4.Controls.Add(this.textBoxNamespaceName);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.textBoxNamespaceLabels);
            this.panel4.Location = new System.Drawing.Point(8, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1085, 447);
            this.panel4.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(8, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Namespaces:";
            // 
            // buttonNamespaceDelete
            // 
            this.buttonNamespaceDelete.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNamespaceDelete.Location = new System.Drawing.Point(855, 378);
            this.buttonNamespaceDelete.Name = "buttonNamespaceDelete";
            this.buttonNamespaceDelete.Size = new System.Drawing.Size(75, 25);
            this.buttonNamespaceDelete.TabIndex = 14;
            this.buttonNamespaceDelete.Text = "Delete";
            this.buttonNamespaceDelete.UseVisualStyleBackColor = true;
            // 
            // listViewNamespaces
            // 
            this.listViewNamespaces.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNamespaceName,
            this.columnHeaderNamespaceLabels,
            this.columnHeaderNamespaceCreationTime,
            this.columnHeaderNamespaceFinalizers,
            this.columnHeaderNamespacePhase});
            this.listViewNamespaces.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            listViewGroup2.Header = "ListViewGroup";
            listViewGroup2.Name = "listViewGroup1";
            this.listViewNamespaces.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup2});
            this.listViewNamespaces.HideSelection = false;
            this.listViewNamespaces.Location = new System.Drawing.Point(11, 57);
            this.listViewNamespaces.Name = "listViewNamespaces";
            this.listViewNamespaces.Size = new System.Drawing.Size(729, 346);
            this.listViewNamespaces.TabIndex = 7;
            this.listViewNamespaces.UseCompatibleStateImageBehavior = false;
            this.listViewNamespaces.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderNamespaceName
            // 
            this.columnHeaderNamespaceName.Text = "Name";
            this.columnHeaderNamespaceName.Width = 72;
            // 
            // columnHeaderNamespaceLabels
            // 
            this.columnHeaderNamespaceLabels.Text = "Labels";
            this.columnHeaderNamespaceLabels.Width = 132;
            // 
            // columnHeaderNamespaceCreationTime
            // 
            this.columnHeaderNamespaceCreationTime.Text = "Created";
            this.columnHeaderNamespaceCreationTime.Width = 95;
            // 
            // columnHeaderNamespaceFinalizers
            // 
            this.columnHeaderNamespaceFinalizers.Text = "Finalizers";
            this.columnHeaderNamespaceFinalizers.Width = 85;
            // 
            // columnHeaderNamespacePhase
            // 
            this.columnHeaderNamespacePhase.Text = "Available";
            this.columnHeaderNamespacePhase.Width = 130;
            // 
            // buttonNamespaceCreate
            // 
            this.buttonNamespaceCreate.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNamespaceCreate.Location = new System.Drawing.Point(761, 378);
            this.buttonNamespaceCreate.Name = "buttonNamespaceCreate";
            this.buttonNamespaceCreate.Size = new System.Drawing.Size(75, 25);
            this.buttonNamespaceCreate.TabIndex = 13;
            this.buttonNamespaceCreate.Text = "Create";
            this.buttonNamespaceCreate.UseVisualStyleBackColor = true;
            this.buttonNamespaceCreate.Click += new System.EventHandler(this.buttonNamespaceCreate_Click);
            // 
            // textBoxNamespaceName
            // 
            this.textBoxNamespaceName.Location = new System.Drawing.Point(761, 76);
            this.textBoxNamespaceName.Name = "textBoxNamespaceName";
            this.textBoxNamespaceName.Size = new System.Drawing.Size(115, 26);
            this.textBoxNamespaceName.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(758, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 14);
            this.label8.TabIndex = 12;
            this.label8.Text = "Labels:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(758, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 14);
            this.label7.TabIndex = 10;
            this.label7.Text = "Name:";
            // 
            // textBoxNamespaceLabels
            // 
            this.textBoxNamespaceLabels.Location = new System.Drawing.Point(761, 142);
            this.textBoxNamespaceLabels.Multiline = true;
            this.textBoxNamespaceLabels.Name = "textBoxNamespaceLabels";
            this.textBoxNamespaceLabels.Size = new System.Drawing.Size(288, 117);
            this.textBoxNamespaceLabels.TabIndex = 11;
           
            // 
            // PodsTab
            // 
            this.PodsTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PodsTab.Controls.Add(this.panel5);
            this.PodsTab.Location = new System.Drawing.Point(4, 27);
            this.PodsTab.Name = "PodsTab";
            this.PodsTab.Padding = new System.Windows.Forms.Padding(3);
            this.PodsTab.Size = new System.Drawing.Size(1099, 456);
            this.PodsTab.TabIndex = 4;
            this.PodsTab.Text = "Pods";
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.buttonPodDelete);
            this.panel5.Controls.Add(this.listViewPods);
            this.panel5.Controls.Add(this.buttonPodCreate);
            this.panel5.Controls.Add(this.comboBoxNamespacePod);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.textBoxPodLabel);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.textBoxPodName);
            this.panel5.Location = new System.Drawing.Point(8, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1085, 447);
            this.panel5.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(8, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 18);
            this.label9.TabIndex = 9;
            this.label9.Text = "Pods:";
            // 
            // buttonPodDelete
            // 
            this.buttonPodDelete.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPodDelete.Location = new System.Drawing.Point(879, 335);
            this.buttonPodDelete.Name = "buttonPodDelete";
            this.buttonPodDelete.Size = new System.Drawing.Size(75, 25);
            this.buttonPodDelete.TabIndex = 20;
            this.buttonPodDelete.Text = "Delete";
            this.buttonPodDelete.UseVisualStyleBackColor = true;
            // 
            // listViewPods
            // 
            this.listViewPods.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderPodName,
            this.columnHeaderPodNamespace,
            this.columnHeaderPodCreationTime,
            this.columnHeaderPodNamespaceImg,
            this.columnHeaderPodPorts,
            this.columnHeaderPodNodename,
            this.columnHeaderPodPhase});
            this.listViewPods.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            listViewGroup3.Header = "ListViewGroup";
            listViewGroup3.Name = "listViewGroup1";
            this.listViewPods.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup3});
            this.listViewPods.HideSelection = false;
            this.listViewPods.Location = new System.Drawing.Point(11, 92);
            this.listViewPods.Name = "listViewPods";
            this.listViewPods.Size = new System.Drawing.Size(729, 346);
            this.listViewPods.TabIndex = 12;
            this.listViewPods.UseCompatibleStateImageBehavior = false;
            this.listViewPods.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderPodName
            // 
            this.columnHeaderPodName.Text = "Name";
            this.columnHeaderPodName.Width = 68;
            // 
            // columnHeaderPodNamespace
            // 
            this.columnHeaderPodNamespace.Text = "Namespace";
            this.columnHeaderPodNamespace.Width = 100;
            // 
            // columnHeaderPodCreationTime
            // 
            this.columnHeaderPodCreationTime.Text = "Created";
            this.columnHeaderPodCreationTime.Width = 95;
            // 
            // columnHeaderPodNamespaceImg
            // 
            this.columnHeaderPodNamespaceImg.Text = "Namespace Image";
            this.columnHeaderPodNamespaceImg.Width = 146;
            // 
            // columnHeaderPodPorts
            // 
            this.columnHeaderPodPorts.Text = "Ports";
            this.columnHeaderPodPorts.Width = 64;
            // 
            // columnHeaderPodNodename
            // 
            this.columnHeaderPodNodename.Text = "Node name";
            this.columnHeaderPodNodename.Width = 88;
            // 
            // columnHeaderPodPhase
            // 
            this.columnHeaderPodPhase.Text = "Phase";
            // 
            // buttonPodCreate
            // 
            this.buttonPodCreate.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPodCreate.Location = new System.Drawing.Point(768, 335);
            this.buttonPodCreate.Name = "buttonPodCreate";
            this.buttonPodCreate.Size = new System.Drawing.Size(75, 25);
            this.buttonPodCreate.TabIndex = 19;
            this.buttonPodCreate.Text = "Create";
            this.buttonPodCreate.UseVisualStyleBackColor = true;
            // 
            // comboBoxNamespacePod
            // 
            this.comboBoxNamespacePod.FormattingEnabled = true;
            this.comboBoxNamespacePod.Location = new System.Drawing.Point(11, 60);
            this.comboBoxNamespacePod.Name = "comboBoxNamespacePod";
            this.comboBoxNamespacePod.Size = new System.Drawing.Size(121, 26);
            this.comboBoxNamespacePod.TabIndex = 0;
            this.comboBoxNamespacePod.SelectedIndexChanged += new System.EventHandler(this.comboBoxNamespacePod_SelectedIndexChanged);
            this.comboBoxNamespacePod.Enter += new System.EventHandler(this.comboBoxNamespacePod_Enter);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(765, 172);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 14);
            this.label13.TabIndex = 18;
            this.label13.Text = "Labels:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(8, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 14);
            this.label10.TabIndex = 11;
            this.label10.Text = "Namespace:";
            // 
            // textBoxPodLabel
            // 
            this.textBoxPodLabel.Location = new System.Drawing.Point(768, 189);
            this.textBoxPodLabel.Multiline = true;
            this.textBoxPodLabel.Name = "textBoxPodLabel";
            this.textBoxPodLabel.Size = new System.Drawing.Size(288, 117);
            this.textBoxPodLabel.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(765, 108);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 14);
            this.label14.TabIndex = 16;
            this.label14.Text = "Name:";
            // 
            // textBoxPodName
            // 
            this.textBoxPodName.Location = new System.Drawing.Point(768, 128);
            this.textBoxPodName.Name = "textBoxPodName";
            this.textBoxPodName.Size = new System.Drawing.Size(115, 26);
            this.textBoxPodName.TabIndex = 15;
            // 
            // DeploymentsTab
            // 
            this.DeploymentsTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DeploymentsTab.Controls.Add(this.panel6);
            this.DeploymentsTab.Location = new System.Drawing.Point(4, 27);
            this.DeploymentsTab.Name = "DeploymentsTab";
            this.DeploymentsTab.Padding = new System.Windows.Forms.Padding(3);
            this.DeploymentsTab.Size = new System.Drawing.Size(1099, 456);
            this.DeploymentsTab.TabIndex = 5;
            this.DeploymentsTab.Text = "Deployments";
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Controls.Add(this.listViewDeployments);
            this.panel6.Controls.Add(this.buttonDeploymentDelete);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.buttonDeploymentCreate);
            this.panel6.Controls.Add(this.label15);
            this.panel6.Controls.Add(this.comboBoxDeploymentOpcao);
            this.panel6.Controls.Add(this.textBoxDeploymentLabel);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Controls.Add(this.label16);
            this.panel6.Controls.Add(this.comboBoxDeploymentType);
            this.panel6.Controls.Add(this.textBoxDeploymentName);
            this.panel6.Controls.Add(this.labelDeployment);
            this.panel6.Location = new System.Drawing.Point(8, 6);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1085, 447);
            this.panel6.TabIndex = 27;
            // 
            // listViewDeployments
            // 
            this.listViewDeployments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderDeploymentName,
            this.columnHeaderDeploymentLabels,
            this.columnHeaderDeploymentNamespace,
            this.columnHeaderDeploymentCreationTime,
            this.columnHeaderDeploymentType});
            this.listViewDeployments.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            listViewGroup4.Header = "ListViewGroup";
            listViewGroup4.Name = "listViewGroup1";
            this.listViewDeployments.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup4});
            this.listViewDeployments.HideSelection = false;
            this.listViewDeployments.Location = new System.Drawing.Point(12, 106);
            this.listViewDeployments.Name = "listViewDeployments";
            this.listViewDeployments.Size = new System.Drawing.Size(729, 336);
            this.listViewDeployments.TabIndex = 16;
            this.listViewDeployments.UseCompatibleStateImageBehavior = false;
            this.listViewDeployments.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderDeploymentName
            // 
            this.columnHeaderDeploymentName.Text = "Name";
            this.columnHeaderDeploymentName.Width = 68;
            // 
            // columnHeaderDeploymentLabels
            // 
            this.columnHeaderDeploymentLabels.DisplayIndex = 3;
            this.columnHeaderDeploymentLabels.Text = "Labels";
            this.columnHeaderDeploymentLabels.Width = 120;
            // 
            // columnHeaderDeploymentNamespace
            // 
            this.columnHeaderDeploymentNamespace.DisplayIndex = 1;
            this.columnHeaderDeploymentNamespace.Text = "Namespace";
            this.columnHeaderDeploymentNamespace.Width = 100;
            // 
            // columnHeaderDeploymentCreationTime
            // 
            this.columnHeaderDeploymentCreationTime.DisplayIndex = 2;
            this.columnHeaderDeploymentCreationTime.Text = "Created";
            this.columnHeaderDeploymentCreationTime.Width = 95;
            // 
            // columnHeaderDeploymentType
            // 
            this.columnHeaderDeploymentType.Text = "Type";
            this.columnHeaderDeploymentType.Width = 64;
            // 
            // buttonDeploymentDelete
            // 
            this.buttonDeploymentDelete.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeploymentDelete.Location = new System.Drawing.Point(861, 338);
            this.buttonDeploymentDelete.Name = "buttonDeploymentDelete";
            this.buttonDeploymentDelete.Size = new System.Drawing.Size(75, 25);
            this.buttonDeploymentDelete.TabIndex = 26;
            this.buttonDeploymentDelete.Text = "Delete";
            this.buttonDeploymentDelete.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(8, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 18);
            this.label11.TabIndex = 10;
            this.label11.Text = "Deployments:";
            // 
            // buttonDeploymentCreate
            // 
            this.buttonDeploymentCreate.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeploymentCreate.Location = new System.Drawing.Point(780, 338);
            this.buttonDeploymentCreate.Name = "buttonDeploymentCreate";
            this.buttonDeploymentCreate.Size = new System.Drawing.Size(75, 25);
            this.buttonDeploymentCreate.TabIndex = 25;
            this.buttonDeploymentCreate.Text = "Create";
            this.buttonDeploymentCreate.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(777, 183);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 14);
            this.label15.TabIndex = 24;
            this.label15.Text = "Labels:";
            // 
            // comboBoxDeploymentOpcao
            // 
            this.comboBoxDeploymentOpcao.FormattingEnabled = true;
            this.comboBoxDeploymentOpcao.Items.AddRange(new object[] {
            "Everything",
            "Namespace",
            "Deployment Name"});
            this.comboBoxDeploymentOpcao.Location = new System.Drawing.Point(11, 71);
            this.comboBoxDeploymentOpcao.Name = "comboBoxDeploymentOpcao";
            this.comboBoxDeploymentOpcao.Size = new System.Drawing.Size(161, 26);
            this.comboBoxDeploymentOpcao.TabIndex = 12;
            // 
            // textBoxDeploymentLabel
            // 
            this.textBoxDeploymentLabel.Location = new System.Drawing.Point(780, 200);
            this.textBoxDeploymentLabel.Multiline = true;
            this.textBoxDeploymentLabel.Name = "textBoxDeploymentLabel";
            this.textBoxDeploymentLabel.Size = new System.Drawing.Size(288, 117);
            this.textBoxDeploymentLabel.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(8, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 14);
            this.label12.TabIndex = 13;
            this.label12.Text = "Opção de Procura:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(777, 114);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 14);
            this.label16.TabIndex = 22;
            this.label16.Text = "Name:";
            // 
            // comboBoxDeploymentType
            // 
            this.comboBoxDeploymentType.FormattingEnabled = true;
            this.comboBoxDeploymentType.Items.AddRange(new object[] {
            "Everything",
            "Namespace",
            "Deployment Name"});
            this.comboBoxDeploymentType.Location = new System.Drawing.Point(231, 74);
            this.comboBoxDeploymentType.Name = "comboBoxDeploymentType";
            this.comboBoxDeploymentType.Size = new System.Drawing.Size(161, 26);
            this.comboBoxDeploymentType.TabIndex = 14;
            // 
            // textBoxDeploymentName
            // 
            this.textBoxDeploymentName.Location = new System.Drawing.Point(780, 134);
            this.textBoxDeploymentName.Name = "textBoxDeploymentName";
            this.textBoxDeploymentName.Size = new System.Drawing.Size(115, 26);
            this.textBoxDeploymentName.TabIndex = 21;
            // 
            // labelDeployment
            // 
            this.labelDeployment.AutoSize = true;
            this.labelDeployment.BackColor = System.Drawing.Color.Transparent;
            this.labelDeployment.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeployment.ForeColor = System.Drawing.Color.Black;
            this.labelDeployment.Location = new System.Drawing.Point(228, 57);
            this.labelDeployment.Name = "labelDeployment";
            this.labelDeployment.Size = new System.Drawing.Size(87, 14);
            this.labelDeployment.TabIndex = 15;
            this.labelDeployment.Text = "Deployment:";
            // 
            // ServiceIngressTab
            // 
            this.ServiceIngressTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ServiceIngressTab.Controls.Add(this.panel7);
            this.ServiceIngressTab.Location = new System.Drawing.Point(4, 27);
            this.ServiceIngressTab.Name = "ServiceIngressTab";
            this.ServiceIngressTab.Padding = new System.Windows.Forms.Padding(3);
            this.ServiceIngressTab.Size = new System.Drawing.Size(1099, 456);
            this.ServiceIngressTab.TabIndex = 6;
            this.ServiceIngressTab.Text = " Services/Ingress";
            // 
            // panel7
            // 
            this.panel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.Controls.Add(this.listViewServices);
            this.panel7.Controls.Add(this.buttonServiceDelete);
            this.panel7.Controls.Add(this.label17);
            this.panel7.Controls.Add(this.buttonServiceCreate);
            this.panel7.Controls.Add(this.label18);
            this.panel7.Controls.Add(this.textBoxServicesName);
            this.panel7.Controls.Add(this.textBoxServicesLabels);
            this.panel7.Controls.Add(this.label19);
            this.panel7.Location = new System.Drawing.Point(8, 6);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1085, 447);
            this.panel7.TabIndex = 33;
            // 
            // listViewServices
            // 
            this.listViewServices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderServiceName,
            this.columnHeaderServiceNamespace,
            this.columnHeaderServiceCreationTime,
            this.columnHeaderServiceLabels,
            this.columnHeaderServicePort,
            this.columnHeaderServiceClusterIp});
            this.listViewServices.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            listViewGroup5.Header = "ListViewGroup";
            listViewGroup5.Name = "listViewGroup1";
            this.listViewServices.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup5});
            this.listViewServices.HideSelection = false;
            this.listViewServices.Location = new System.Drawing.Point(11, 44);
            this.listViewServices.Name = "listViewServices";
            this.listViewServices.Size = new System.Drawing.Size(729, 398);
            this.listViewServices.TabIndex = 12;
            this.listViewServices.UseCompatibleStateImageBehavior = false;
            this.listViewServices.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderServiceName
            // 
            this.columnHeaderServiceName.Text = "Name";
            this.columnHeaderServiceName.Width = 72;
            // 
            // columnHeaderServiceNamespace
            // 
            this.columnHeaderServiceNamespace.Text = "Namespace";
            this.columnHeaderServiceNamespace.Width = 132;
            // 
            // columnHeaderServiceCreationTime
            // 
            this.columnHeaderServiceCreationTime.Text = "Created";
            this.columnHeaderServiceCreationTime.Width = 95;
            // 
            // columnHeaderServiceLabels
            // 
            this.columnHeaderServiceLabels.Text = "Labels";
            this.columnHeaderServiceLabels.Width = 85;
            // 
            // columnHeaderServicePort
            // 
            this.columnHeaderServicePort.Text = "Port";
            this.columnHeaderServicePort.Width = 111;
            // 
            // columnHeaderServiceClusterIp
            // 
            this.columnHeaderServiceClusterIp.Text = "Cluster Ip";
            this.columnHeaderServiceClusterIp.Width = 96;
            // 
            // buttonServiceDelete
            // 
            this.buttonServiceDelete.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonServiceDelete.Location = new System.Drawing.Point(889, 373);
            this.buttonServiceDelete.Name = "buttonServiceDelete";
            this.buttonServiceDelete.Size = new System.Drawing.Size(75, 25);
            this.buttonServiceDelete.TabIndex = 32;
            this.buttonServiceDelete.Text = "Delete";
            this.buttonServiceDelete.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(8, 23);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(156, 18);
            this.label17.TabIndex = 11;
            this.label17.Text = "Services/Ingress:";
            // 
            // buttonServiceCreate
            // 
            this.buttonServiceCreate.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonServiceCreate.Location = new System.Drawing.Point(808, 373);
            this.buttonServiceCreate.Name = "buttonServiceCreate";
            this.buttonServiceCreate.Size = new System.Drawing.Size(75, 25);
            this.buttonServiceCreate.TabIndex = 31;
            this.buttonServiceCreate.Text = "Create";
            this.buttonServiceCreate.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(767, 199);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 14);
            this.label18.TabIndex = 30;
            this.label18.Text = "Labels:";
            // 
            // textBoxServicesName
            // 
            this.textBoxServicesName.Location = new System.Drawing.Point(822, 115);
            this.textBoxServicesName.Name = "textBoxServicesName";
            this.textBoxServicesName.Size = new System.Drawing.Size(115, 26);
            this.textBoxServicesName.TabIndex = 27;
            // 
            // textBoxServicesLabels
            // 
            this.textBoxServicesLabels.Location = new System.Drawing.Point(770, 216);
            this.textBoxServicesLabels.Multiline = true;
            this.textBoxServicesLabels.Name = "textBoxServicesLabels";
            this.textBoxServicesLabels.Size = new System.Drawing.Size(288, 117);
            this.textBoxServicesLabels.TabIndex = 29;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(819, 98);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(48, 14);
            this.label19.TabIndex = 28;
            this.label19.Text = "Name:";
            // 
            // textBoxNamespacesAnnotations
            // 
            this.textBoxNamespacesAnnotations.Location = new System.Drawing.Point(761, 294);
            this.textBoxNamespacesAnnotations.Multiline = true;
            this.textBoxNamespacesAnnotations.Name = "textBoxNamespacesAnnotations";
            this.textBoxNamespacesAnnotations.Size = new System.Drawing.Size(288, 78);
            this.textBoxNamespacesAnnotations.TabIndex = 15;

            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(758, 277);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(88, 14);
            this.label22.TabIndex = 16;
            this.label22.Text = "Annotations:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1107, 487);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Kubernetes Management Interface";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.loginTab.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResourcesTab.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.NodesTab.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.NamespacesTab.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.PodsTab.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.DeploymentsTab.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ServiceIngressTab.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ResourcesTab;
        private System.Windows.Forms.TabPage NodesTab;
        private System.Windows.Forms.TabPage NamespacesTab;
        private System.Windows.Forms.TabPage PodsTab;
        private System.Windows.Forms.TabPage DeploymentsTab;
        private System.Windows.Forms.ListView listViewNodes;
        private System.Windows.Forms.ColumnHeader columnHeaderNodeName;
        private System.Windows.Forms.ColumnHeader columnHeaderNodeLabels;
        private System.Windows.Forms.ColumnHeader columnHeaderNodeCpuUsed;
        private System.Windows.Forms.ColumnHeader columnHeaderNodeCpuAvai;
        private System.Windows.Forms.ColumnHeader columnHeaderNodeAddrType;
        private System.Windows.Forms.ColumnHeader columnHeaderNodeAddr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader columnHeaderNodeOS;
        private System.Windows.Forms.ColumnHeader columnHeaderNodeOSImg;
        private System.Windows.Forms.ColumnHeader columnHeaderNodeArch;
        private System.Windows.Forms.TabPage ServiceIngressTab;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listViewNamespaces;
        private System.Windows.Forms.ColumnHeader columnHeaderNamespaceName;
        private System.Windows.Forms.ColumnHeader columnHeaderNamespaceLabels;
        private System.Windows.Forms.ColumnHeader columnHeaderNamespaceCreationTime;
        private System.Windows.Forms.ColumnHeader columnHeaderNamespaceFinalizers;
        private System.Windows.Forms.ColumnHeader columnHeaderNamespacePhase;
        private System.Windows.Forms.TextBox textBoxNamespaceName;
        private System.Windows.Forms.Button buttonNamespaceDelete;
        private System.Windows.Forms.Button buttonNamespaceCreate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxNamespaceLabels;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView listViewPods;
        private System.Windows.Forms.ColumnHeader columnHeaderPodName;
        private System.Windows.Forms.ColumnHeader columnHeaderPodNamespace;
        private System.Windows.Forms.ColumnHeader columnHeaderPodCreationTime;
        private System.Windows.Forms.ColumnHeader columnHeaderPodNamespaceImg;
        private System.Windows.Forms.ColumnHeader columnHeaderPodPorts;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxNamespacePod;
        private System.Windows.Forms.ColumnHeader columnHeaderPodNodename;
        private System.Windows.Forms.ColumnHeader columnHeaderPodPhase;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelDeployment;
        private System.Windows.Forms.ComboBox comboBoxDeploymentType;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxDeploymentOpcao;
        private System.Windows.Forms.Button buttonPodDelete;
        private System.Windows.Forms.Button buttonPodCreate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxPodLabel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxPodName;
        private System.Windows.Forms.ListView listViewDeployments;
        private System.Windows.Forms.ColumnHeader columnHeaderDeploymentName;
        private System.Windows.Forms.ColumnHeader columnHeaderDeploymentNamespace;
        private System.Windows.Forms.ColumnHeader columnHeaderDeploymentCreationTime;
        private System.Windows.Forms.ColumnHeader columnHeaderDeploymentLabels;
        private System.Windows.Forms.ColumnHeader columnHeaderDeploymentType;
        private System.Windows.Forms.Button buttonDeploymentDelete;
        private System.Windows.Forms.Button buttonDeploymentCreate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxDeploymentLabel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxDeploymentName;
        private System.Windows.Forms.ListView listViewServices;
        private System.Windows.Forms.ColumnHeader columnHeaderServiceName;
        private System.Windows.Forms.ColumnHeader columnHeaderServiceNamespace;
        private System.Windows.Forms.ColumnHeader columnHeaderServiceCreationTime;
        private System.Windows.Forms.ColumnHeader columnHeaderServiceLabels;
        private System.Windows.Forms.ColumnHeader columnHeaderServicePort;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button buttonServiceDelete;
        private System.Windows.Forms.Button buttonServiceCreate;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBoxServicesLabels;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBoxServicesName;
        private System.Windows.Forms.ColumnHeader columnHeaderNodeCreation;
        private System.Windows.Forms.ColumnHeader columnHeaderServiceClusterIp;
        private System.Windows.Forms.TabPage loginTab;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLoginToken;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLoginIp;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.CheckBox checkBoxHttps;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox comboNameSpaceChart;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ToolTip LabelsToolTipNamespaces;
        private System.Windows.Forms.ToolTip NameTooltop;
        private System.Windows.Forms.TextBox textBoxNamespacesAnnotations;
        private System.Windows.Forms.Label label22;
    }
}

