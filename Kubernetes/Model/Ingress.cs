using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace Kubernetes.Model.Ingress
{
    public class IngressList
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion { get; set; } = "networking.k8s.io/v1";

        [JsonProperty("kind")]
        public string Kind { get; set; } = "IngressList";

        [JsonProperty("items")]
        public List<IngressItem> Items { get; set; }
    }

    public class IngressItem
    {
        [JsonProperty("metadata")]
        public Metadata Metadata { get; set; }

        [JsonProperty("spec")]
        public Spec Spec { get; set; }

        [JsonProperty("endpoints")]
        public List<string> Endpoints { get; set; }

        [JsonProperty("hosts")]
        public List<string> Hosts { get; set; }

        [JsonProperty("created")]
        public DateTime Created { get; set; }

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
        [JsonProperty("defaultBackend")]
        public DefaultBackend DefaultBackend { get; set; }
    }

    public class DefaultBackend
    {
        [JsonProperty("service")]
        public ServiceRef Service { get; set; }
    }

    public class ServiceRef
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("port")]
        public ServicePort Port { get; set; }
    }

    public class ServicePort
    {
        [JsonProperty("number")]
        public int Number { get; set; }
    }
}
