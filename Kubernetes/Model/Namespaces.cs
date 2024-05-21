using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kubernetes.Model.Namespaces
{
    internal class Namespaces
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion { get; set; } = "v1";

        [JsonProperty("kind")]
        public string Kind { get; set; } = "NamespaceList";

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

        [JsonProperty("labels")]
        public Labels Labels { get; set; }

        [JsonProperty("creationTimestamp")]
        public DateTime creationTimestamp { get; set; }
    }

    internal class Labels
    {
        [JsonProperty("environment")]
        public string Environment { get; set; }

        [JsonProperty("team")]
        public string Team { get; set; }
    }

    internal class Spec
    {
        [JsonProperty("finalizers")]
        public List<string> Finalizers { get; set; }
    }

    internal class Status
    {
        [JsonProperty("phase")]
        public string Phase { get; set; }
    }
}
