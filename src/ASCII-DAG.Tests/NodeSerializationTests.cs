//using ASCII_DAG.Models;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

//namespace ASCII_DAG.Tests;

//[TestClass]
//public class NodeSerializationTests
//{
//    [TestMethod]
//    public void NodeEmptySerializationTest()
//    {
//        //Arrange
//        Node node = new()
//        {
//            Name = "A"
//        };

//        //Act
//        string? result = Serialization.Serialize(node);

//        //Assert
//        Assert.IsNotNull(result);
//        Assert.AreEqual("A", result);
//    }

//    [TestMethod]
//    public void NodesAToBSerializationTest()
//    {
//        //Arrange
//        Node nodeA = new()
//        {
//            Name = "A"
//        };
//        Node nodeB = new()
//        {
//            Name = "B",
//            NodePrereqs = new() { nodeA }
//        };

//        //Act
//        string? result = Serialization.Serialize(nodeB);

//        //Assert
//        Assert.IsNotNull(result);
//        Assert.AreEqual("A--B", result);
//    }
//}