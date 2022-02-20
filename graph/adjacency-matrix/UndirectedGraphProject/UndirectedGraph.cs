/*
Copyright (C) Deepali Srivastava - All Rights Reserved
This code is part of DSA course available on CourseGalaxy.com    
*/

using System;

namespace UndirectedGraphProject
{
    class UndirectedGraph
    {
            readonly int MAX_VERTICES = 30;

	        int n;           
	        int e;           
	        bool [,] adj; 
	        Vertex [] vertexList;
   
	        public UndirectedGraph()
	        {
	            adj = new bool[MAX_VERTICES,MAX_VERTICES];
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
                        if (adj[i,j]) 
                            Console.Write("1 ");
                        else
                            Console.Write("0 ");
                    Console.WriteLine();
                }
            }
   
            private int GetIndex(String s)
            {
	            for(int i = 0; i<n; i++)
	                if(s.Equals(vertexList[i].name))
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
	            return adj[u,v];
            }
   
            /*Insert an edge (s1,s2) */
            public void InsertEdge(String s1, String s2)
            {
	            int u = GetIndex(s1);
	            int v = GetIndex(s2);
                if(adj[u,v] == true)
    	            Console.Write("Edge already present");
                else  
                {
                    adj[u,v] = true;
                    adj[v,u] = true;
                    e++;
                }
            }
   
            /* Delete the edge (s1,s2) */
            public void DeleteEdge(String s1, String s2)
            {
	            int u = GetIndex(s1);
	            int v = GetIndex(s2);
	            if(adj[u,v] == false)
		            Console.WriteLine("Edge not present");
	            else	  
	            {
                    adj[u,v] = false;
                    adj[v,u] = false;         
                    e--;
                }
            }
      
            public int Degree(String s)
            {
	            int u = GetIndex(s); 
	   
                int deg = 0;
                for(int v = 0; v<n; v++)
                    if (adj[u,v])
                        deg++;
                return deg;
            }
       }
}
