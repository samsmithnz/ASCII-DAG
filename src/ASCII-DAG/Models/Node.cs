namespace ASCII_DAG.Models
{
    public class Node
    {
        public Node()
        {
            NodePrereqs = new();
        }

        public string? Name { get; set; }
        public List<Node> NodePrereqs { get; set; }
    }
}
