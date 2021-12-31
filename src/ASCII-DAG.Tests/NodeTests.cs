using ASCII_DAG.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ASCII_DAG.Tests;

[TestClass]
public class NodeTests
{
    [TestMethod]
    public void NodeEmptyTest()
    {
        //Arrange
        Graph graph = new(new(),new());

        //Act
        string result = graph.Serialize();

        //Assert
        Assert.IsNotNull(graph);
        Assert.AreEqual(0, graph.Nodes.Count);
        Assert.AreEqual(0, graph.Edges.Count);
        string expected = @"

";
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void NodesATest()
    {
        //Arrange
        Graph graph = Helper.Example1();

        //Act
        string result = graph.Serialize();

        //Assert
        Assert.IsNotNull(graph);
        Assert.AreEqual(1, graph.Nodes.Count);
        Assert.AreEqual(0, graph.Edges.Count);
        Assert.AreEqual("A", graph.Nodes[0].Name);
        string expected = @"
A
";
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void NodesAToBTest()
    {
        //Arrange
        Graph graph = Helper.Example2();

        //Act
        string result = graph.Serialize();

        //Assert
        Assert.IsNotNull(graph);
        Assert.AreEqual(2, graph.Nodes.Count);
        Assert.AreEqual(1, graph.Edges.Count);
        Assert.AreEqual("A", graph.Nodes[0].Name);
        Assert.AreEqual("B", graph.Nodes[1].Name);
        string expected = @"
A--B
";
        Assert.AreEqual(expected, result);
    }
}