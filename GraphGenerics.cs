using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class GraphGenerics<T>
    {
        private List<T>[] childNodes;

        public GraphGenerics(int size)
        {
            this.childNodes = new List<T>[size];
            for(int i = 0; i < size; i++)
            {
                this.childNodes[i] = new List<T>();
            }
        }

        public GraphGenerics(List<T>[] childNodes)
        {
            this.childNodes = childNodes;
        }

        public int Size
        {
            get { return this.childNodes.Length; }
        }

        public void AddEgde(int u, T v)
        {
            this.childNodes[u].Add(v);
        }

        public void RemoveEdge(int u, T v)
        {
            this.childNodes[u].Remove(v);
        }

        public bool HasEdge(int u, T v)
        {
            return this.childNodes[u].Contains(v);
        }

        public IList<T> GetSuccessors(int v)
        {
            return this.childNodes[v];
        }
    }
}
