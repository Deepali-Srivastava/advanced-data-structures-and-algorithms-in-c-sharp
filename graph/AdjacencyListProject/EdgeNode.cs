/*
Copyright (C) Deepali Srivastava - All Rights Reserved
This code is part of DSA course available on CourseGalaxy.com    
*/

using System;

namespace AdjacencyListProject
{
    class EdgeNode
    {
        public VertexNode endVertex;
        public EdgeNode nextEdge;

        public EdgeNode(VertexNode v)
        {
            endVertex = v;
        }
    }
}
