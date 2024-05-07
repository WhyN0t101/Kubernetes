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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxLoginIp = new System.Windows.Forms.TextBox();
            this.textBoxLoginToken = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.loginTab = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.loginTab.SuspendLayout();
            this.SuspendLayout();
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
            // textBoxLoginIp
            // 
            this.textBoxLoginIp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLoginIp.Location = new System.Drawing.Point(352, 239);
            this.textBoxLoginIp.Name = "textBoxLoginIp";
            this.textBoxLoginIp.Size = new System.Drawing.Size(175, 26);
            this.textBoxLoginIp.TabIndex = 1;
            // 
            // textBoxLoginToken
            // 
            this.textBoxLoginToken.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLoginToken.Location = new System.Drawing.Point(352, 297);
            this.textBoxLoginToken.Name = "textBoxLoginToken";
            this.textBoxLoginToken.Size = new System.Drawing.Size(175, 26);
            this.textBoxLoginToken.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.loginTab);
            this.tabControl1.Controls.Add(this.tabPage2);
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
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(878, 432);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.loginTab.ResumeLayout(false);
            this.loginTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxLoginIp;
        private System.Windows.Forms.TextBox textBoxLoginToken;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage loginTab;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

