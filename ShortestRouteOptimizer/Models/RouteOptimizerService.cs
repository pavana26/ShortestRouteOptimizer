using ShortestRouteOptimizer.App_Data;
using ShortestRouteOptimizer.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShortestRouteOptimizer.Models
{
    public class RouteOptimizerService : IRouteOptimizerService
    {
        private readonly Graph GraphNode = ConstructGraph.BuildGraph();
       
        public ShortestPathData ShortestPath(string souceNodeName, string destNodeName, List<string> graphNode)
        {
            DistanceCalculator calculator = new DistanceCalculator(GraphNode);
            ShortestPathData optimumResult = calculator.Calculate(GraphNode.GetNode(souceNodeName), GraphNode.GetNode(destNodeName));
            return optimumResult;
        }
    }
}