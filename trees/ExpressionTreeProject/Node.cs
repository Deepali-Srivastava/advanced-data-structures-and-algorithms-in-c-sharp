using System;
using System.Collections.Generic;


namespace ExpressionTreeProject
{
    class Node
    {
        public Node lchild;
        public char info;
        public Node rchild;

        public Node(char c)
        {
            info = c;
            lchild = null;
            rchild = null;
        }
    }
}
