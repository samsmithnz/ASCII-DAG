
namespace ASCII_DAG.Models
{
    public class Node
    {
        public Node(string name, int column)
        {
            Name = name;
            Column = column;
        }

        public string Name { get; set; }
        public int Column { get; set; }
    }
}
