using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace Kubernetes.Model.Node
{
    internal class Node
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion { get; set; } = "v1";

        [JsonProperty("kind")]
        public string Kind { get; set; } = "Node";

        [JsonProperty("metadata")]
        public Metadata Metadata { get; set; }

        [JsonProperty("status")]
        public Status Status { get; set; }

        public JObject ToJObject()
        {
            return JObject.FromObject(this);
        }

    }

    internal class Metadata
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("labels")]
        public Labels Labels { get; set; }

        [JsonProperty("annotations")]
        public Annotations Annotations { get; set; }

        [JsonProperty("managedFields")]
        public List<ManagedField> ManagedFields { get; set; }
    }

    internal class Labels
    {
        [JsonProperty("environment")]
        public string Environment { get; set; }

        [JsonProperty("team")]
        public string Team { get; set; }

        [JsonProperty("app")]
        public string App { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }

    internal class Annotations
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }
    }

    internal class ManagedField
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    internal class Status
    {
        [JsonProperty("capacity")]
        public Capacity Capacity { get; set; }

        [JsonProperty("allocatable")]
        public Capacity Allocatable { get; set; }

        [JsonProperty("addresses")]
        public List<Address> Addresses { get; set; }

        [JsonProperty("nodeInfo")]
        public NodeInfo NodeInfo { get; set; }
    }

    internal class Capacity
    {
        [JsonProperty("cpus")]
        public string Cpus { get; set; }
    }

    internal class Address
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("address")]
        public string IpAddress { get; set; }
    }

    internal class NodeInfo
    {
        [JsonProperty("OSImage")]
        public string OSImage { get; set; }

        [JsonProperty("OS")]
        public string OS { get; set; }

        [JsonProperty("architecture")]
        public string Architecture { get; set; }
    }
}
