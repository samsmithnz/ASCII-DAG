using ASCII_DAG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_DAG.Tests
{
    public static class Helper
    {
        //A
        public static Graph Example1()
        {
            Node nodeA = new()
            {
                Name = "A"
            };
            Graph graph = new(
                new() { nodeA }, 
                null);
            return graph;
        }

        //A--B
        public static Graph Example2()
        {
            Node nodeA = new()
            {
                Name = "A"
            };
            Node nodeB = new()
            {
                Name = "B"
            };
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
