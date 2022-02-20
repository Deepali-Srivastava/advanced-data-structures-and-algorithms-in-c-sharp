/*
Copyright (C) Deepali Srivastava - All Rights Reserved
This code is part of DSA course available on CourseGalaxy.com    
*/

using System;

namespace KruskalsProject
{
    class PriorityQueue
    {
        private QueueNode front;
	
	    public PriorityQueue()
	    {
		    front=null;
	    }
	
	    public void Insert(Edge e)
	    {
		    QueueNode temp,p;
		
		    temp = new QueueNode(e);

		    /*Queue is empty or element to be added has priority more than first element*/
		    if( IsEmpty() || e.wt < front.info.wt )
		    {
			    temp.link=front;
			    front=temp;
		    }
		    else
		    {
			    p=front;
			    while( p.link!=null && p.link.info.wt <= e.wt )
			    	p=p.link;
			    temp.link=p.link;
			    p.link=temp;
		    }
	    }

	    public Edge Delete()
	    {
		    Edge e;
		    if(IsEmpty())
		      throw new InvalidOperationException("Queue Underflow");
		    else
		    {
			    e=front.info;
			    front=front.link;
		    }
		    return e;
	    }

	    public bool IsEmpty()
	    {
	    	return (front==null);
	    }
     }
}
