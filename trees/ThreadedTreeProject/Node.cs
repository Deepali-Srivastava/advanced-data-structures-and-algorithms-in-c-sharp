using System;

namespace ThreadedTreeProject
{
    class Node
    {
        public Node left;
        public bool leftThread;
        public int info;
        public bool rightThread;
        public Node right;
    
        public Node(int i)
        {
            info = i;
            left = null;
            right = null;
            leftThread = true;
            rightThread = true;
        }
    }
}
