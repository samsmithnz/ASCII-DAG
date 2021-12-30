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
}