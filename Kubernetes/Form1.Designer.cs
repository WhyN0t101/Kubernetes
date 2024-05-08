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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.loginTab = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxLoginToken = new System.Windows.Forms.TextBox();
            this.textBoxLoginIp = new System.Windows.Forms.TextBox();
            this.ResourcesTab = new System.Windows.Forms.TabPage();
            this.NodesTab = new System.Windows.Forms.TabPage();
            this.NamespacesTab = new System.Windows.Forms.TabPage();
            this.PodsTab = new System.Windows.Forms.TabPage();
            this.DeploymentsTab = new System.Windows.Forms.TabPage();
            this.listViewNodes = new System.Windows.Forms.ListView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.label5 = new System.Windows.Forms.Label();
            this.ServiceIngressTab = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.loginTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ResourcesTab.SuspendLayout();
            this.NodesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
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
            // NamespacesTab
            // 
            this.NamespacesTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NamespacesTab.Location = new System.Drawing.Point(4, 27);
            this.NamespacesTab.Name = "NamespacesTab";
            this.NamespacesTab.Padding = new System.Windows.Forms.Padding(3);
            this.NamespacesTab.Size = new System.Drawing.Size(878, 432);
            this.NamespacesTab.TabIndex = 3;
            this.NamespacesTab.Text = "Namespaces";
            // 
            // PodsTab
            // 
            this.PodsTab.BackColor = System.Drawing.Color.WhiteSmoke;
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
            this.DeploymentsTab.Location = new System.Drawing.Point(4, 27);
            this.DeploymentsTab.Name = "DeploymentsTab";
            this.DeploymentsTab.Padding = new System.Windows.Forms.Padding(3);
            this.DeploymentsTab.Size = new System.Drawing.Size(878, 432);
            this.DeploymentsTab.TabIndex = 5;
            this.DeploymentsTab.Text = "Deployments";
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
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(506, 40);
            this.chart2.Name = "chart2";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(300, 300);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
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
            this.NodesTab.ResumeLayout(false);
            this.NodesTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
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
    }
}

