using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ShortestRouteConsoleApp
{
    public  class DistanceCalculator
    {
        Dictionary<Node, int> Distances;
        Dictionary<Node, Node> Routes;
        Graph graph;
        List<Node> AllNodes;

        public DistanceCalculator(Graph graph)
        {
            this.graph = graph;
            this.AllNodes = graph.GetNodes();
            Distances = SetDistances();
            Routes = SetRoutes();
        }

        private Dictionary<Node, int> SetDistances()
        {
            Dictionary<Node, int> Distances = new Dictionary<Node, int>();

            foreach (Node n in graph.GetNodes())
            {
                Distances.Add(n, int.MaxValue);
            }
            return Distances;
        }

        private Dictionary<Node, Node> SetRoutes()
        {
            Dictionary<Node, Node> Routes = new Dictionary<Node, Node>();

            foreach (Node n in graph.GetNodes())
            {
                Routes.Add(n, null);
            }
            return Routes;
        }

        public ShortestPathData Calculate(Node Source, Node Destination)

        {

            Distances[Source] = 0;

            while (AllNodes.ToList().Count != 0)
            {
                Node LeastExpensiveNode = GetLeastDistanceNode();
                ExamineConnections(LeastExpensiveNode);
                AllNodes.Remove(LeastExpensiveNode);
            }

            ShortestPathData result = new ShortestPathData();
            var property = typeof(ShortestPathData).GetField("<Distance>k__BackingField", BindingFlags.Instance | BindingFlags.NonPublic);
            property.SetValue(result, Distances[Destination]);

            return GetshortestPathData(Source, Destination, result);

        }

        private void ExamineConnections(Node n)
        {
            foreach (var neighbor in n.GetNeighbours())
            {
                if (Distances[n] + neighbor.Value < Distances[neighbor.Key])
                {
                    Distances[neighbor.Key] = neighbor.Value + Distances[n];
                    Routes[neighbor.Key] = n;
                }
            }
        }

        private Node GetLeastDistanceNode()
        {
            Node LeastDistance = AllNodes.FirstOrDefault();

            foreach (var n in AllNodes)
            {
                if (Distances[n] < Distances[LeastDistance])
                    LeastDistance = n;
            }

            return LeastDistance;
        }


        private ShortestPathData GetshortestPathData(Node Source, Node Destination, ShortestPathData result)
        {

            List<string> nodeNames = new List<string>();
            AddNodeName(Destination, nodeNames);
            nodeNames.Add(Source.GetName());
            nodeNames.Reverse();

            result.NodeNames = nodeNames;
            return result;
        }

        private void AddNodeName(Node d, List<string> nodeNames)
        {
            if (Routes[d] == null)
                return;
            nodeNames.Add(d.GetName());
            AddNodeName(Routes[d], nodeNames);
        }
    }
}
