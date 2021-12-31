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
        Node node = new();

        //Act

        //Assert
        Assert.IsNotNull(node);
        Assert.IsNull(node.Name);
        Assert.AreEqual(0, node.NodePrereqs.Count);
    }

    [TestMethod]
    public void NodesAToBTest()
    {
        //Arrange
        Node nodeA = new()
        {
            Name = "A"
        };
        Node nodeB = new()
        {
            Name = "B",
            NodePrereqs = new() { nodeA }
        };


        //Act

        //Assert
        Assert.IsNotNull(nodeA);
        Assert.IsNotNull(nodeB);
        Assert.AreEqual("A",nodeA.Name);
        Assert.AreEqual("B",nodeB.Name);
        Assert.AreEqual(0, nodeA.NodePrereqs.Count);
        Assert.AreEqual(1, nodeB.NodePrereqs.Count);
    }
}