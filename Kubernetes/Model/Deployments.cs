using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kubernetes.Model.Deployments
{
    internal class Deployments
    {
        internal class Deployment
        {
            [JsonProperty("apiVersion")]
            public string ApiVersion { get; set; } = "v1";

            [JsonProperty("kind")]
            public string Kind { get; set; } = "Deployment";

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

            [JsonProperty("creationTimeStamp")]
            public DateTime CreationTimeStamp { get; set; }

            [JsonProperty("labels")]
            public Dictionary<string, string> Labels { get; set; }
        }

        internal class Spec
        {
            [JsonProperty("replicas")]
            public int Replicas { get; set; }

            [JsonProperty("selector")]
            public Selector Selector { get; set; }

            [JsonProperty("strategy")]
            public Strategy Strategy { get; set; }

            [JsonProperty("revisionHistoryLimit")]
            public int RevisionHistoryLimit { get; set; }

            [JsonProperty("progressDeadlineSeconds")]
            public int ProgressDeadlineSeconds { get; set; }

            [JsonProperty("template")]
            public Template Template { get; set; }
        }

        internal class Selector
        {
            [JsonProperty("matchLabels")]
            public Dictionary<string, string> MatchLabels { get; set; }
        }

        internal class Strategy
        {
            [JsonProperty("type")]
            public string Type { get; set; }

            [JsonProperty("rollingUpdate")]
            public RollingUpdate RollingUpdate { get; set; }
        }

        internal class RollingUpdate
        {
            [JsonProperty("maxSurge")]
            public string MaxSurge { get; set; }

            [JsonProperty("maxUnavailable")]
            public string MaxUnavailable { get; set; }
        }

        internal class Template
        {
            [JsonProperty("metadata")]
            public Metadata Metadata { get; set; }

            [JsonProperty("spec")]
            public PodSpec Spec { get; set; }
        }

        internal class PodSpec
        {
            [JsonProperty("containers")]
            public List<Container> Containers { get; set; }
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
            [JsonProperty("conditions")]
            public List<Condition> Conditions { get; set; }
        }

        internal class Condition
        {
            [JsonProperty("type")]
            public string Type { get; set; }
        }
    }
}
