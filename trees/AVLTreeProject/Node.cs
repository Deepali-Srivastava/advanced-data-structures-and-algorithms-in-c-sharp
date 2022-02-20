using System;

namespace AVLTreeProject
{
    class Node
    {
        public Node lchild;
        public int info;
        public Node rchild;
        public int balance;

        public Node(int i)
        {
            info = i;
            balance = 0;
            lchild = null;
            rchild = null;
        }
    }
}
