namespace ASCII_DAG.Models
{
    public class Node
    {
        public Node()
        {
            ItemPrereqs = new();
        }

        public string? Name { get; set; }
        public List<Node> ItemPrereqs { get; set; }
    }
}
