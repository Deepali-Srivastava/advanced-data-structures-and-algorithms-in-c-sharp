/*
Copyright (C) Deepali Srivastava - All Rights Reserved
This code is part of DSA course available on CourseGalaxy.com    
*/

using System;

namespace PathMatrixProject
{
    class DirectedGraph
    {
        public readonly int MAX_VERTICES = 30;

	    int n;           
	    int e;           
	    bool [,] adj; 
	    Vertex [] vertexList;
         
        public DirectedGraph()
        {
	        adj = new bool[MAX_VERTICES,MAX_VERTICES];
	        vertexList = new Vertex[MAX_VERTICES];
        }
   
        public void FindPathMatrix()
        {	             
            int [,] x = new int[n,n];
            int[,] adjp = new int[n, n];
            int[,] temp = new int[n, n];
			   
	        for (int i = 0; i<n; i++)
		        for (int j = 0; j<n; j++)
			        x[i,j] = adjp[i,j] = adj[i,j] ? 1 : 0 ;
	   
	        for (int p = 2; p <= n; p++)
	        {
		        for (int i = 0; i<n; i++)
			        for (int j = 0; j<n; j++)
			        {
					    temp[i,j] = 0;
					    for (int k = 0; k<n; k++)
						    temp[i,j] = temp[i,j] + adjp[i,k] * (adj[k,j] ? 1 : 0);
			        }
		   	
		        for (int i = 0; i<n; i++)
			        for (int j = 0; j<n; j++)
				        adjp[i,j] = temp[i,j];
   		   
		        for (int i = 0; i<n; i++)
			        for (int j = 0; j<n; j++)
		  		        x[i,j] = x[i,j] + adjp[i,j];
	        }
	   
	        //Display X
	        for (int i = 0; i<n; i++)
	        {
	            for (int j = 0; j<n; j++)
	                Console.Write(x[i,j] + " ");
	            Console.WriteLine();
	        }
	        Console.WriteLine();      
	  
	        bool [,] path = new bool[n,n];
	        
            for (int i = 0; i<n; i++)
		        for (int j = 0; j<n; j++)
			   	    if (x[i,j] == 0 )
					    path[i,j] = false;
				    else
					    path[i,j] = true;	   	
		   
	        //Display Path Matrix
	        for (int i = 0; i<n; i++)
	        {
	            for (int j = 0; j<n; j++)
	                if (path[i,j]) 
	                    Console.Write("1 ");
	                else
	                    Console.Write("0 ");
	                Console.WriteLine();
	        }
	    }

        public void Display()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    if (adj[i, j])
                        Console.Write("1 ");
                    else
                        Console.Write("0 ");
                Console.WriteLine();
            }
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
