/*
Copyright (C) Deepali Srivastava - All Rights Reserved
This code is part of DSA course available on CourseGalaxy.com    
*/

using System;

namespace PrimsProject
{
    class Vertex
    {
        public String name;
        public int status;
        public int predecessor;
        public int length;

        public Vertex(String name)
        {
            this.name = name;
        }
    }
}
