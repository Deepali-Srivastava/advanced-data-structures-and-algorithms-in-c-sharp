/*
Copyright (C) Deepali Srivastava - All Rights Reserved
This code is part of DSA course available on CourseGalaxy.com    
*/

using System;

namespace DFSClassifyEdgesUndirectedProject
{
    class Demo
    {
        static void Main(string[] args)
        {
            UndirectedGraph g = new UndirectedGraph();
		
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

		    g.InsertEdge("Zero","One");
		    g.InsertEdge("Zero","Three");
		    g.InsertEdge("One","Two");
		    g.InsertEdge("One","Three");
		    g.InsertEdge("One","Four");
		    g.InsertEdge("Three","Four");
		    g.InsertEdge("Five","Six");
		    g.InsertEdge("Five","Seven");
		    g.InsertEdge("Five","Eight");
		    g.InsertEdge("Seven","Eight");
		    g.InsertEdge("Nine","Ten");
		    g.InsertEdge("Nine","Eleven");
		    g.InsertEdge("Nine","Twelve");
		    g.InsertEdge("Nine","Thirteen");
		    g.InsertEdge("Ten","Twelve");
		    g.InsertEdge("Eleven","Thirteen");
		    g.InsertEdge("Eleven","Fourteen");

		    g.DfsTraversal_All();
		
		    if(g.IsCyclic())
			    Console.WriteLine("Graph is Cyclic");
		    else
			    Console.WriteLine("Graph is Acylic");
        }
    }
}
