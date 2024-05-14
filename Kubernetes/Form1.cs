﻿using Kubernetes.Controller;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kubernetes
{
    public partial class Form1 : Form
    {
        private readonly HttpClient httpClient;
        private string baseUrl;
        private bool isConnected = false;
        private MethodsController Controller;


        public Form1()
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            httpClient = new HttpClient();
            InitializeComponent();
            pictureBox1.BackColor = Color.Transparent;

        }

        private async void tabControl1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Check if connected to router before allowing access to other tabs
            if (!isConnected && tabControl1.SelectedIndex != 0)
            {
                MessageBox.Show("Please connect to the microk8s first.");
                tabControl1.SelectedIndex = 0; // Switch back to the connection tab
            }

        }

        private async Task Connect(string ipAddress, string token)
        {
            baseUrl = ipAddress;
            //string credentials = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{token}"));
            //httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", credentials);
            await Controller.TestConnection(); // Test connection asynchronously
            isConnected = true;
            textBoxLoginIp.Enabled = false; // IP Address textbox
            textBoxLoginToken.Enabled = false; // Token textbox
            MessageBox.Show("Connected to Management Interface successfully!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loginTab_Click(object sender, EventArgs e)
        {

        }

        private async void buttonLogin_Click(object sender, EventArgs e)
        {

            string ipAddress = textBoxLoginIp.Text.Trim();
            string token = textBoxLoginToken.Text.Trim();

            // Determine the protocol (HTTP or HTTPS) based on user selection
            //string protocol = (HTTPs.Checked) ? "https://" : "http://";


            try
            {
                // Construct the base URL using the determined protocol and IP address
                //string baseUrl = protocol + ipAddress;
                string baseUrl = "http://" + ipAddress + ":8001";

                // Instantiate MethodsController class with user credentials and base URL
                Controller = new MethodsController(baseUrl, token);

                // Attempt to connect to the router
                await Connect(baseUrl, token);

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
    }
}
