/*
Copyright (C) Deepali Srivastava - All Rights Reserved
This code is part of DSA course available on CourseGalaxy.com    
*/

using System;

namespace PrimsProject
{
    class UndirectedWeightedGraph
    {
        public readonly int MAX_VERTICES = 30;

	    int n;           
	    int e;               
        int [,] adj; 
        Vertex [] vertexList;

        private readonly int TEMPORARY = 1;
        private readonly int PERMANENT = 2;
        private readonly int NIL= -1;
        private readonly int INFINITY = 99999; 
   
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
   
        public void Prims()
        {	
	        int c,v;
	    
	        int edgesInTree = 0;
	        int wtTree = 0;
   			    
   		    for (v = 0; v < n; v++)
   		    {
   			    vertexList[v].status = TEMPORARY;
   			    vertexList[v].length = INFINITY;
   			    vertexList[v].predecessor = NIL;
   		    }

   		    int root = 0;
   		    vertexList[root].length = 0;
   		
   		    while (true)
   		    {
   			    c = TempVertexMinL();
   	
   			    if (c == NIL) 
   			    {
   				    if (edgesInTree == n-1) 
   				    {
   					    Console.WriteLine("Weight of minimum spanning tree is " + wtTree);
   					    return;
   				    }
   				    else 		
   					    throw new InvalidOperationException
                            ("Graph is not connected, Spanning tree not possible");
   			    }
   		
   			    vertexList[c].status = PERMANENT;
   			
                /* Include edge ( vertexList[c].predecessor,c ) in the tree*/ 
   			    if (c != root)
   			    {
   				    edgesInTree++;
   				    Console.WriteLine("(" + vertexList[c].predecessor + "," + c + ")");
   				    wtTree = wtTree + adj[vertexList[c].predecessor,c];
   			    }
   			
   			    for (v = 0; v < n; v++)
   				    if (IsAdjacent(c,v) && vertexList[v].status == TEMPORARY)
   					    if (adj[c,v] < vertexList[v].length)
   					    {
   						    vertexList[v].length = adj[c,v];
   						    vertexList[v].predecessor = c;
   					    }
   		    }/*End of while*/
        }

        int TempVertexMinL()
        {
 	 
 	        int min = INFINITY;
 	        int x = NIL;
 	
 	        for (int v = 0; v < n; v++)
 	        {
 		        if(vertexList[v].status == TEMPORARY && vertexList[v].length < min)
 		        {
 			        min = vertexList[v].length;
 			        x = v;
 		        }
 	        }
 	        return x;
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
    }
}

