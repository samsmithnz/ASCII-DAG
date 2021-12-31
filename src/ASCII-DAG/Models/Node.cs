
namespace ASCII_DAG.Models
{
    public class Node
    {
        public Node(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public int Position { get; set; }
    }
}
