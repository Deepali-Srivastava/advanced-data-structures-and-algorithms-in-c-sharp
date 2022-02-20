/*
Copyright (C) Deepali Srivastava - All Rights Reserved
This code is part of DSA course available on CourseGalaxy.com    
*/

using System;

namespace WarshallsProject
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

            g1.InsertEdge("Zero", "One");
            g1.InsertEdge("Zero", "Three");
            g1.InsertEdge("One", "Two");
            g1.InsertEdge("Two", "One");
            g1.InsertEdge("Three", "Zero");
            g1.InsertEdge("Three", "Two");

            g1.Warshalls();
        }
    }
}
