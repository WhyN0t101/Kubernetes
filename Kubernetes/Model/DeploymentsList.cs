using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace Kubernetes.Model.Deployments
{
    internal class DeploymentsList
    {
        [JsonProperty("items")]
        public List<DeploymentItem> Items { get; set; }
    }

    internal class DeploymentItem
    {
        [JsonProperty("kind")]
        public string Kind { get; set; } = "Deployment"; // Set the kind to "Deployment"

        [JsonProperty("metadata")]
        public DeploymentMetadata Metadata { get; set; }

        [JsonProperty("spec")]
        public DeploymentSpec Spec { get; set; }

        [JsonProperty("status")]
        public DeploymentStatus Status { get; set; }

        public JObject ToJObject()
        {
            return JObject.FromObject(this);
        }
    }


    internal class DeploymentMetadata
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("namespace")]
        public string Namespace { get; set; }

        [JsonProperty("creationTimestamp")]
        public DateTime? CreationTimestamp { get; set; } // Nullable DateTime

        [JsonProperty("labels")]
        public Dictionary<string, string> Labels { get; set; }
    }

    internal class DeploymentSpec
    {
        [JsonProperty("replicas")]
        public int Replicas { get; set; }

        [JsonProperty("selector")]
        public DeploymentSelector Selector { get; set; }

        [JsonProperty("strategy")]
        public DeploymentStrategy Strategy { get; set; }

        [JsonProperty("revisionHistoryLimit")]
        public int RevisionHistoryLimit { get; set; }

        [JsonProperty("progressDeadlineSeconds")]
        public int ProgressDeadlineSeconds { get; set; }

        [JsonProperty("template")]
        public DeploymentTemplate Template { get; set; }
    }

    internal class DeploymentSelector
    {
        [JsonProperty("matchLabels")]
        public Dictionary<string, string> MatchLabels { get; set; }
    }

    internal class DeploymentStrategy
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("rollingUpdate")]
        public DeploymentRollingUpdate RollingUpdate { get; set; }
    }

    internal class DeploymentRollingUpdate
    {
        [JsonProperty("maxSurge")]
        public string MaxSurge { get; set; }

        [JsonProperty("maxUnavailable")]
        public string MaxUnavailable { get; set; }
    }

    internal class DeploymentTemplate
    {
        [JsonProperty("metadata")]
        public DeploymentMetadata Metadata { get; set; }

        [JsonProperty("spec")]
        public DeploymentPodSpec Spec { get; set; }
    }

    internal class DeploymentPodSpec
    {
        [JsonProperty("containers")]
        public List<DeploymentContainer> Containers { get; set; }
    }

    internal class DeploymentContainer
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("ports")]
        public List<DeploymentPort> Ports { get; set; }
    }

    internal class DeploymentPort
    {
        [JsonProperty("containerPort")]
        public int ContainerPort { get; set; }
    }

    internal class DeploymentStatus
    {
        [JsonProperty("conditions")]
        public List<DeploymentCondition> Conditions { get; set; }
    }

    internal class DeploymentCondition
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
