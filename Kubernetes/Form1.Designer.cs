namespace Kubernetes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.loginTab = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxLoginToken = new System.Windows.Forms.TextBox();
            this.textBoxLoginIp = new System.Windows.Forms.TextBox();
            this.ResourcesTab = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.NodesTab = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.listViewNodes = new System.Windows.Forms.ListView();
            this.columnHeaderNodeName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNodeLabels = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNodeType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNodeCpuUsed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNodeCpuAvai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNodeAddrType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNodeAddr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNodeOS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNodeOSImg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNodeArch = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NamespacesTab = new System.Windows.Forms.TabPage();
            this.buttonNamespaceDelete = new System.Windows.Forms.Button();
            this.buttonNamespaceCreate = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxNamespaceLabels = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxNamespaceName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeaderNamespaceName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNamespaceLabels = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNamespaceCreationTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNamespaceFinalizers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNamespacePhase = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PodsTab = new System.Windows.Forms.TabPage();
            this.DeploymentsTab = new System.Windows.Forms.TabPage();
            this.ServiceIngressTab = new System.Windows.Forms.TabPage();
            this.comboBoxNamespacePod = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeaderPodName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPodNamespace = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPodCreationTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPodNamespaceImg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPodPorts = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPodNodename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPodPhase = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxDeploymentOpcao = new System.Windows.Forms.ComboBox();
            this.labelDeployment = new System.Windows.Forms.Label();
            this.comboBoxDeploymentType = new System.Windows.Forms.ComboBox();
            this.listView3 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxPodLabel = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxPodName = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.loginTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ResourcesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.NodesTab.SuspendLayout();
            this.NamespacesTab.SuspendLayout();
            this.PodsTab.SuspendLayout();
            this.DeploymentsTab.SuspendLayout();
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
            this.tabControl1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(886, 463);
            this.tabControl1.TabIndex = 3;
            // 
            // loginTab
            // 
            this.loginTab.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginTab.BackgroundImage")));
            this.loginTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginTab.Controls.Add(this.label2);
            this.loginTab.Controls.Add(this.label1);
            this.loginTab.Controls.Add(this.buttonLogin);
            this.loginTab.Controls.Add(this.pictureBox1);
            this.loginTab.Controls.Add(this.textBoxLoginToken);
            this.loginTab.Controls.Add(this.textBoxLoginIp);
            this.loginTab.Location = new System.Drawing.Point(4, 27);
            this.loginTab.Name = "loginTab";
            this.loginTab.Padding = new System.Windows.Forms.Padding(3);
            this.loginTab.Size = new System.Drawing.Size(878, 432);
            this.loginTab.TabIndex = 0;
            this.loginTab.Text = "Login";
            this.loginTab.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(408, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Token:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(425, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "IP:";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(372, 335);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(137, 26);
            this.buttonLogin.TabIndex = 3;
            this.buttonLogin.Text = "Connect";
            this.buttonLogin.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Kubernetes.Properties.Resources.kuber1;
            this.pictureBox1.Location = new System.Drawing.Point(359, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxLoginToken
            // 
            this.textBoxLoginToken.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLoginToken.Location = new System.Drawing.Point(352, 297);
            this.textBoxLoginToken.Name = "textBoxLoginToken";
            this.textBoxLoginToken.Size = new System.Drawing.Size(175, 26);
            this.textBoxLoginToken.TabIndex = 2;
            // 
            // textBoxLoginIp
            // 
            this.textBoxLoginIp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLoginIp.Location = new System.Drawing.Point(352, 239);
            this.textBoxLoginIp.Name = "textBoxLoginIp";
            this.textBoxLoginIp.Size = new System.Drawing.Size(175, 26);
            this.textBoxLoginIp.TabIndex = 1;
            // 
            // ResourcesTab
            // 
            this.ResourcesTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ResourcesTab.Controls.Add(this.label4);
            this.ResourcesTab.Controls.Add(this.label3);
            this.ResourcesTab.Controls.Add(this.chart2);
            this.ResourcesTab.Controls.Add(this.chart1);
            this.ResourcesTab.Location = new System.Drawing.Point(4, 27);
            this.ResourcesTab.Name = "ResourcesTab";
            this.ResourcesTab.Padding = new System.Windows.Forms.Padding(3);
            this.ResourcesTab.Size = new System.Drawing.Size(878, 432);
            this.ResourcesTab.TabIndex = 1;
            this.ResourcesTab.Text = "Resources";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(595, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Chart 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(109, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Chart 1";
            // 
            // chart2
            // 
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(461, 40);
            this.chart2.Name = "chart2";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(345, 300);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(18, 40);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(372, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // NodesTab
            // 
            this.NodesTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NodesTab.Controls.Add(this.label5);
            this.NodesTab.Controls.Add(this.listViewNodes);
            this.NodesTab.Location = new System.Drawing.Point(4, 27);
            this.NodesTab.Name = "NodesTab";
            this.NodesTab.Padding = new System.Windows.Forms.Padding(3);
            this.NodesTab.Size = new System.Drawing.Size(878, 432);
            this.NodesTab.TabIndex = 2;
            this.NodesTab.Text = "Nodes";
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
            // listViewNodes
            // 
            this.listViewNodes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNodeName,
            this.columnHeaderNodeLabels,
            this.columnHeaderNodeType,
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
            this.listViewNodes.Location = new System.Drawing.Point(8, 62);
            this.listViewNodes.Name = "listViewNodes";
            this.listViewNodes.Size = new System.Drawing.Size(860, 360);
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
            // columnHeaderNodeType
            // 
            this.columnHeaderNodeType.Text = "Type";
            this.columnHeaderNodeType.Width = 57;
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
            // NamespacesTab
            // 
            this.NamespacesTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NamespacesTab.Controls.Add(this.buttonNamespaceDelete);
            this.NamespacesTab.Controls.Add(this.buttonNamespaceCreate);
            this.NamespacesTab.Controls.Add(this.label8);
            this.NamespacesTab.Controls.Add(this.textBoxNamespaceLabels);
            this.NamespacesTab.Controls.Add(this.label7);
            this.NamespacesTab.Controls.Add(this.textBoxNamespaceName);
            this.NamespacesTab.Controls.Add(this.label6);
            this.NamespacesTab.Controls.Add(this.listView1);
            this.NamespacesTab.Location = new System.Drawing.Point(4, 27);
            this.NamespacesTab.Name = "NamespacesTab";
            this.NamespacesTab.Padding = new System.Windows.Forms.Padding(3);
            this.NamespacesTab.Size = new System.Drawing.Size(878, 432);
            this.NamespacesTab.TabIndex = 3;
            this.NamespacesTab.Text = "Namespaces";
            // 
            // buttonNamespaceDelete
            // 
            this.buttonNamespaceDelete.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNamespaceDelete.Location = new System.Drawing.Point(691, 385);
            this.buttonNamespaceDelete.Name = "buttonNamespaceDelete";
            this.buttonNamespaceDelete.Size = new System.Drawing.Size(75, 25);
            this.buttonNamespaceDelete.TabIndex = 14;
            this.buttonNamespaceDelete.Text = "Delete";
            this.buttonNamespaceDelete.UseVisualStyleBackColor = true;
            // 
            // buttonNamespaceCreate
            // 
            this.buttonNamespaceCreate.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNamespaceCreate.Location = new System.Drawing.Point(581, 385);
            this.buttonNamespaceCreate.Name = "buttonNamespaceCreate";
            this.buttonNamespaceCreate.Size = new System.Drawing.Size(75, 25);
            this.buttonNamespaceCreate.TabIndex = 13;
            this.buttonNamespaceCreate.Text = "Create";
            this.buttonNamespaceCreate.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(720, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 14);
            this.label8.TabIndex = 12;
            this.label8.Text = "Label:";
            // 
            // textBoxNamespaceLabels
            // 
            this.textBoxNamespaceLabels.Location = new System.Drawing.Point(723, 159);
            this.textBoxNamespaceLabels.Name = "textBoxNamespaceLabels";
            this.textBoxNamespaceLabels.Size = new System.Drawing.Size(115, 26);
            this.textBoxNamespaceLabels.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(578, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 14);
            this.label7.TabIndex = 10;
            this.label7.Text = "Name:";
            // 
            // textBoxNamespaceName
            // 
            this.textBoxNamespaceName.Location = new System.Drawing.Point(581, 159);
            this.textBoxNamespaceName.Name = "textBoxNamespaceName";
            this.textBoxNamespaceName.Size = new System.Drawing.Size(115, 26);
            this.textBoxNamespaceName.TabIndex = 9;
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
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNamespaceName,
            this.columnHeaderNamespaceLabels,
            this.columnHeaderNamespaceCreationTime,
            this.columnHeaderNamespaceFinalizers,
            this.columnHeaderNamespacePhase});
            this.listView1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            listViewGroup2.Header = "ListViewGroup";
            listViewGroup2.Name = "listViewGroup1";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup2});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(11, 62);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(537, 360);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
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
            this.columnHeaderNamespacePhase.Text = "Available CPU";
            this.columnHeaderNamespacePhase.Width = 111;
            // 
            // PodsTab
            // 
            this.PodsTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PodsTab.Controls.Add(this.button1);
            this.PodsTab.Controls.Add(this.button2);
            this.PodsTab.Controls.Add(this.label13);
            this.PodsTab.Controls.Add(this.textBoxPodLabel);
            this.PodsTab.Controls.Add(this.label14);
            this.PodsTab.Controls.Add(this.textBoxPodName);
            this.PodsTab.Controls.Add(this.listView2);
            this.PodsTab.Controls.Add(this.label10);
            this.PodsTab.Controls.Add(this.label9);
            this.PodsTab.Controls.Add(this.comboBoxNamespacePod);
            this.PodsTab.Location = new System.Drawing.Point(4, 27);
            this.PodsTab.Name = "PodsTab";
            this.PodsTab.Padding = new System.Windows.Forms.Padding(3);
            this.PodsTab.Size = new System.Drawing.Size(878, 432);
            this.PodsTab.TabIndex = 4;
            this.PodsTab.Text = "Pods";
            // 
            // DeploymentsTab
            // 
            this.DeploymentsTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DeploymentsTab.Controls.Add(this.listView3);
            this.DeploymentsTab.Controls.Add(this.labelDeployment);
            this.DeploymentsTab.Controls.Add(this.comboBoxDeploymentType);
            this.DeploymentsTab.Controls.Add(this.label12);
            this.DeploymentsTab.Controls.Add(this.comboBoxDeploymentOpcao);
            this.DeploymentsTab.Controls.Add(this.label11);
            this.DeploymentsTab.Location = new System.Drawing.Point(4, 27);
            this.DeploymentsTab.Name = "DeploymentsTab";
            this.DeploymentsTab.Padding = new System.Windows.Forms.Padding(3);
            this.DeploymentsTab.Size = new System.Drawing.Size(878, 432);
            this.DeploymentsTab.TabIndex = 5;
            this.DeploymentsTab.Text = "Deployments";
            // 
            // ServiceIngressTab
            // 
            this.ServiceIngressTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ServiceIngressTab.Location = new System.Drawing.Point(4, 27);
            this.ServiceIngressTab.Name = "ServiceIngressTab";
            this.ServiceIngressTab.Padding = new System.Windows.Forms.Padding(3);
            this.ServiceIngressTab.Size = new System.Drawing.Size(878, 432);
            this.ServiceIngressTab.TabIndex = 6;
            this.ServiceIngressTab.Text = " Services/Ingress";
            // 
            // comboBoxNamespacePod
            // 
            this.comboBoxNamespacePod.FormattingEnabled = true;
            this.comboBoxNamespacePod.Location = new System.Drawing.Point(33, 72);
            this.comboBoxNamespacePod.Name = "comboBoxNamespacePod";
            this.comboBoxNamespacePod.Size = new System.Drawing.Size(121, 26);
            this.comboBoxNamespacePod.TabIndex = 0;
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(30, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 14);
            this.label10.TabIndex = 11;
            this.label10.Text = "Namespace:";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderPodName,
            this.columnHeaderPodNamespace,
            this.columnHeaderPodCreationTime,
            this.columnHeaderPodNamespaceImg,
            this.columnHeaderPodPorts,
            this.columnHeaderPodNodename,
            this.columnHeaderPodPhase});
            this.listView2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            listViewGroup3.Header = "ListViewGroup";
            listViewGroup3.Name = "listViewGroup1";
            this.listView2.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup3});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(33, 121);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(630, 286);
            this.listView2.TabIndex = 12;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
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
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(31, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 14);
            this.label12.TabIndex = 13;
            this.label12.Text = "Opção de Procura:";
            // 
            // comboBoxDeploymentOpcao
            // 
            this.comboBoxDeploymentOpcao.FormattingEnabled = true;
            this.comboBoxDeploymentOpcao.Items.AddRange(new object[] {
            "Everything",
            "Namespace",
            "Deployment Name"});
            this.comboBoxDeploymentOpcao.Location = new System.Drawing.Point(34, 75);
            this.comboBoxDeploymentOpcao.Name = "comboBoxDeploymentOpcao";
            this.comboBoxDeploymentOpcao.Size = new System.Drawing.Size(161, 26);
            this.comboBoxDeploymentOpcao.TabIndex = 12;
            // 
            // labelDeployment
            // 
            this.labelDeployment.AutoSize = true;
            this.labelDeployment.BackColor = System.Drawing.Color.Transparent;
            this.labelDeployment.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeployment.ForeColor = System.Drawing.Color.Black;
            this.labelDeployment.Location = new System.Drawing.Point(250, 58);
            this.labelDeployment.Name = "labelDeployment";
            this.labelDeployment.Size = new System.Drawing.Size(87, 14);
            this.labelDeployment.TabIndex = 15;
            this.labelDeployment.Text = "Deployment:";
            // 
            // comboBoxDeploymentType
            // 
            this.comboBoxDeploymentType.FormattingEnabled = true;
            this.comboBoxDeploymentType.Items.AddRange(new object[] {
            "Everything",
            "Namespace",
            "Deployment Name"});
            this.comboBoxDeploymentType.Location = new System.Drawing.Point(253, 75);
            this.comboBoxDeploymentType.Name = "comboBoxDeploymentType";
            this.comboBoxDeploymentType.Size = new System.Drawing.Size(161, 26);
            this.comboBoxDeploymentType.TabIndex = 14;
            // 
            // listView3
            // 
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            listViewGroup4.Header = "ListViewGroup";
            listViewGroup4.Name = "listViewGroup1";
            this.listView3.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup4});
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(34, 123);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(630, 286);
            this.listView3.TabIndex = 16;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 68;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Namespace";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Created";
            this.columnHeader3.Width = 95;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Namespace Image";
            this.columnHeader4.Width = 146;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ports";
            this.columnHeader5.Width = 64;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Node name";
            this.columnHeader6.Width = 88;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Phase";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(753, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 20;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(672, 266);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 25);
            this.button2.TabIndex = 19;
            this.button2.Text = "Create";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(669, 185);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 14);
            this.label13.TabIndex = 18;
            this.label13.Text = "Label:";
            // 
            // textBoxPodLabel
            // 
            this.textBoxPodLabel.Location = new System.Drawing.Point(672, 202);
            this.textBoxPodLabel.Name = "textBoxPodLabel";
            this.textBoxPodLabel.Size = new System.Drawing.Size(115, 26);
            this.textBoxPodLabel.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(669, 121);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 14);
            this.label14.TabIndex = 16;
            this.label14.Text = "Name:";
            // 
            // textBoxPodName
            // 
            this.textBoxPodName.Location = new System.Drawing.Point(672, 141);
            this.textBoxPodName.Name = "textBoxPodName";
            this.textBoxPodName.Size = new System.Drawing.Size(115, 26);
            this.textBoxPodName.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Kubernetes Management Interface";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.loginTab.ResumeLayout(false);
            this.loginTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResourcesTab.ResumeLayout(false);
            this.ResourcesTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.NodesTab.ResumeLayout(false);
            this.NodesTab.PerformLayout();
            this.NamespacesTab.ResumeLayout(false);
            this.NamespacesTab.PerformLayout();
            this.PodsTab.ResumeLayout(false);
            this.PodsTab.PerformLayout();
            this.DeploymentsTab.ResumeLayout(false);
            this.DeploymentsTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxLoginIp;
        private System.Windows.Forms.TextBox textBoxLoginToken;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage loginTab;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TabPage ResourcesTab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage NodesTab;
        private System.Windows.Forms.TabPage NamespacesTab;
        private System.Windows.Forms.TabPage PodsTab;
        private System.Windows.Forms.TabPage DeploymentsTab;
        private System.Windows.Forms.ListView listViewNodes;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.ColumnHeader columnHeaderNodeName;
        private System.Windows.Forms.ColumnHeader columnHeaderNodeLabels;
        private System.Windows.Forms.ColumnHeader columnHeaderNodeType;
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
        private System.Windows.Forms.ListView listView1;
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
        private System.Windows.Forms.ListView listView2;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxPodLabel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxPodName;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}

