/*
Copyright (C) Deepali Srivastava - All Rights Reserved
This code is part of DSA course available on CourseGalaxy.com    
*/

using System;

namespace AdjacencyListProject
{
    class VertexNode
    {
        public String name;
        public VertexNode nextVertex;
        public EdgeNode firstEdge;

        public VertexNode(String s)
        {
            name = s;
        }
    }
}
