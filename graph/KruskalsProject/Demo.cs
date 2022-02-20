/*
Copyright (C) Deepali Srivastava - All Rights Reserved
This code is part of DSA course available on CourseGalaxy.com    
*/

using System;

namespace KruskalsProject
{
    class Demo
    {
        static void Main(string[] args)
        {
            UndirectedWeightedGraph g = new UndirectedWeightedGraph();

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

            g.InsertEdge("Zero", "One", 19);
            g.InsertEdge("Zero", "Three", 14);
            g.InsertEdge("Zero", "Four", 12);
            g.InsertEdge("One", "Two", 20);
            g.InsertEdge("One", "Four", 18);
            g.InsertEdge("Two", "Four", 17);
            g.InsertEdge("Two", "Five", 15);
            g.InsertEdge("Two", "Nine", 29);
            g.InsertEdge("Three", "Four", 13);
            g.InsertEdge("Three", "Six", 28);
            g.InsertEdge("Four", "Five", 16);
            g.InsertEdge("Four", "Six", 21);
            g.InsertEdge("Four", "Seven", 22);
            g.InsertEdge("Four", "Eight", 24);
            g.InsertEdge("Five", "Eight", 26);
            g.InsertEdge("Five", "Nine", 27);
            g.InsertEdge("Six", "Seven", 23);
            g.InsertEdge("Seven", "Eight", 30);
            g.InsertEdge("Eight", "Nine", 35);

            g.Kruskals();

        }
    }
}
