/*
Copyright (C) Deepali Srivastava - All Rights Reserved
This code is part of DSA course available on CourseGalaxy.com    
*/

using System;

namespace AdjacencyListProject
{
    class LinkedDigraph
    {
        VertexNode start;
        int n;
        int e;

        public int Vertices()
        {
            return n;
        }

        public int Edges()
        {
            return e;
        }

        public void InsertVertex(String s)
	    {
		    VertexNode temp = new VertexNode(s);

		    if (start == null)
			    start = temp;
		    else
		    {
			    VertexNode p = start;
			    while (p.nextVertex != null)
			    {
				    if(p.name.Equals(s))
				    {
					    Console.WriteLine("Vertex already present");
					    return;
				    }
				    p = p.nextVertex;
			    }
			    if(p.name.Equals(s))
			    {
				    Console.WriteLine("Vertex already present");
				    return;
			    }	
			    p.nextVertex = temp;
		   }
		   n++;
	    }

        public void DeleteVertex(String s)
        {
            DeletefromEdgeLists(s);
            DeletefromVertexList(s);
        }

        /*Delete incoming edges*/
        private void DeletefromEdgeLists(String s)
        {
            for (VertexNode p = start; p != null; p = p.nextVertex)
            {
                if (p.firstEdge == null)
                    continue;

                if (p.firstEdge.endVertex.name.Equals(s))
                {
                    p.firstEdge = p.firstEdge.nextEdge;
                    e--;
                }
                else
                {
                    EdgeNode q = p.firstEdge;
                    while (q.nextEdge != null)
                    {
                        if (q.nextEdge.endVertex.name.Equals(s))
                        {
                            q.nextEdge = q.nextEdge.nextEdge;
                            e--;
                            break;
                        }
                        q = q.nextEdge;
                    }
                }
            }
        }


        private void DeletefromVertexList(String s)
	    {
		    if (start == null) 
		    {
			    Console.WriteLine("No vertices to be deleted");
			    return;
		    }
	
		    if (start.name.Equals(s)) /* Vertex to be deleted is first vertex of list*/
		    {
			    for(EdgeNode q = start.firstEdge; q != null; q = q.nextEdge)  
				    e--;
			    start = start.nextVertex;   
			    n--;
		    }
		    else 
		    {
	            VertexNode p = start;
			    while (p.nextVertex != null)
			    {
				    if(p.nextVertex.name.Equals(s))     
				        break;		
				    p = p.nextVertex;  
			    }
			
	    		if (p.nextVertex == null)
		    	{
			    	Console.WriteLine("Vertex not found");
				    return;
			    }
			    else
			    {
				    for (EdgeNode q = p.nextVertex.firstEdge; q != null; q = q.nextEdge)
						e--;
				    p.nextVertex = p.nextVertex.nextVertex;
				    n--;
			    }
		    }
	    }

        private VertexNode FindVertex(String s)
        {
            VertexNode p = start;
            while (p != null)
            {
                if (p.name.Equals(s))
                    return p;
                p = p.nextVertex;
            }
            return null;
        }

        /*Insert an edge (s1,s2) */
        public void InsertEdge(String s1, String s2)
	    {
	        if (s1.Equals(s2))
	        {
	    	    Console.WriteLine("Inavlid Edge : Start and end vertices are same");
	    	    return;
	        }
		
	        VertexNode u = FindVertex(s1);
		    VertexNode v = FindVertex(s2);

		    if (u == null)
		    {
			    Console.WriteLine("Start vertex not present, first insert vertex " + s1);
			    return;
		    }
		    if (v == null)
		    {
			    Console.WriteLine("End vertex not present, first insert vertex " + s2);
			    return;
		    }
		
		    EdgeNode temp = new EdgeNode(v);
		    if (u.firstEdge == null)   
		    {
			    u.firstEdge = temp;
			    e++;
		    }
		    else
		    {
			    EdgeNode p = u.firstEdge;
			    while (p.nextEdge != null)
			    {	
				    if (p.endVertex.name.Equals(s2))
				    {
					    Console.WriteLine("Edge present");
					    return;
				    }
				    p = p.nextEdge;
			    }
			    if (p.endVertex.name.Equals(s2))
			    {
				    Console.WriteLine("Edge present");
				    return;
			    }
			    p.nextEdge = temp;
			    e++;
		    }
	    }

        /* Delete the edge (s1,s2) */
        public void DeleteEdge(String s1, String s2)
	    {
		    VertexNode u = FindVertex(s1);

		    if (u == null)
		    {
			    Console.WriteLine("Start vertex not present");
			    return;
		    }
		    if (u.firstEdge == null)
		    {
			    Console.WriteLine("Edge not present");
			    return;
		    }
		    
		    if (u.firstEdge.endVertex.name.Equals(s2))
		    {
			    u.firstEdge = u.firstEdge.nextEdge;
			    e--;
			    return;
		    }
		    EdgeNode q = u.firstEdge;
		    while (q.nextEdge != null)
		    {
			    if (q.nextEdge.endVertex.name.Equals(s2))  
			    {
				    q.nextEdge = q.nextEdge.nextEdge;
				    e--;    
				    return;
			    }
			    q = q.nextEdge;
		    }
		    Console.WriteLine("Edge not present");
	    }

        public void Display()
	    {
		    EdgeNode q;
		    for (VertexNode p = start; p != null; p = p.nextVertex)
		    {
			    Console.Write(p.name + "->");
			    for (q = p.firstEdge; q != null; q = q.nextEdge)
				    Console.Write(" " + q.endVertex.name);
			    Console.WriteLine();
		    }
	    }

        /* Returns true if s2 is adjacent to s1, i.e. if edge (s1,s2) exists */
        public bool EdgeExists(String s1, String s2)
        {
            VertexNode u = FindVertex(s1);
            EdgeNode q = u.firstEdge;
            while (q != null)
            {
                if (q.endVertex.name.Equals(s2))
                    return true;
                q = q.nextEdge;
            }
            return false;
        }

        /*Returns number of edges going out from vertex s*/
        public int outDegree(String s)
	    {
	        VertexNode u = FindVertex(s);
	        if (u == null)
                throw new System.InvalidOperationException("Vertex not present");
		
	        int outd = 0;
	        EdgeNode q = u.firstEdge;
	        while (q != null)
	        {	  
	            q = q.nextEdge;  
	    	    outd++;
	        }
	        return outd;
	   }

        /*Returns number of edges coming to vertex s*/
        public int inDegree(String s)
	    {
	        VertexNode u = FindVertex(s);
	        if (u == null)
		  	    throw new System.InvalidOperationException("Vertex not present");
		
		    int ind = 0;
	        for (VertexNode p = start; p != null; p = p.nextVertex)
	        {
	    	    for (EdgeNode q = p.firstEdge; q != null; q = q.nextEdge)
	    	  	    if ( q.endVertex.name.Equals(s) )
	    			  ind++;
	        }
	        return ind;
        }
    }
}
