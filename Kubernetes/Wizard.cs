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
        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateButtonStates();
        }

    }
}
