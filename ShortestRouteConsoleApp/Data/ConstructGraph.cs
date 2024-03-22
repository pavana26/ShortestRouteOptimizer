using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ShortestRouteConsoleApp.Data
{
    public static class ConstructGraph
    {
        public static Graph BuildGraph() {

            Graph graphWithNode = new Graph();

            // Create nodes

            Node A = new Node("A");
            Node B = new Node("B");
            Node C = new Node("C");
            Node D = new Node("D");
            Node E = new Node("E");
            Node F = new Node("F");
            Node G = new Node("G");
            Node H = new Node("H");
            Node I = new Node("I");

            //Add created nodes to the graph
            graphWithNode.Add(A); graphWithNode.Add(B); graphWithNode.Add(C);
            graphWithNode.Add(D); graphWithNode.Add(E); graphWithNode.Add(F);
            graphWithNode.Add(G); graphWithNode.Add(H); graphWithNode.Add(I);

            // Add neighbour vertex to each node with distance
            A.AddNeighbourVertex(B, 4); A.AddNeighbourVertex(C, 6);
            B.AddNeighbourVertex(A, 4); B.AddNeighbourVertex(F, 2);
            C.AddNeighbourVertex(A, 6); C.AddNeighbourVertex(D, 8);
            D.AddNeighbourVertex(C, 8); D.AddNeighbourVertex(E, 4); D.AddNeighbourVertex(G, 1);
            E.AddNeighbourVertex(B, 2); E.AddNeighbourVertex(D, 4); E.AddNeighbourVertex(F, 3); E.AddNeighbourVertex(I, 8);
            F.AddNeighbourVertex(B, 2); F.AddNeighbourVertex(E, 3); F.AddNeighbourVertex(G, 4); F.AddNeighbourVertex(H, 6);
            G.AddNeighbourVertex(D, 1); G.AddNeighbourVertex(F, 4); G.AddNeighbourVertex(H, 5); G.AddNeighbourVertex(I, 5);
            H.AddNeighbourVertex(F, 6); H.AddNeighbourVertex(G, 5);
            I.AddNeighbourVertex(E, 8); I.AddNeighbourVertex(G, 5);

            return graphWithNode;

        }
    }
}
