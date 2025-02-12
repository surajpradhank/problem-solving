using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Concepts.Graph;

public static class Classroom
{
    // using Adjacency List

    public class Edge
    {
        public int source;
        public int destination;
        public int weight;

        public Edge(int src, int dest, int weight)
        {
            source = src;
            destination = dest;
            this.weight = weight;
        }
    }

    public static void CreateGraph(List<Edge>[] graph)
    {
        for (int i = 0; i < graph.Length; i++)
        {
            graph[i] = new List<Edge>();
        }

        graph[0].Add(new Edge(0, 2, 2));

        graph[1].Add(new Edge(1, 2, 10));
        graph[1].Add(new Edge(1, 3, 0));

        graph[2].Add(new Edge(2, 0, 2));
        graph[2].Add(new Edge(2, 1, 10));
        graph[2].Add(new Edge(2, 3, -1));

        graph[3].Add(new Edge(3, 1, 0));
        graph[3].Add(new Edge(3, 2, -1));
    }

    public static void CallClassroom()
    {
        int V = 4;
        List<Edge>[] graph = new List<Edge>[V];

        CreateGraph(graph);

        for (int i = 0; i < graph.Length; i++)
        {
            foreach (var item in graph[i])
            {
                Console.WriteLine($"Item at index {i} =  {{{item.source},{item.destination}}} and weight = {item.weight}");
            }
        }

    }
}
