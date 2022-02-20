using System;

namespace BtreeProject
{
    class Node
    {
        public int[] key;
	    public Node[] child;
        public int numKeys;

        public Node(int size)
        {
            numKeys = 0;
            key = new int[size];
            child = new Node[size];
        }
    }
}
