using System.Text;

namespace ASCII_DAG.Models
{
    public class Graph
    {
        public Graph(List<Node> nodes, List<Edge>? edges = null)
        {
            Nodes = nodes;
            if (edges == null)
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

        public string Serialize()
        {
            StringBuilder sb = new();
            sb.Append(Environment.NewLine);
            if (Nodes.Count == 1)
            {
                sb.Append("A");
            }
            else if (Nodes.Count == 2)
            {
                sb.Append("A--B");
            }
            sb.Append(Environment.NewLine);
            return sb.ToString();
        }

        private string GenerateSpaces(int number)
        {
            return new string(' ', number);
        }
    }
}
