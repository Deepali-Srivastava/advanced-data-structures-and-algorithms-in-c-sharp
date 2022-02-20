/*
Copyright (C) Deepali Srivastava - All Rights Reserved
This code is part of DSA course available on CourseGalaxy.com    
*/

using System;

namespace BFSShortestPathsProject
{
    class Vertex
    {
        public String name;
        public int state;
        public int predecessor;
        public int distance;

        public Vertex(String name)
        {
            this.name = name;
        }
    }
}
