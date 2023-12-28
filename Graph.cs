using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Node
    {
        public int vertex;
        public Node next;

        public Node(int data)
        {
            vertex = data;
            next = null;
        }
    }
    class Graph
    {
        private int v;
        private Node[] graph;
        public Graph(int vertices)
        {
            v = vertices;
            graph = new Node[v];
            for (int i = 0; i < v; ++i)
            {
                graph[i] = null;
            }
        }
        public void AddEdge(int source, int destination)
        {
            Node node = new Node(destination);
            node.next = graph[source];
            graph[source] = node;
        }
        public void AddVertex(int vk, int source, int destination)
        {
            AddEdge(source, vk);
            AddEdge(vk, destination);
        }
        public void RemoveVertex(int k)
        {
            for (int i = 0; i < v; ++i)
            {
                Node temp = graph[i];
                if (i == k)
                {
                    graph[i] = temp.next;
                    temp = graph[i];
                }

                while (temp != null)
                {
                    if (temp.vertex == k)
                    {
                        break;
                    }
                    Node prev = temp;
                    temp = temp.next;
                    if (temp == null)
                    {
                        continue;
                    }
                    prev.next = temp.next;
                    temp = null;
                }
            }
        }
        public void InsertEdge(List<int>[] adj, int u, int v)
        {
            adj[u].Add(v);
            adj[v].Add(u);
        }
        public void RemoveEdge(List<int>[] adj, int u, int v)
        {
            for (int i = 0; i < adj[u].Count; i++)
            {
                if (adj[u][i] == v)
                {
                    adj[u].RemoveAt(i);
                    break;
                }
            }

            for (int i = 0; i < adj[v].Count; i++)
            {
                if (adj[v][i] == u)
                {
                    adj[v].RemoveAt(i);
                    break;
                }
            }
        }
        public void DFS(int[,] edges, int v, bool[] visited, int si)
        {
            visited[si] = true;
            Console.Write(si + " ");
            for (int i = 0; i < v; i++)
            {
                if (i == si)
                    continue;
                if (!visited[i] && edges[si, i] == 1)
                {
                    DFS(edges, v, visited, i);
                }
            }
        }
        public void BFS(int[,] edges, int v, bool[] visited, int si)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(si);
            visited[si] = true;
            while (queue.Count != 0)
            {
                int currentVertex = queue.Dequeue();
                Console.Write(currentVertex + " ");
                for (int i = 0; i < v; i++)
                {
                    if (i == currentVertex)
                        continue;
                    if (!visited[i] && edges[currentVertex, i] == 1)
                    {
                        queue.Enqueue(i);
                        visited[i] = true;
                    }
                }
            }
        }
        public void PrintGraph()
        {
            for (int i = 0; i < v; ++i)
            {
                Console.Write(i + " ");
                Node temp = graph[i];
                while (temp != null)
                {
                    Console.Write("-> " + temp.vertex + " ");
                    temp = temp.next;
                }
                Console.WriteLine();
            }
        }
    }
}
