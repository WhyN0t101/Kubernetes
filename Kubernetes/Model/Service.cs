﻿using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kubernetes.Model.Service
{
    internal class Service
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion { get; set; } = "v1";

        [JsonProperty("kind")]
        public string Kind { get; set; } = "Service";

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

        [JsonProperty("creationTimeStamp")]
        public DateTime CreationTimeStamp { get; set; }

        [JsonProperty("labels")]
        public Dictionary<string, string> Labels { get; set; }
    }

    internal class Spec
    {
        [JsonProperty("selector")]
        public Dictionary<string, string> Selector { get; set; }

        [JsonProperty("ports")]
        public List<Port> Ports { get; set; }

        [JsonProperty("clusterIP")]
        public string ClusterIP { get; set; }

        [JsonProperty("clusterIPs")]
        public List<string> ClusterIPs { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    internal class Port
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("protocol")]
        public string Protocol { get; set; }

        [JsonProperty("port")]
        public int IpPort { get; set; }

        [JsonProperty("targetPort")]
        public int TargetPort { get; set; }
    }
}