/*
Copyright (C) Deepali Srivastava - All Rights Reserved
This code is part of DSA course available on CourseGalaxy.com    
*/

using System;

namespace UndirectedWeightedGraphProject
{
    class Demo
    {
        static void Main(string[] args)
        {
            UndirectedWeightedGraph g = new UndirectedWeightedGraph();
		  
		    int choice,wt;
		    String s1,s2;
	   
		    while (true)
		    {
	    	    Console.WriteLine("1.Display Adjacency Matrix");
			    Console.WriteLine("2.Insert a vertex");
			    Console.WriteLine("3.Insert an edge");
			    Console.WriteLine("4.Delete an edge");
			    Console.WriteLine("5.Display Indegree and outdegree of a vertex");
			    Console.WriteLine("6.Check if there is an edge between two vertices");
			    Console.WriteLine("7.Exit");
			    Console.Write("Enter your choice : ");
			    choice = Convert.ToInt32(Console.ReadLine());
			    if (choice == 7)
				    break;
			
			    switch (choice)
			    {
			        case 1:
				        g.Display();
				        Console.WriteLine("Vertices = " + g.Vertices() );
                        Console.WriteLine("Edges = " + g.Edges());
			            break;
			        case 2:
				        Console.Write("Insert a vertex : ");
				        s1 = Console.ReadLine();
				        g.InsertVertex(s1);
				        break;
			        case 3:
				        Console.Write("Enter start and end vertices : ");
				        s1 = Console.ReadLine();
				        s2 = Console.ReadLine();
				        Console.Write("Enter weight  : ");
				        wt = Convert.ToInt32(Console.ReadLine());
				        g.InsertEdge(s1,s2,wt);
				        break;
			        case 4:
				        Console.Write("Enter start and end vertices : ");
				        s1 = Console.ReadLine();
				        s2 = Console.ReadLine();
				        g.DeleteEdge(s1,s2);
				        break;
			        case 5: 
				        Console.Write("Enter a vertex : ");
				        s1 = Console.ReadLine();
				        Console.WriteLine("Degree is : " + g.Degree(s1));
				        break;
			        case 6:
				        Console.Write("Enter two vertices : ");
				        s1 = Console.ReadLine();
				        s2 = Console.ReadLine();
				        if(g.EdgeExists(s1,s2))
					        Console.WriteLine("There is an edge from " + s1 + " to " + s2);
				        else
					        Console.WriteLine("There is no edge from " + s1 + " to " + s2);
				        break;
			        default:
				        Console.WriteLine("Wrong choice");
				        break;			
		        }
	        }
        }
    }
}

