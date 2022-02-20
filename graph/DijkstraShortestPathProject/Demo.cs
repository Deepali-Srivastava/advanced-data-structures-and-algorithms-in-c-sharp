/*
Copyright (C) Deepali Srivastava - All Rights Reserved
This code is part of DSA course available on CourseGalaxy.com    
*/

using System;

namespace DijkstraShortestPathProject
{
    class Demo
    {
        static void Main(string[] args)
        {
            DirectedWeightedGraph g = new DirectedWeightedGraph();

            g.InsertVertex("Zero");
            g.InsertVertex("One");
            g.InsertVertex("Two");
            g.InsertVertex("Three");
            g.InsertVertex("Four");
            g.InsertVertex("Five");
            g.InsertVertex("Six");
            g.InsertVertex("Seven");
            g.InsertVertex("Eight");

            g.InsertEdge("Zero", "Three", 2);
            g.InsertEdge("Zero", "One", 5);
            g.InsertEdge("Zero", "Four", 8);
            g.InsertEdge("One", "Four", 2);
            g.InsertEdge("Two", "One", 3);
            g.InsertEdge("Two", "Five", 4);
            g.InsertEdge("Three", "Four", 7);
            g.InsertEdge("Three", "Six", 8);
            g.InsertEdge("Four", "Five", 9);
            g.InsertEdge("Four", "Seven", 4);
            g.InsertEdge("Five", "One", 6);
            g.InsertEdge("Six", "Seven", 9);
            g.InsertEdge("Seven", "Three", 5);
            g.InsertEdge("Seven", "Five", 3);
            g.InsertEdge("Seven", "Eight", 5);
            g.InsertEdge("Eight", "Five", 3);

            g.FindPaths("Zero");

        }
    }
}
