using Kubernetes.Model.Namespaces;
using Newtonsoft.Json;
using Kubernetes.Model.Node;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Kubernetes.Controller
{
    internal class KubernetesService
    {
        private readonly HttpClient httpClient;
        private readonly string baseUrl;
        private NodeList node;

        public KubernetesService(string ipAddress, string token, int control)
        {
            if (string.IsNullOrEmpty(ipAddress))
            {
                throw new ArgumentException("IP address cannot be null or empty.");
            }

            this.baseUrl = ipAddress;

            // Instantiate the HttpClient and set the Authorization header
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(this.baseUrl); // Set the base address
            if (control == 1)
            {
                httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            }
        }

        public async Task TestConnection()
        {
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync(baseUrl);
                response.EnsureSuccessStatusCode(); // Ensure success status code
            }
            catch (HttpRequestException ex)
            {
                throw new Exception("Error testing connection: " + ex.Message);
            }
        }
        public async Task<NamespaceList> RetrieveNamespaces()
        {
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync(baseUrl + "/api/v1/namespaces");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                NamespaceList namespaceList = JsonConvert.DeserializeObject<NamespaceList>(responseBody);
                return namespaceList;
            }
            catch (Exception)
            {
                // If the request fails, throw an exception
                MessageBox.Show("Failed to fetch namespaces");
                return null;
            }
        }

        public async Task<NodeList> RetrieveNodes()
        {
            try
            {
                // Make an HTTP GET request to the specified endpoint
                HttpResponseMessage response = await httpClient.GetAsync(baseUrl + "/api/v1/nodes");
                response.EnsureSuccessStatusCode(); // Throw an exception if the response is not successful

                // Read the response content as a string
                string responseBody = await response.Content.ReadAsStringAsync();

                // Deserialize the JSON response into a WifiSecurityProfile object
                NodeList nodeList = JsonConvert.DeserializeObject<NodeList>(responseBody);

                return nodeList;
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show("Error Fetching Nodes: " + ex.Message);
                return null;
            }
        }
    }
}
