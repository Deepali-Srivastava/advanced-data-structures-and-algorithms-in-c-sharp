/*
Copyright (C) Deepali Srivastava - All Rights Reserved
This code is part of DSA course available on CourseGalaxy.com    
*/

using System;

namespace UndirectedWeightedGraphProject
{
    class UndirectedWeightedGraph
    {
        public readonly int MAX_VERTICES = 30;

	    int n;           
	    int e;               
        int [,] adj; 
        Vertex [] vertexList;
   
        public UndirectedWeightedGraph()
        {
            adj = new int[MAX_VERTICES,MAX_VERTICES];
            vertexList = new Vertex[MAX_VERTICES];
        }
      
        public int Vertices()
        {  
	        return n; 
        }

        public int Edges()
        {
	        return e;
        }
   
        public void Display()
        {
            for (int i = 0; i<n; i++)
            {
                for (int j = 0; j<n; j++)
                    Console.Write(adj[i,j] + " ");
                Console.WriteLine();
            }
        }
        
        private int GetIndex(String s)
        {
	        for (int i = 0; i<n; i++)
	            if (s.Equals(vertexList[i].name))
	   		        return i;
            throw new System.InvalidOperationException("Invalid Vertex");
        }
   
        public void InsertVertex(String name)
        {  
	        vertexList[n++] = new Vertex(name);  
        }
   
        /* Returns true if edge (s1,s2) exists */
        public bool EdgeExists(String s1, String s2)
        {
	        return IsAdjacent(GetIndex(s1), GetIndex(s2));
        }
   
        private bool IsAdjacent(int u, int v)
        {
	        return (adj[u,v] != 0);
        }
   
        /*Insert an edge (s1,s2) */
        public void InsertEdge(String s1, String s2, int wt)
        {
	        int u = GetIndex(s1);
	        int v = GetIndex(s2);
            if (adj[u,v] !=0 )
    	        Console.Write("Edge already present");
            else  
            {
                adj[u,v] = wt;
                adj[v,u] = wt;
                e++;
            }
        }
   
        /* Delete the edge (s1,s2) */
        public void DeleteEdge(String s1, String s2)
        {
	        int u = GetIndex(s1);
	        int v = GetIndex(s2);
	        if (adj[u,v] == 0)
		        Console.WriteLine("Edge not present");
	        else	  
	        {
                adj[u,v] = 0;
                adj[v,u] = 0;         
                e--;
            }
        }
   
        public int Degree(String s)
        {
	        int u = GetIndex(s); 
	   
            int deg = 0;
            for (int v = 0; v<n; v++)
                if (adj[u,v] != 0)
                    deg++;
            return deg;
        }
    }
}
