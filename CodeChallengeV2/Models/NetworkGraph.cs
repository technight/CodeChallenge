using Newtonsoft.Json;

namespace CodeChallengeV2.Models
{
    public class NetworkGraph
    {
        public Graph[] Graphs { get; set; }
    }

    public class Graph
    {
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "label")]
        public string Label { get; set; }

        [JsonProperty(PropertyName = "nodes")]
        public Node[] Nodes { get; set; }
        [JsonProperty(PropertyName = "edges")]
        public Edge[] Edges { get; set; }
    }

    public class Node
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "label")]
        public string Label { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
    }

    public class Edge
    {
        [JsonProperty(PropertyName = "source")]
        public string Source { get; set; }
        [JsonProperty(PropertyName = "target")]
        public string Target { get; set; }
        [JsonProperty(PropertyName = "relation")]
        public string Relation { get; set; }
    }

}
