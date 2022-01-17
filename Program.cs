using System;
using System.Collections.Generic;

namespace Graph
{
    class Program
    {
        static GraphGenerics<int> graph = new GraphGenerics<int>(new List<int>[] {
            new List<int>() {4}, // successors of vertice 0
            new List<int>() {1, 2, 6}, // successors of vertice 1
            new List<int>() {1, 6}, // successors of vertice 2
            new List<int>() {6}, // successors of vertice 3
            new List<int>() {0}, // successors of vertice 4
            new List<int>() {}, // successors of vertice 5
            new List<int>() {1, 2, 3} // successors of vertice 6
            });

        static bool[] visited = new bool[graph.Size];

        static void TraverseDFS(int v)
        {
            if (!visited[v])
            {
                Console.Write(v + " ");
                visited[v] = true;
                foreach (int child in graph.GetSuccessors(v))
                {
                    TraverseDFS(child);
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Connected graph components: ");
            for (int v = 0; v < graph.Size; v++)
            {
                if (!visited[v])
                {
                    TraverseDFS(v);
                    Console.WriteLine();
                }
            }

        }
    }
}
