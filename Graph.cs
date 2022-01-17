using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class Graph
    {
        //Contains the child nodes of each vertex|node in the graph
        private List<int>[] childNodes;

        //Contructor -> constructing a graph of a given size
        public Graph(int size)
        {
            this.childNodes = new List<int>[size];
            for(int i = 0; i < size; i++)
            {
                //Assing an empty list of adjacents for each vertex
                this.childNodes[i] = new List<int>();
            }
        }

        //Constructor -> constructing a graph given a list of child nodes (successors) for each vertex
        public Graph(List<int>[] childNodes)
        {
            this.childNodes = childNodes;
        }

        //Returns the size of the graph (number of vertices|nodes)
        public int Size
        {
            get { return this.childNodes.Length; }
        }

        //Adding a new route|edge from u to v
        public void AddEdge(int u, int v)
        {
            this.childNodes[u].Add(v);
        }

        //Removes the edge from u to v if such exists
        public void RemoveEdge(int u, int v)
        {
            this.childNodes[u].Remove(v);
        }

        // Checks whether there is an edge between vertex u and v
        //true if there is an edge between
        /// vertex u and vertex v
        public bool HasEdge(int u, int v)
        {
            return this.childNodes[u].Contains(v);
        }

        //Returns the successors of a given vertex
        public IList<int> GetSuccessors(int v)
        {
            return this.childNodes[v];
        }
    }
}
