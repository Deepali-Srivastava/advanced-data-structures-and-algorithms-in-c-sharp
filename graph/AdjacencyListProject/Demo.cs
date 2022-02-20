/*
Copyright (C) Deepali Srivastava - All Rights Reserved
This code is part of DSA course available on CourseGalaxy.com    
*/

using System;

namespace AdjacencyListProject
{
    class Demo
    {
        static void Main(string[] args)
        {
            LinkedDigraph g = new LinkedDigraph();
		  		        
	        int choice;
            String s1, s2;
                  	            
	        while(true)
		    {
			    Console.WriteLine("1.Display ");
			    Console.WriteLine("2.Insert a vertex");
			    Console.WriteLine("3.Delete a vertex");
			    Console.WriteLine("4.Insert an edge");
			    Console.WriteLine("5.Delete an edge");
			    Console.WriteLine("6.Display Indegree and outdegree of a vertex");
			    Console.WriteLine("7.Check if there is an edge between two vertices");
			    Console.WriteLine("8.Exit");
			    Console.Write("Enter your choice : ");
			    choice = Convert.ToInt32(Console.ReadLine());
			    if(choice == 8)
			    	break;
			
			    switch(choice)
			    {
			        case 1:
				        Console.WriteLine();
				        g.Display();
				        Console.WriteLine("Vertices = " + g.Vertices() );
                        Console.WriteLine("Edges = " + g.Edges());
			            break;
			        case 2:
				        Console.Write("Enter a vertex to be inserted :  ");
				        s1 = Console.ReadLine();
				        g.InsertVertex(s1);
				        break;
			        case 3:
				        Console.Write("Enter a vertex to be deleted :  ");
				        s1 = Console.ReadLine();
				        g.DeleteVertex(s1);
				        break;
			        case 4:
				        Console.Write("Enter an edge to be inserted : ");
				        s1 = Console.ReadLine();
				        s2 = Console.ReadLine();
				        g.InsertEdge(s1,s2);
				        break;
			        case 5:
				        Console.Write("Enter an edge to be deleted : ");
				        s1 = Console.ReadLine();
				        s2 = Console.ReadLine();
				        g.DeleteEdge(s1,s2);
				        break;
			        case 6: 
				         Console.Write("Enter a vertex : ");
				         s1 = Console.ReadLine();
				         Console.WriteLine("Indegree is : " + g.inDegree(s1));
				         Console.WriteLine("Outdegree is : " + g.outDegree(s1));
				         break;
			        case 7:
				        Console.Write("Enter two vertices : ");
				        s1 = Console.ReadLine();
				        s2 = Console.ReadLine();
				        if(g.EdgeExists(s1,s2))
					        Console.WriteLine("Vertex " + s2 + " is adjacent to vertex " + s1);
				        else
				 	        Console.WriteLine("Vertex " + s2 + " is not adjacent to vertex " + s1);
				
				        if (g.EdgeExists(s2,s1))
					        Console.WriteLine("Vertex " + s1 + " is adjacent to vertex " + s2);
				        else
					        Console.WriteLine("Vertex " + s1 + " is not adjacent to vertex " + s2);
                        break;
			        default:
				        Console.WriteLine("Wrong choice");
				        break;
			    }
		    }
        }
     }
}
