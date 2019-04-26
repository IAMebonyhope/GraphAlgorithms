using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphAlgorithm
{
    public class Graph<V>
    {
        private Dictionary<Vertix<V>, List<Node<V>>> adjList;

        public Graph(Dictionary<Vertix<V>, List<Node<V>>> list)
        {
            adjList = list;
        }

        public Dictionary<Vertix<V>, List<Node<V>>> GraphAdjList { get { return adjList; } }

        public List<Vertix<V>> Vertices()
        {
            List<Vertix<V>> keys = adjList.Keys.ToList();
            return keys;
        }

        public int NumOfVertices()
        {
            return Vertices().Count;
        }

        public List<Node<V>> Adj(Vertix<V> vert)
        {
            List<Node<V>> values = adjList[vert];
            return values;
        }

        public void AddNode(Vertix<V> vertex, Node<V> node)
        {
            List<Node<V>> nodes = Adj(vertex);
            if (nodes == null || (nodes.Count < 1))
            {
                nodes = new List<Node<V>>();
                nodes.Add(node);
            }
            else
            {
                nodes.Add(node);
            }

            adjList[vertex] = nodes;
        }

        //public Dictionary<Vertix<V>[], int> Edges()
        //{
        //    Dictionary<Vertix<V>[], int> edges = new Dictionary<Vertix<V>[], int>();

        //    foreac (Map.Entry<Vertix<V>, List<Node<V>>> entry : adjList.entrySet())
        //    {
        //        Vertix v1 = entry.getKey();
        //        for (Node n: entry.getValue())
        //        {
        //            Vertix v2 = n.getVertix();
        //            int weight = n.getWeight();

        //            Vertix[] v = { v1, v2 };
        //            edges.put(v, weight);
        //        }
        //    }
        //    return edges;
        //}

        //public int numOfEdges()
        //{
        //    return edges().size();
        //}

        /*public boolean hasRelationship(V v1, V v2) {
        if (v1 == null && v2 == null)
         return true;
        if (v1 != null && v2 == null)
         return true;
        if (v1 == null && v2 != null)
         return false;
        List<Node<V>> nodes = null;
        if (adjacencyList.containsKey(v1)) {
         nodes = adjacencyList.get(v1);
         if (nodes != null || !nodes.isEmpty()) {
          for (Node<V> v : nodes) {
           if (v.getName().equals(v2))
            return true;
          }
         }
        }
        return false;
       }
       public void print() {
        System.out.println("Graph is --->");
        for (V v : adjacencyList.keySet()){
            System.out.println(v + " --- " + adjacencyList.get(v));
                      }  
       }*/
    }
}
