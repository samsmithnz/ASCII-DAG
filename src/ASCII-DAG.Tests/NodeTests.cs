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

        //Assert
        Assert.IsNotNull(graph);
        Assert.AreEqual(0, graph.Nodes.Count);
        Assert.AreEqual(0, graph.Edges.Count);
    }

    [TestMethod]
    public void NodesATest()
    {
        //Arrange
        Graph graph = Helper.Example1();

        //Act

        //Assert
        Assert.IsNotNull(graph);
        Assert.AreEqual(1, graph.Nodes.Count);
        Assert.AreEqual(0, graph.Edges.Count);
        Assert.AreEqual("A", graph.Nodes[0].Name);
    }

    [TestMethod]
    public void NodesAToBTest()
    {
        //Arrange
        Graph graph = Helper.Example2();

        //Act

        //Assert
        Assert.IsNotNull(graph);
        Assert.AreEqual(2, graph.Nodes.Count);
        Assert.AreEqual(1, graph.Edges.Count);
        Assert.AreEqual("A", graph.Nodes[0].Name);
        Assert.AreEqual("B", graph.Nodes[1].Name);
    }
}