using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphAlgorithm
{
    public class DijkstraAlgorithm<V>
    {
        public Graph<V> Graph { get; }

        public Vertix<V> Vertix { get; }

        public DijkstraAlgorithm(Graph<V> G, Vertix<V> vertix)
        {
            Graph = G;
            Vertix = vertix;
            GetShortestPath();
        }

        private void GetShortestPath()
        {
            PriorityQueue<V> minQueue = new PriorityQueue<V>(Graph.Vertices());

            IntializeDistances();
            Vertix.Distance = 0;

            while(minQueue.IsNull() == false)
            {
                Vertix<V> C = minQueue.MinimumDistance();
                List<Node<V>> adjVertices = Graph.Adj(C);

                foreach(Node<V> node in adjVertices)
                {
                    int x = Vertix.Distance + node.Weight;
                    if(x < node.Vertix.Distance)
                    {
                        node.Vertix.Distance = x;
                        node.Vertix.Previous = Vertix;
                    }
                }

                minQueue.RemoveVertex(C);
                C.Visited = true;
            }

        }

        private void IntializeDistances()
        {
            List<Vertix<V>> vertices = Graph.Vertices();
            foreach(Vertix<V> currVertix in vertices)
            {
                currVertix.Distance = 10000;
            }
        }

        public void PrintShortestPath()
        {
            Console.Write("Vertice Name \t\t\t Distance \t\t\t Parent");
            List <Vertix<V>> vertices = Graph.Vertices();
            foreach (Vertix<V> currVertix in vertices)
            {
                Console.Write("{0} \t\t\t {1} \t\t\t {2}", currVertix.Name, currVertix.Distance, currVertix.Previous.Name);
            }
        }
    }
}
