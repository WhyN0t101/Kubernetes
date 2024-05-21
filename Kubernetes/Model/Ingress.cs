using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kubernetes.Model.Ingress
{
    internal class Ingress
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion { get; set; } = "v1";

        [JsonProperty("kind")]
        public string Kind { get; set; } = "Ingress";

        [JsonProperty("metadata")]
        public Metadata Metadata { get; set; }

        [JsonProperty("spec")]
        public Spec Spec { get; set; }

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

        [JsonProperty("annotations")]
        public Dictionary<string, string> Annotations { get; set; }
    }

    internal class Spec
    {
        [JsonProperty("rules")]
        public List<Rule> Rules { get; set; }

        [JsonProperty("tls")]
        public List<Tls> Tls { get; set; }
    }

    internal class Rule
    {
        [JsonProperty("host")]
        public string Host { get; set; }

        [JsonProperty("http")]
        public Http Http { get; set; }
    }

    internal class Http
    {
        [JsonProperty("paths")]
        public List<Path> Paths { get; set; }
    }

    internal class Path
    {
        [JsonProperty("path")]
        public string PathPar { get; set; }

        [JsonProperty("pathType")]
        public string PathType { get; set; }

        [JsonProperty("backend")]
        public Backend Backend { get; set; }
    }

    internal class Backend
    {
        [JsonProperty("service")]
        public Service Service { get; set; }
    }

    internal class Service
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("port")]
        public Port Port { get; set; }
    }

    internal class Port
    {
        [JsonProperty("number")]
        public int Number { get; set; }
    }

    internal class Tls
    {
        [JsonProperty("hosts")]
        public List<string> Hosts { get; set; }

        [JsonProperty("secretName")]
        public string SecretName { get; set; }
    }
}
