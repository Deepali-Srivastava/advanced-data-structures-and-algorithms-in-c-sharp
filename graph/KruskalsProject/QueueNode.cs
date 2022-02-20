/*
Copyright (C) Deepali Srivastava - All Rights Reserved
This code is part of DSA course available on CourseGalaxy.com    
*/

using System;

namespace KruskalsProject
{
    class QueueNode
    {
        public Edge info;  
        public QueueNode link;
    
        public QueueNode(Edge e) 
	    {
		    info=e;
		    link=null;
	    }
    }
}
