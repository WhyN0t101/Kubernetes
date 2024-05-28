using Newtonsoft.Json;
using System.Collections.Generic;

namespace Kubernetes.Model.PodMetrics
{
    public class PodMetrics
    {
        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("apiVersion")]
        public string ApiVersion { get; set; }

        [JsonProperty("metadata")]
        public Metadata Metadata { get; set; }

        [JsonProperty("containers")]
        public List<Container> Containers { get; set; }
    }

    public class Metadata
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("namespace")]
        public string Namespace { get; set; }

        [JsonProperty("selfLink")]
        public string SelfLink { get; set; }
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
