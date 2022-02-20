using System;

namespace ThreadedTreeProject
{
    class ThreadedBinaryTree
    {
        private Node root;

        public ThreadedBinaryTree()
        {
            root = null;
        }

        public bool IsEmpty()
        {
            return (root == null);
        }
        
        private Node InorderPredecessor(Node p)
        {
	        if(p.leftThread == true)
		        return p.left;
	        else
	        {   
		        p = p.left;
		        while(p.rightThread == false)
			        p = p.right;
		        return p;
	        }
        }

        private Node InorderSuccessor(Node p)
        {
	        if(p.rightThread == true)
		        return p.right; 
	        else
	        {
		        p = p.right;
		        while(p.leftThread == false)
			        p = p.left;
		        return p;
	        }
        }
             
        public void Inorder()
        {
	        if(root == null )
	        {
                Console.Write("Tree is empty");
		        return;
	        }
            	        
	        /*Find the leftmost node of the tree*/
            Node p = root;
            while( p.leftThread == false )
		        p = p.left;
	
	        while( p!=null )
	        {
		        Console.Write(p.info + " ");
                if (p.rightThread == true)
                    p = p.right;
                else
                {
                    p = p.right;
                    while (p.leftThread == false)
                        p = p.left;
                }
	        }
            Console.WriteLine();
        }
    
        public void Insert(int x)
        {
            Node p = root;
            Node par = null;
        
            while (p!=null)
            {
                par = p;
                if (x < p.info)
                {
                    if (p.leftThread == false)
                        p = p.left;
                    else
                        break;
                }
                else if(x > p.info)
                {
                    if (p.rightThread == false)
                        p = p.right;
                    else
                        break;
                }
                else
                {
                    Console.WriteLine(x + " already present in the tree");
                    return;
                }
            }

            Node temp = new Node(x);
            if (par == null)
            {
                root = temp;
            }
            else if (x < par.info) /*inserted as left child*/
            {
                temp.left = par.left;
                temp.right = par;
                par.leftThread = false;
                par.left = temp;
            }
            else  /*inserted as right child*/
            {
                temp.left = par;
                temp.right = par.right;
                par.rightThread = false;
                par.right = temp;
            }
        }

        public void Delete(int x)
        {
            Node p = root;
            Node par = null;

            while (p != null)
            {
                if (x == p.info)
                    break;
                par = p;
                if (x < p.info)
                {
                    if (p.leftThread == false)
                        p = p.left;
                    else
                        break;
                }
                else
                {
                    if (p.rightThread == false)
                        p = p.right;
                    else
                        break;
                }
            }

            if (p == null || p.info != x)
            {
                Console.WriteLine(x + " not found");
                return;
            }
                        
            if (p.leftThread == false && p.rightThread == false)/*Case C: 2 children*/
            {
                /*Find inorder successor and its parent*/
                Node ps = p;
                Node s = p.right;

                while (s.leftThread == false)
                {
                    ps = s;
                    s = s.left;
                }
                p.info = s.info;
                p = s;
                par = ps;
            }

            /*Case A : No child*/
            if (p.leftThread == true && p.rightThread == true)
            {
                if (par == null)
                    root = null;
                else if (p == par.left)
                {
                    par.leftThread = true;
                    par.left = p.left;
                }
                else
                {
                    par.rightThread = true;
                    par.right = p.right;
                }
                return;
            }

            /*Case B : 1 child*/
            Node ch;
            if (p.leftThread == false) /*node to be deleted has left child */
                ch = p.left;
            else                /*node to be deleted has right child */
                ch = p.right;

            if (par == null)   /*node to be deleted is root node*/
                root = ch;
            else if (p == par.left)/*node is left child of its parent*/
                par.left = ch;
            else  /*node is right child of its parent*/
                par.right = ch;

            Node pred = InorderPredecessor(p);
            Node succ = InorderSuccessor(p);

            if (p.leftThread == false) /*if p has left child, right is a thread */
                pred.right = succ;
            else  /*p has right child,left is a thread*/
                succ.left = pred;
        }
    }       
}
