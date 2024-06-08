using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace Kubernetes.Model.PodList
{
    internal class PodList
    {
        [JsonProperty("items")]
        public List<PodItem> Items { get; set; }
    }

    internal class PodItem
    {
        [JsonProperty("metadata")]
        public PodMetadata Metadata { get; set; }

        [JsonProperty("spec")]
        public PodSpec Spec { get; set; }

        [JsonProperty("status")]
        public PodStatus Status { get; set; }
        public JObject ToJObject()
        {
            return JObject.FromObject(this);
        }
    }

    internal class PodMetadata
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("namespace")]
        public string Namespace { get; set; }

        [JsonProperty("creationTimestamp")]
        public DateTime CreationTimestamp { get; set; }

        [JsonProperty("ownerReferences")]
        public List<PodOwnerRef> OwnerReferences { get; set; }

        [JsonProperty("labels")]
        public Dictionary<string, string> Labels { get; set; }
    }

    internal class PodOwnerRef
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("namespace")]
        public string Namespace { get; set; }

        [JsonProperty("creationTimestamp")]
        public DateTime CreationTimestamp { get; set; }
    }

    internal class PodSpec
    {
        [JsonProperty("containers")]
        public List<PodContainer> Containers { get; set; }

        [JsonProperty("nodeName")]
        public string NodeName { get; set; }
    }

    internal class PodContainer
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("ports")]
        public List<PodPort> Ports { get; set; }
    }

    internal class PodPort
    {
        [JsonProperty("containerPort")]
        public int ContainerPort { get; set; }
    }

    internal class PodStatus
    {
        [JsonProperty("phase")]
        public string Phase { get; set; }
    }

}
