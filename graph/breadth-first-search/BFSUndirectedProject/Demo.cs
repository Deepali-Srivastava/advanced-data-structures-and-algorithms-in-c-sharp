/*
Copyright (C) Deepali Srivastava - All Rights Reserved
This code is part of DSA course available on CourseGalaxy.com    
*/

using System;

namespace BFSUndirectedProject
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

            g.InsertEdge("Zero", "One");
            g.InsertEdge("Zero", "Seven");
            g.InsertEdge("One", "Two");
            g.InsertEdge("One", "Four");
            g.InsertEdge("One", "Five");
            g.InsertEdge("Two", "Three");
            g.InsertEdge("Two", "Five");
            g.InsertEdge("Three", "Six");
            g.InsertEdge("Four", "Seven");
            g.InsertEdge("Five", "Six");
            g.InsertEdge("Five", "Seven");
            g.InsertEdge("Five", "Eight");
            g.InsertEdge("Six", "Nine");
            g.InsertEdge("Seven", "Eight");
            g.InsertEdge("Eight", "Nine");

            g.BfsTraversal();
            g.BfsTraversal_All();

        }
    }
}
