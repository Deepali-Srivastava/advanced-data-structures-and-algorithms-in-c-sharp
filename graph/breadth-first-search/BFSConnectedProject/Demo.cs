/*
Copyright (C) Deepali Srivastava - All Rights Reserved
This code is part of DSA course available on CourseGalaxy.com    
*/

using System;

namespace BFSConnectedProject
{
    class Demo
    {
        static void Main(string[] args)
        {
            UndirectedGraph g1 = new UndirectedGraph();

            g1.InsertVertex("Zero");
            g1.InsertVertex("One");
            g1.InsertVertex("Two");
            g1.InsertVertex("Three");
            g1.InsertVertex("Four");
            g1.InsertVertex("Five");
            g1.InsertVertex("Six");
            g1.InsertVertex("Seven");
            g1.InsertVertex("Eight");
            g1.InsertVertex("Nine");

            g1.InsertEdge("Zero", "One");
            g1.InsertEdge("Zero", "Seven");
            g1.InsertEdge("One", "Two");
            g1.InsertEdge("One", "Four");
            g1.InsertEdge("One", "Five");
            g1.InsertEdge("Two", "Three");
            g1.InsertEdge("Two", "Five");
            g1.InsertEdge("Three", "Six");
            g1.InsertEdge("Four", "Seven");
            g1.InsertEdge("Five", "Six");
            g1.InsertEdge("Five", "Seven");
            g1.InsertEdge("Five", "Eight");
            g1.InsertEdge("Six", "Nine");
            g1.InsertEdge("Seven", "Eight");
            g1.InsertEdge("Eight", "Nine");

            g1.IsConnected();
            
            UndirectedGraph g2 = new UndirectedGraph();

            g2.InsertVertex("Zero");
            g2.InsertVertex("One");
            g2.InsertVertex("Two");
            g2.InsertVertex("Three");
            g2.InsertVertex("Four");
            g2.InsertVertex("Five");
            g2.InsertVertex("Six");
            g2.InsertVertex("Seven");
            g2.InsertVertex("Eight");
            g2.InsertVertex("Nine");
            g2.InsertVertex("Ten");
            g2.InsertVertex("Eleven");
            g2.InsertVertex("Twelve");
            g2.InsertVertex("Thirteen");
            g2.InsertVertex("Fourteen");
            g2.InsertVertex("Fifteen");
            g2.InsertVertex("Sixteen");


            g2.InsertEdge("Zero", "One");
            g2.InsertEdge("Zero", "Two");
            g2.InsertEdge("Zero", "Three");
            g2.InsertEdge("One", "Three");
            g2.InsertEdge("Two", "Five");
            g2.InsertEdge("Three", "Four");
            g2.InsertEdge("Four", "Five");
            g2.InsertEdge("Six", "Seven");
            g2.InsertEdge("Six", "Eight");
            g2.InsertEdge("Seven", "Ten");
            g2.InsertEdge("Eight", "Nine");
            g2.InsertEdge("Nine", "Ten");
            g2.InsertEdge("Eleven", "Twelve");
            g2.InsertEdge("Eleven", "Fourteen");
            g2.InsertEdge("Eleven", "Fifteen");
            g2.InsertEdge("Twelve", "Thirteen");
            g2.InsertEdge("Thirteen", "Fourteen");
            g2.InsertEdge("Fourteen", "Sixteen");

            g2.IsConnected();
        }
    }
}
