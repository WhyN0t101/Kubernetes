﻿using Kubernetes.Model.Namespaces;
using Kubernetes.Model.PodList;
using Newtonsoft.Json;
using Kubernetes.Model.Node;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Kubernetes.Model.Ingress;
using Kubernetes.Model.Service;
using Kubernetes.Model.PodMetrics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Newtonsoft.Json.Linq;
using System.Reflection.Emit;

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
        public async Task<PodList> RetrievePods(string namespaceName)
        {
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync($"{baseUrl}/api/v1/namespaces/{namespaceName}/pods");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<PodList>(responseBody);
            }
            catch (Exception)
            {
                // If the request fails, throw an exception
                MessageBox.Show("Failed to fetch Pods");
                return null;
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


        public async Task<IEnumerable<string>> GetNamespaceNames()
        {
            try
            {
                // Make an HTTP GET request to fetch namespaces from the Kubernetes API
                HttpResponseMessage response = await httpClient.GetAsync(baseUrl + "/api/v1/namespaces");

                // Check if the request was successful
                if (response.IsSuccessStatusCode)
                {
                    // Read the response content
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // Deserialize the JSON response
                    var namespaceList = JsonConvert.DeserializeObject<NamespaceList>(responseBody);

                    // Extract namespace names
                    List<string> namespaceNames = new List<string>();
                    foreach (var ns in namespaceList.Items)
                    {
                        namespaceNames.Add(ns.Metadata.Name);
                    }

                    return namespaceNames;
                }
                else
                {
                    // If the request fails, throw an exception
                    throw new Exception("Failed to fetch namespaces: " + response.ReasonPhrase);
                }
            }
            catch (Exception ex)
            {
                // Handle the exception or throw it
                throw new Exception("Error fetching namespaces: " + ex.Message);
            }
        }

        public async Task<ServiceList> RetrieveServices()
        {
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync($"{baseUrl}/api/v1/services");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<ServiceList>(responseBody);
            }
            catch (Exception)
            {
                // If the request fails, throw an exception
                MessageBox.Show("Failed to fetch Services");
                return null;
            }
        }

        public async Task CreateNamespace(NamespaceItem namespaceItem)
        {
            try
            {
                JObject payload = namespaceItem.ToJObject();

                payload.Remove("spec");
                payload.Remove("status");
                ((JObject)payload["metadata"]).Remove("resourceVersion");
                ((JObject)payload["metadata"]).Remove("creationTimestamp");
                ((JObject)payload["metadata"]).Remove("managedFields");
                ((JObject)payload["metadata"]).Remove("uid");

                if(namespaceItem.Metadata.Labels == null )
                {
                    ((JObject)payload["metadata"]).Remove("labels");
                }
                if(namespaceItem.Metadata.Annotations == null)
                {
                    ((JObject)payload["metadata"]).Remove("annotations");

                }

                string apiUrl = baseUrl + "/api/v1/namespaces";
                HttpResponseMessage response = await SendPostRequest(apiUrl, payload);
                response.EnsureSuccessStatusCode();
                MessageBox.Show("Namespace created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                // If the request fails, throw an exception
                MessageBox.Show("Failed to Create Namespace");
            }

        }

        public async Task<HttpResponseMessage> SendPostRequest(string apiUrl, JObject payload)
        {
            string jsonPayload = payload.ToString();
            return await httpClient.PostAsync(apiUrl, new StringContent(jsonPayload, Encoding.UTF8, "application/json"));
        }
        public async Task<PodMetrics> RetrievePodMetrics(string namespaceName, string podName)
        {
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync($"{baseUrl}/apis/metrics.k8s.io/v1beta1/namespaces/{namespaceName}/pods/{podName}");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<PodMetrics>(responseBody);
            }
            catch (Exception)
            {
                // If the request fails, throw an exception or handle it accordingly
                MessageBox.Show("No metrics found for this pod");
                return null;
            }
        }

        public async Task CreatePod(PodItem podItem, string namespaceSelected)
        {
            try
            {
                JObject payload = podItem.ToJObject();

                payload.Remove("status");
                ((JObject)payload["metadata"]).Remove("OwnerReferences");
                ((JObject)payload["metadata"]).Remove("creationTimestamp");

                if (podItem.Metadata.Labels == null)
                {
                    ((JObject)payload["metadata"]).Remove("labels");
                }
                if (podItem.Spec.NodeName == null)
                {
                    ((JObject)payload["spec"]).Remove("nodeName");
                }


                string apiUrl = baseUrl + "api/v1/namespaces/" + namespaceSelected + "/pods";
                HttpResponseMessage response = await SendPostRequest(apiUrl, payload);
                response.EnsureSuccessStatusCode();
                MessageBox.Show("Pod created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                // If the request fails, throw an exception
                MessageBox.Show("Failed to Create Pod");
            }

        }

    }
}
