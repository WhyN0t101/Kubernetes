using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kubernetes.Model.Pod
{
    internal class Pod
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion { get; set; } = "v1";

        [JsonProperty("kind")]
        public string Kind { get; set; } = "Pod";

        [JsonProperty("metadata")]
        public Metadata Metadata { get; set; }

        [JsonProperty("spec")]
        public Spec Spec { get; set; }

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

        [JsonProperty("namespace")]
        public string Namespace { get; set; }

        [JsonProperty("labels")]
        public Dictionary<string, string> Labels { get; set; }

        [JsonProperty("OwnerRefs")]
        public List<OwnerRef> OwnerRefs { get; set; }
    }

    internal class OwnerRef
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("namespace")]
        public string Namespace { get; set; }

        [JsonProperty("creationTimeStamp")]
        public DateTime CreationTimeStamp { get; set; }
    }

    internal class Spec
    {
        [JsonProperty("containers")]
        public List<Container> Containers { get; set; }

        [JsonProperty("nodeName")]
        public string NodeName { get; set; }
    }

    internal class Container
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("ports")]
        public List<Port> Ports { get; set; }
    }

    internal class Port
    {
        [JsonProperty("containerPort")]
        public int ContainerPort { get; set; }
    }

    internal class Status
    {
        [JsonProperty("phase")]
        public string Phase { get; set; }
    }
}
