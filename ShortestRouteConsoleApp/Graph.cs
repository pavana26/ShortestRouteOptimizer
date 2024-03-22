using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestRouteConsoleApp
{
    public class Graph
    {
        private List<Node> Nodes;
        public Graph()
        {
            Nodes = new List<Node>();
        }

        public void Add(Node n)
        {
            Nodes.Add(n);
        }

        public List<Node> GetNodes()
        {
            return Nodes.ToList();
        }

        public Node GetNode(string name)
        {
            return Nodes.FirstOrDefault(node => node.GetName().Equals(name));
        }
    }
}
