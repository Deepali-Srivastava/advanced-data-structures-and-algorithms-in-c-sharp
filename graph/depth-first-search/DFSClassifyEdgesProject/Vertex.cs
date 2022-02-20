/*
Copyright (C) Deepali Srivastava - All Rights Reserved
This code is part of DSA course available on CourseGalaxy.com    
*/

using System;

namespace DFSClassifyEdgesProject
{
    class Vertex
    {
        public String name;
        public int state;
        public int discoveryTime;
        public int finishingTime;

        public Vertex(String name)
        {
            this.name = name;
        }

    }
}
