using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Kubernetes.Model.PodMetrics
{
    public class PodMetricsList
    {
        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("apiVersion")]
        public string ApiVersion { get; set; }

        [JsonProperty("metadata")]
        public object Metadata { get; set; }

        [JsonProperty("items")]
        public List<PodMetrics> Items { get; set; }
    }

    public class PodMetrics
    {
        [JsonProperty("metadata")]
        public Metadata Metadata { get; set; }

        [JsonProperty("timestamp")]
        public DateTime Timestamp { get; set; }

        [JsonProperty("window")]
        public string Window { get; set; }

        [JsonProperty("containers")]
        public List<Container> Containers { get; set; }
    }

    public class Metadata
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("namespace")]
        public string Namespace { get; set; }

        [JsonProperty("creationTimestamp")]
        public DateTime CreationTimestamp { get; set; }

        [JsonProperty("labels")]
        public Dictionary<string, string> Labels { get; set; }
    }

    public class Container
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("usage")]
        public Usage Usage { get; set; }
    }

    public class Usage
    {
        [JsonProperty("cpu")]
        public string Cpu { get; set; }

        [JsonProperty("memory")]
        public string Memory { get; set; }
    }
}
