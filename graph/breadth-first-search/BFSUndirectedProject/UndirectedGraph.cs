/*
Copyright (C) Deepali Srivastava - All Rights Reserved
This code is part of DSA course available on CourseGalaxy.com    
*/

using System;
using System.Collections.Generic;

namespace BFSUndirectedProject
{
    class UndirectedGraph
    {
        public readonly int MAX_VERTICES = 30;

	    int n;           
	    int e;           
	    bool [,] adj; 
	    Vertex [] vertexList;
	
	    /*constants for different states of a vertex*/
	    private readonly int INITIAL = 0;   
	    private readonly int WAITING = 1;
        private readonly int VISITED = 2;  	 
	   
   	    public UndirectedGraph()
	    {
	       adj = new bool[MAX_VERTICES,MAX_VERTICES];
	       vertexList = new Vertex[MAX_VERTICES];
	    }
  
   	    public void BfsTraversal()
        {
    	    int v;
    	    for ( v = 0; v < n; v++) 
    		    vertexList[v].state = INITIAL;
    	
    	  	 Console.Write("Enter starting vertex for Breadth First Search : ");
    	     String s = Console.ReadLine();
    	     Bfs( GetIndex(s) );
        }
    
   	    private void Bfs(int v)
        {	   
 	        Queue<int> qu = new Queue<int>();
 	        qu.Enqueue(v);
 	        vertexList[v].state = WAITING;
            while ( qu.Count!=0 )
            {
    		    v = qu.Dequeue();
    		    Console.Write(vertexList[v].name + " ");
    		    vertexList[v].state = VISITED;
    		
    		    for (int i = 0; i < n; i++)
    		    {
    			    if(IsAdjacent(v,i) && vertexList[i].state == INITIAL) 
    			    {
    				    qu.Enqueue(i);
    				    vertexList[i].state=WAITING;
    			    }
    		    }
    	    }
    	    Console.WriteLine();
        }
   	
   	
   	    public void BfsTraversal_All()
        {
    	    int v;
    	    for ( v = 0; v < n; v++) 
    		    vertexList[v].state = INITIAL;
    	
    	    Console.Write("Enter starting vertex for Breadth First Search : ");
            String s = Console.ReadLine();
    	    Bfs(GetIndex(s));
    	 
    	    for ( v = 0; v < n; v++ )
 	 	        if ( vertexList[v].state == INITIAL )
 			        Bfs(v);
        }
   	
   	
        private int GetIndex(String s)
        {
	        for(int i=0; i<n; i++)
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
            if ( adj[u,v] == true )
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
