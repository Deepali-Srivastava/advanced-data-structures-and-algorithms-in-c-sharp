/*
Copyright (C) Deepali Srivastava - All Rights Reserved
This code is part of DSA course available on CourseGalaxy.com    
*/

using System;

namespace PathMatrixProject
{
    class Demo
    {
        static void Main(string[] args)
        {
          DirectedGraph g1 = new DirectedGraph();
		        
		  g1.InsertVertex("Zero");
  		  g1.InsertVertex("One");
		  g1.InsertVertex("Two");
		  g1.InsertVertex("Three");

		  g1.InsertEdge("Zero","One");
		  g1.InsertEdge("Zero","Three");
		  g1.InsertEdge("One","Two");
		  g1.InsertEdge("One","Three");
		  g1.InsertEdge("Three","Two");
		  g1.FindPathMatrix();
		  
		  Console.WriteLine();
		 
		  DirectedGraph g2 = new DirectedGraph();
		  
		  g2.InsertVertex("Zero");
  		  g2.InsertVertex("One");
		  g2.InsertVertex("Two");
		  g2.InsertVertex("Three");
		  
		  g2.InsertEdge("Zero","One");
		  g2.InsertEdge("Zero","Three");
		  g2.InsertEdge("One","Two");
		  g2.InsertEdge("One","Three");
		  g2.InsertEdge("Two","Zero");
		  g2.InsertEdge("Three","Two");
		  g2.FindPathMatrix();
       	}	
    }
}

