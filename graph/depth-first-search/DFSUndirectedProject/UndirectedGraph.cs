/*
Copyright (C) Deepali Srivastava - All Rights Reserved
This code is part of DSA course available on CourseGalaxy.com    
*/

using System;

namespace DFSUndirectedProject
{
    class UndirectedGraph
    {
        public readonly int MAX_VERTICES = 30;

	    int n;           
	    int e;           
	    bool [,] adj; 
	    Vertex [] vertexList;
   
	    private readonly int INITIAL = 0;
	    private readonly int VISITED = 1;
        private readonly int FINISHED = 2;
	   
	    public UndirectedGraph()
	    {
	        adj = new bool[MAX_VERTICES,MAX_VERTICES];
	        vertexList = new Vertex[MAX_VERTICES];
	    }
     
	    public void DfsTraversal()
	    {
	   	    int v;
	   	    for ( v = 0; v < n; v++ ) 
	   		    vertexList[v].state = INITIAL;
	   	
	   	    Console.Write("Enter starting vertex for Depth First Search : ");
	  	    String s = Console.ReadLine();
	 	    Dfs( GetIndex(s) );

            Console.WriteLine();
	    }

	    private void Dfs(int v)
	    {
	   	    Console.Write(vertexList[v].name + " ");
	   	    vertexList[v].state = VISITED;

	   	    for(int i=0; i<n; i++)
	   	    {
	   	    	    if(IsAdjacent(v,i) && vertexList[i].state == INITIAL)
	   				    Dfs(i);
	   	    }
	   	    vertexList[v].state = FINISHED;
	    }
	   
	    public void DfsTraversal_All()
	    {
	   	    int v;
	   	    for ( v = 0; v < n; v++ ) 
	   		    vertexList[v].state = INITIAL;
	   	
	   	    Console.Write("Enter starting vertex for Depth First Search : ");
	  	    String s = Console.ReadLine();

	 	    Dfs( GetIndex(s) );
	   	 
	   	    for ( v = 0; v < n; v++)
		 	    if ( vertexList[v].state == INITIAL )
				    Dfs(v);
	    }

        private int GetIndex(String s)
        {
	        for (int i = 0; i < n; i++)
	            if (s.Equals(vertexList[i].name))
	   		        return i;
	        throw new InvalidOperationException("Invalid Vertex");
        }
   
        public void InsertVertex(String name)
        {  
	        vertexList[n++] = new Vertex(name);  
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
                adj[u,v]=true;
                adj[v,u]=true;
                e++;
            }
        }
    }
}
