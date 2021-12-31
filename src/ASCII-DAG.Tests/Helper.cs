using ASCII_DAG.Models;

namespace ASCII_DAG.Tests
{
    public static class Helper
    {
        //A
        public static Graph Example1()
        {
            Graph graph = new(
                new()
                {
                    new("A", 1)
                },
                null);
            return graph;
        }

        //A--B
        public static Graph Example2()
        {
            Graph graph = new(
                new()
                {
                    new("A", 1),
                    new("B", 2)
                },
                new()
                {
                    new("A", "B")
                });
            return graph;
        }

        //   B--C
        //  /    \
        // /      \
        //A        F--G
        // \      /
        //  \    /
        //   D--E
        public static Graph Example3()
        {
            Graph graph = new(
                new()
                {
                    new("A", 1),
                    new("B", 2),
                    new("C", 3),
                    new("D", 2),
                    new("E", 3)
                },
                new()
                {
                    new("A", "B"),
                    new("B", "C"),
                    new("C", "F"),
                    new("A", "D"),
                    new("D", "E"),
                    new("E", "F"),
                    new("F", "G")
                });
            return graph;
        }

        //A--B--C--D
        // \      /
        //  \    /
        //   Z---
    }
}
