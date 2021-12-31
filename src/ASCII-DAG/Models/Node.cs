
namespace ASCII_DAG.Models
{
    public class Node
    {
        public Node(string name)
        {
            Name = name;
            //NodePrereqs = new();

        }

        public string Name { get; set; }
        //public List<Node> NodePrereqs { get; set; }
        //public int NodeSuccessors { get; set; }
        public int Position { get; set; }
    }
}
