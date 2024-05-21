using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Kubernetes.Model.Namespaces
{
    internal class NamespaceList
    {
        [JsonProperty("apiVersion")]
        public string ApiVersion { get; set; } = "v1";

        [JsonProperty("kind")]
        public string Kind { get; set; } = "NamespaceList";

        [JsonProperty("metadata")]
        public ListMetadata Metadata { get; set; }

        [JsonProperty("items")]
        public List<NamespaceItem> Items { get; set; }
    }

    internal class ListMetadata
    {
        [JsonProperty("resourceVersion")]
        public string ResourceVersion { get; set; }
    }

    internal class NamespaceItem
    {
        [JsonProperty("metadata")]
        public Metadata Metadata { get; set; }

        [JsonProperty("spec")]
        public Spec Spec { get; set; }

        [JsonProperty("status")]
        public Status Status { get; set; }
    }

    internal class Metadata
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("resourceVersion")]
        public string ResourceVersion { get; set; }

        [JsonProperty("creationTimestamp")]
        public DateTime CreationTimestamp { get; set; }

        [JsonProperty("labels")]
        public Dictionary<string, string> Labels { get; set; }

        [JsonProperty("annotations")]
        public Dictionary<string, string> Annotations { get; set; }

        [JsonProperty("managedFields")]
        public List<ManagedField> ManagedFields { get; set; }
    }

    internal class ManagedField
    {
        [JsonProperty("manager")]
        public string Manager { get; set; }

        [JsonProperty("operation")]
        public string Operation { get; set; }

        [JsonProperty("apiVersion")]
        public string ApiVersion { get; set; }

        [JsonProperty("time")]
        public DateTime Time { get; set; }

        [JsonProperty("fieldsType")]
        public string FieldsType { get; set; }

        [JsonProperty("fieldsV1")]
        public FieldsV1 FieldsV1 { get; set; }
    }

    internal class FieldsV1
    {
        [JsonProperty("f:metadata")]
        public MetadataFields MetadataFields { get; set; }
    }

    internal class MetadataFields
    {
        [JsonProperty("f:labels")]
        public Dictionary<string, object> Labels { get; set; }
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
