
namespace ASCII_DAG.Models
{
    public class Edge
    {
        public Edge(string source, string destintation)
        {
            Source = source;
            Destination = destintation;
            Weight = 1;
        }
        public string Source { get; set; }
        public string Destination { get; set; }
        public int Weight { get; set; }
    }
}
