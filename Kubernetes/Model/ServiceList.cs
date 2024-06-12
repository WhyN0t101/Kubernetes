using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kubernetes.Model.Service
{
    public class ServiceList
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion { get; set; } = "v1";

        [JsonProperty("kind")]
        public string Kind { get; set; } = "Service";

        [JsonProperty("metadata")]
        public Metadata Metadata { get; set; }

        [JsonProperty("items")]
        public List<ServiceItem> Items { get; set; }

 
    }

    public class ServiceItem
    {
        [JsonProperty("metadata")]
        public Metadata Metadata { get; set; }

        [JsonProperty("spec")]
        public Spec Spec { get; set; }

        [JsonProperty("status")]
        public ServiceStatus Status { get; set; }

        [JsonProperty("created")]
        public DateTime Created { get; set; }

        [JsonProperty("internalEndpoints")]
        public List<string> InternalEndpoints { get; set; }

        [JsonProperty("externalEndpoints")]
        public List<string> ExternalEndpoints { get; set; }

        public JObject ToJObject()
        {
            return JObject.FromObject(this);
        }
    }

    public class Metadata
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("labels")]
        public Dictionary<string, string> Labels { get; set; }

        [JsonProperty("creationTimeStamp")]
        public DateTime CreationTimeStamp { get; set; }
    }

    public class Spec
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("clusterIP")]
        public string ClusterIP { get; set; }

        [JsonProperty("ports")]
        public List<Port> Ports { get; set; }
    }

    public class Port
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("protocol")]
        public string Protocol { get; set; }

        [JsonProperty("port")]
        public int PortNumber { get; set; }

        [JsonProperty("targetPort")]
        public int TargetPortNumber { get; set; }
    }

    public class ServiceStatus
    {
        [JsonProperty("loadBalancer")]
        public LoadBalancer LoadBalancer { get; set; }
    }

    public class LoadBalancer
    {
        // Add load balancer properties if needed
    }

}