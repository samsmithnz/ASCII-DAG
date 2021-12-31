
namespace ASCII_DAG.Models
{
    public class Edge
    {
        public Edge(string source, string destintation)
        {
            Weight = 1;
            Source = source;
            Destination = destintation;
        }
        public string Source { get; set; }
        public string Destination { get; set; }
        public int Weight { get; set; }
    }
}
