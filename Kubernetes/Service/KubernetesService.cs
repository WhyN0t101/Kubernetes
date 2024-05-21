using Kubernetes.Model.Namespaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kubernetes.Controller
{
    internal class KubernetesService
    {
        private readonly HttpClient httpClient;
        private readonly string baseUrl;

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


    }
}
