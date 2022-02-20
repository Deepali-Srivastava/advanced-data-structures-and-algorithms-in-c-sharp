/*
Copyright (C) Deepali Srivastava - All Rights Reserved
This code is part of DSA course available on CourseGalaxy.com    
*/

using System;

namespace KruskalsProject
{
    class Edge 
    {
        public int u;
        public int v;
        public int wt;

        public Edge(int u, int v, int wt)
        {
            this.u = u;
            this.v = v;
            this.wt = wt;
        }
    }
}
