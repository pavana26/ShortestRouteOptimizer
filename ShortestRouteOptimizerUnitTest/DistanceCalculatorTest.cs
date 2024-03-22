using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShortestRouteOptimizer.App_Data;
using ShortestRouteOptimizer.Models;
using ShortestRouteOptimizer.Models.DTO;
using System;
using System.Linq;

namespace ShortestRouteOptimizerUnitTest
{
    [TestClass]
    public class DistanceCalculatorTest
    {
        static Graph mockGraph = ConstructGraph.BuildGraph();
        DistanceCalculator mockDistance = new DistanceCalculator(mockGraph);

        [TestMethod]
        public void TestMethodZeroDistance()
        {
            ShortestPathData result = mockDistance.Calculate(mockGraph.GetNode("A"), mockGraph.GetNode("A"));

            Assert.AreEqual(0, result.Distance);
        }
        [TestMethod]
        public void TestMethodMinimumDistanceAtoD()
        {
            ShortestPathData result = mockDistance.Calculate(mockGraph.GetNode("A"), mockGraph.GetNode("D"));

            Assert.AreEqual(11, result.Distance);
        }
        [TestMethod]
        public void TestMethodMinimumDistanceAtoI()
        {
            ShortestPathData result = mockDistance.Calculate(mockGraph.GetNode("A"), mockGraph.GetNode("I"));

            Assert.AreEqual(15, result.Distance);
        }

        [TestMethod]
        public void TestMethodNoNodes()
        {
            ShortestPathData result = mockDistance.Calculate(mockGraph.GetNode("A"), mockGraph.GetNode("A"));

            Assert.AreEqual(0, result.Distance);
        }
        [TestMethod]
        public void TestMethodNodesAtoD()
        {
            ShortestPathData result = mockDistance.Calculate(mockGraph.GetNode("A"), mockGraph.GetNode("D"));

            Assert.AreEqual(5, result.NodeNames.Count());
        }
        [TestMethod]
        public void TestMethodNodesDistanceAtoI()
        {
            ShortestPathData result = mockDistance.Calculate(mockGraph.GetNode("A"), mockGraph.GetNode("I"));

            Assert.AreEqual(5, result.NodeNames.Count());
        }

    }
}
