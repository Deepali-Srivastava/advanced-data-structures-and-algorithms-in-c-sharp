/*
Copyright (C) Deepali Srivastava - All Rights Reserved
This code is part of DSA course available on CourseGalaxy.com    
*/

using System;

namespace DFSClassifyEdgesProject
{
    class Demo
    {
        static void Main(string[] args)
        {
       		DirectedGraph g = new DirectedGraph();

		    g.InsertVertex("Zero");
		    g.InsertVertex("One");
		    g.InsertVertex("Two");
		    g.InsertVertex("Three");
		    g.InsertVertex("Four");
		    g.InsertVertex("Five");
		    g.InsertVertex("Six");
		    g.InsertVertex("Seven");
		    g.InsertVertex("Eight");
		    g.InsertVertex("Nine");
		    g.InsertVertex("Ten");
		    g.InsertVertex("Eleven");
		    g.InsertVertex("Twelve");
		    g.InsertVertex("Thirteen");
		    g.InsertVertex("Fourteen");
		    g.InsertVertex("Fifteen");
		    g.InsertVertex("Sixteen");
		
		    g.InsertEdge("Zero","One");
		    g.InsertEdge("Zero","Two");
		    g.InsertEdge("Zero","Four");
		    g.InsertEdge("One","Three");
		    g.InsertEdge("Two","Three");
		    g.InsertEdge("Two","Four");
		    g.InsertEdge("Two","Five");
		    g.InsertEdge("Three","Zero");
		    g.InsertEdge("Four","Five");
		    g.InsertEdge("Five","Three");
		    g.InsertEdge("Six","One");
		    g.InsertEdge("Six","Seven");
		    g.InsertEdge("Six","Eight");
		    g.InsertEdge("Six","Nine");
		    g.InsertEdge("Seven","Nine");
		    g.InsertEdge("Eight","Ten");
		    g.InsertEdge("Nine","Five");
		    g.InsertEdge("Ten","Six");
		    g.InsertEdge("Ten","Nine");
		    g.InsertEdge("Eleven","Eight");
		    g.InsertEdge("Eleven","Thirteen");
		    g.InsertEdge("Eleven","Fifteen");
		    g.InsertEdge("Twelve","Eleven");
		    g.InsertEdge("Thirteen","Eight");
		    g.InsertEdge("Thirteen","Fourteen");
		    g.InsertEdge("Thirteen","Fifteen");
		    g.InsertEdge("Thirteen","Sixteen");
		    g.InsertEdge("Fourteen","Sixteen");
		    g.InsertEdge("Fifteen","Twelve");
		    g.InsertEdge("Fifteen","Sixteen");

		    g.DfsTraversal_All();
		
		    if(g.IsCyclic())
			    Console.WriteLine("Graph is Cyclic");
		    else
			    Console.WriteLine("Graph is Acylic");

        }
    }
}
