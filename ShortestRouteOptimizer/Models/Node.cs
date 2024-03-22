
using System.Collections.Generic;


namespace ShortestRouteOptimizer.Models
{
    public class Node
    {
        private string Name;
        private Dictionary<Node, int> NeighbourVertices;

        public Node(string NodeName)
        {
            Name = NodeName;
            NeighbourVertices = new Dictionary<Node, int>();
        }

        public void AddNeighbourVertex(Node n, int distance)
        {
            NeighbourVertices.Add(n, distance);
        }

        public string GetName()
        {
            return Name;
        }

        public Dictionary<Node, int> GetNeighbours()
        {
            return NeighbourVertices;
        }
    }
}