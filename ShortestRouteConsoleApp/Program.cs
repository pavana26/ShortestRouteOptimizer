using ShortestRouteConsoleApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestRouteConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> nodes = new List<string> { "A", "B", "C", "D", "E", "F", "G", "H","I" };
            Console.WriteLine("===========================================");
            Console.WriteLine("Welcome shortest route optimizer");
            Console.WriteLine("===========================================");
            Console.Write("Enter From Node (A to I):");
            string SourceNode = Console.ReadLine();
            while (!nodes.Contains(SourceNode))
            {
                Console.Write("Please Enter From/Source Node (A to I):");
                SourceNode = Console.ReadLine();
            }
            Console.Write("Enter To/Destination Node (A to I) :");
            string DestinationNode = Console.ReadLine();
            while (!nodes.Contains(DestinationNode))
            {
                Console.Write("Please Enter To/Destination Node (A to I):");
                DestinationNode = Console.ReadLine();
            }
            Graph gr = ConstructGraph.BuildGraph();
            DistanceCalculator dc = new DistanceCalculator(gr); 
            ShortestPathData answer = dc.Calculate(gr.GetNode(SourceNode), gr.GetNode(DestinationNode));

            Console.Write("fromNodeName = " + SourceNode + ", toNodeName = " + DestinationNode + " : ");
            Console.WriteLine(string.Join(", ", answer.NodeNames)); 
            Console.WriteLine("Shortest distance :: "+answer.Distance);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
            System.Environment.Exit(0);
        }
    }
}
