/*
Copyright (C) Deepali Srivastava - All Rights Reserved
This code is part of DSA course available on CourseGalaxy.com    
*/

using System;

namespace DFSClassifyEdgesProject
{
    class DirectedGraph
    {
        public readonly int MAX_VERTICES = 30;

        int n;
        int e;
        bool[,] adj;
        Vertex[] vertexList;

        private static int time;
        private static bool hasCycle;

        /* constants for different states of a vertex */
        private readonly int INITIAL = 0;
        private readonly int VISITED = 1;
        private readonly int FINISHED = 2;

        public DirectedGraph()
        {
            adj = new bool[MAX_VERTICES, MAX_VERTICES];
            vertexList = new Vertex[MAX_VERTICES];
        }

        private void Dfs(int v)
        {
	        vertexList[v].state = VISITED;
	        vertexList[v].discoveryTime = ++time;
   	
    	    for(int i=0; i<n; i++)
   	        {
   		        if(IsAdjacent(v,i))
   		        {
   			        if(vertexList[i].state == INITIAL)
   			        {
   				        Console.WriteLine("Tree Edge - "+ vertexList[v].name + ", " + vertexList[i].name);
   				        Dfs(i);
   			        }
   			        else if(vertexList[i].state == VISITED)
   			        {
                        Console.WriteLine("Back Edge - " + vertexList[v].name + ", " + vertexList[i].name);
   			        }
			        else if(vertexList[v].discoveryTime < vertexList[i].discoveryTime)
			        {
                        Console.WriteLine("Forward Edge - " + vertexList[v].name + ", " + vertexList[i].name );
			        }
			        else
			        {
                        Console.WriteLine("Cross Edge - " + vertexList[v].name + ", " + vertexList[i].name);
			        }
   		        }
   	        }
   	        vertexList[v].state = FINISHED;
   	        vertexList[v].finishingTime = ++time;
        }

        public void DfsTraversal_All()
        {
   	        int v;
   	        for(v=0; v<n; v++) 
   		        vertexList[v].state = INITIAL;
   	
   	        time=0;
   	        
   	        Console.WriteLine("Enter starting vertex for Depth First Search : ");
   	        String s = Console.ReadLine();
 	        Dfs(GetIndex(s));
   	
 	        for(v=0; v<n; v++)
	 	        if(vertexList[v].state == INITIAL)
			        Dfs(v);
        }

        public bool IsCyclic()
        {
            int v;
            for (v = 0; v < n; v++)
                 vertexList[v].state = INITIAL;
            
            hasCycle = false;

            for (v = 0; v < n; v++)
                if (vertexList[v].state == INITIAL)
                     DfsC(v);
            return hasCycle;
        }

        private void DfsC(int v)
        {
            vertexList[v].state = VISITED;
                    
            for (int i = 0; i < n; i++)
            {
                if (IsAdjacent(v, i))
                {
                    if (vertexList[i].state == INITIAL)
                       DfsC(i);
                    else if (vertexList[i].state == VISITED)/*checking for back edge*/
                       hasCycle = true;
                 }
            }
            vertexList[v].state = FINISHED;
        }

        public void InsertVertex(String name)
        {
            vertexList[n++] = new Vertex(name);
        }

        private int GetIndex(String s)
        {
            for (int i = 0; i < n; i++)
                  if (s.Equals(vertexList[i].name))
                       return i;
            throw new System.InvalidOperationException("Invalid Vertex");
        }

        private bool IsAdjacent(int u, int v)
        {
             return adj[u, v];
        }

        /*Insert an edge (s1,s2) */
        public void InsertEdge(String s1, String s2)
        {
            int u = GetIndex(s1);
            int v = GetIndex(s2);

            if (u == v)
                throw new System.InvalidOperationException("Not a valid edge");
            if (adj[u, v] == true)
                Console.Write("Edge already present");
            else
            {
                adj[u, v] = true;
                e++;
            }
        }
    }
}
