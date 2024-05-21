using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Kubernetes.Model.Node
{
    public class NodeList
    {
        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("apiVersion")]
        public string ApiVersion { get; set; }

        [JsonProperty("metadata")]
        public Metadata Metadata { get; set; }

        [JsonProperty("items")]
        public List<NodeItem> Items { get; set; }
    }

    public class Metadata
    {
        [JsonProperty("resourceVersion")]
        public string ResourceVersion { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("labels")]
        public Dictionary<string, string> Labels { get; set; }

        [JsonProperty("annotations")]
        public Dictionary<string, string> Annotations { get; set; }

        [JsonProperty("creationTimestamp")]
        public DateTime creationTimestamp { get; set; }

    }


    public class NodeItem
    {
        [JsonProperty("metadata")]
        public Metadata Metadata { get; set; }

        [JsonProperty("status")]
        public Status Status { get; set; }
    }

    public class Status
    {
        [JsonProperty("capacity")]
        public Dictionary<string, string> Capacity { get; set; }

        [JsonProperty("allocatable")]
        public Dictionary<string, string> Allocatable { get; set; }

        [JsonProperty("addresses")]
        public List<Address> Addresses { get; set; }

        [JsonProperty("nodeInfo")]
        public NodeInfo NodeInfo { get; set; }

        [JsonProperty("images")]
        public List<Image> Images { get; set; }
    }

    public class Address
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("address")]
        public string IpAddress { get; set; }
    }

    public class NodeInfo
    {
        [JsonProperty("osImage")]
        public string OSImage { get; set; }

        [JsonProperty("operatingSystem")]
        public string OS { get; set; }

        [JsonProperty("architecture")]
        public string Architecture { get; set; }

    }

    public class Image
    {
        [JsonProperty("names")]
        public List<string> Names { get; set; }

        [JsonProperty("sizeBytes")]
        public long SizeBytes { get; set; }
    }
}