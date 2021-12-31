using ASCII_DAG.Models;

namespace ASCII_DAG.Tests
{
    public static class Helper
    {
        //A
        public static Graph Example1()
        {
            Node nodeA = new("A");
            Graph graph = new(
                new() { nodeA },
                null);
            return graph;
        }

        //A--B
        public static Graph Example2()
        {
            Node nodeA = new("A");
            Node nodeB = new("B");
            Edge edge1 = new("A", "B");
            Graph graph = new(
                new() { nodeA, nodeB },
                new() { edge1 });
            return graph;
        }

        //   B--C
        //  /
        // /
        //A
        // \
        //  \  
        //   D--E
    }
}
