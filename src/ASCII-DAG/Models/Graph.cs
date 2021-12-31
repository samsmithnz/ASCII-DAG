namespace ASCII_DAG.Models
{
    public class Graph
    {
        public Graph(List<Node> nodes, List<Edge>? edges = null)
        {
            Nodes = nodes;
            if (edges == null )
            {
                Edges = new List<Edge>();
            }
            else
            {
                Edges = edges;
            }
        }
        public List<Node> Nodes { get; set; }
        public List<Edge> Edges { get; set; }
    }
}
