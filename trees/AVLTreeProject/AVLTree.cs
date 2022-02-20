using System;

namespace AVLTreeProject
{
    class AVLTree
    {
        private Node root;

        static bool taller;
        static bool shorter;

        public AVLTree()
        {
            root = null;
        }

        public bool IsEmpty()
        {
            return (root == null);
        }

        public void Display()
	    {
		    Display(root,0);
		    Console.WriteLine();
	    }

        private void Display(Node p, int level)
	    {
		    int i;
		    if(p==null)
			    return;
	
		    Display(p.rchild, level+1);
			    Console.WriteLine();
	
		    for(i=0; i<level; i++)
			    Console.Write("    ");
		    Console.Write(p.info);
	
		    Display(p.lchild, level+1);
	    }

        public void Inorder()
	    {
		    Inorder(root);
		    Console.WriteLine();
	    }

        private void Inorder(Node p)
	    {
		    if(p==null )
			    return;
		    Inorder(p.lchild);
		    Console.Write(p.info + " ");
		    Inorder(p.rchild);
	    }

        public void Insert(int x)
        {
            root = Insert(root, x);
        }

        private Node Insert(Node p, int x)
	    {
		    if(p==null)	
		    {
			    p=new Node(x);
			    taller = true;
		    }
		    else if(x < p.info)	
		    {
			    p.lchild = Insert(p.lchild,x);
			    if(taller==true)
				    p = InsertionLeftSubtreeCheck(p);
		    }
		    else if(x > p.info)	
		    {
			    p.rchild = Insert(p.rchild,x);
			    if(taller==true)
				    p = InsertionRightSubtreeCheck(p);
		    }
		    else
		    {
			    Console.WriteLine(x + " already present in tree");
			    taller = false;
		    }
		    return p;
	    }

        private Node InsertionLeftSubtreeCheck(Node p)
        {
            switch (p.balance)
            {
                case 0:  //Case L_1 : was balanced  
                    p.balance = 1;	// now left heavy 
                    break;
                case -1: //Case L_2 : was right heavy   
                    p.balance = 0;	// now balanced 
                    taller = false;
                    break;
                case 1: // Case L_3 : was left heavy    
                    p = InsertionLeftBalance(p);	//Left Balancing 
                    taller = false;
                    break;
            }
            return p;
        }

        private Node InsertionRightSubtreeCheck(Node p)
        {
            switch (p.balance)
            {
                case 0:   // Case R_1 : was balanced 	
                    p.balance = -1;	// now right heavy 
                    break;
                case 1:  // Case R_2 : was left heavy   
                    p.balance = 0;	// now balanced  
                    taller = false;
                    break;
                case -1: // Case R_3: Right heavy    
                    p = InsertionRightBalance(p);	// Right Balancing 
                    taller = false;
                    break;
            }
            return p;
        }

        private Node InsertionLeftBalance(Node p)
        {
            Node a, b;

            a = p.lchild;
            if (a.balance == 1)  // Case L_3A : Insertion in AL   
            {
                p.balance = 0;
                a.balance = 0;
                p = RotateRight(p);
            }
            else		//  Case L_3B : Insertion in AR  
            {
                b = a.rchild;
                switch (b.balance)
                {
                    case 1:		// Case L_3B2 : Insertion in BL  
                        p.balance = -1;
                        a.balance = 0;
                        break;
                    case -1:	// Case L_3B2 : Insertion in BR     
                        p.balance = 0;
                        a.balance = 1;
                        break;
                    case 0:		// Case L_3B2 : B is the newly inserted node   
                        p.balance = 0;
                        a.balance = 0;
                        break;
                }
                b.balance = 0;
                p.lchild = RotateLeft(a);
                p = RotateRight(p);
            }
            return p;
        }

        private Node InsertionRightBalance(Node p)
        {
            Node a, b;

            a = p.rchild;
            if (a.balance == -1) // Case R_3A : Insertion in AR   
            {
                p.balance = 0;
                a.balance = 0;
                p = RotateLeft(p);
            }
            else		// Case R_3B : Insertion in AL  
            {
                b = a.lchild;
                switch (b.balance)
                {
                    case -1:  // Insertion in BR  
                        p.balance = 1;
                        a.balance = 0;
                        break;
                    case 1:	  // Insertion in BL  
                        p.balance = 0;
                        a.balance = -1;
                        break;
                    case 0:	  // B is the newly inserted node  
                        p.balance = 0;
                        a.balance = 0;
                        break;
                }
                b.balance = 0;
                p.rchild = RotateRight(a);
                p = RotateLeft(p);
            }
            return p;
        }

        private Node RotateLeft(Node p)
        {
            Node a = p.rchild;
            p.rchild = a.lchild;
            a.lchild = p;
            return a;
        }

        private Node RotateRight(Node p)
        {
            Node a = p.lchild;
            p.lchild = a.rchild;
            a.rchild = p;
            return a;
        }

        public void Delete(int x)
        {
            root = Delete(root, x);
        }

        private Node Delete(Node p, int x)
	    {
		    Node ch,s;
                
		    if(p==null)
		    {
			    Console.WriteLine(x + "  not found");
			    shorter = false;
			    return p;
		    }
		    if(x < p.info)  //delete from left subtree 
		    {
			    p.lchild = Delete(p.lchild, x);
			    if(shorter == true)
				    p = DeletionLeftSubtreeCheck(p);
		    }
		    else if(x > p.info) //delete from right subtree 
		    {
			    p.rchild = Delete(p.rchild, x);
			    if(shorter==true)
				    p = DeletionRightSubtreeCheck(p);
		    }
		    else
		    {
			    //key to be deleted is found 
			    if( p.lchild!=null  &&  p.rchild!=null )  //2 children 
			    {
				    s=p.rchild;
				    while(s.lchild!=null)
					    s=s.lchild;
				    p.info=s.info;
				    p.rchild = Delete(p.rchild,s.info);
				    if( shorter == true )
					    p = DeletionRightSubtreeCheck(p);
			    }
			    else   //1 child or no child 	
			    {
				    if(p.lchild != null) //only left child 
					    ch=p.lchild;
				    else  //only right child or no child 
					    ch=p.rchild;
				    p=ch;
				    shorter = true;
			    }						
		    }
		    return p; 
	    }

        private Node DeletionLeftSubtreeCheck(Node p)
        {
            switch (p.balance)
            {
                case 0: // Case L_1 : was balanced         
                    p.balance = -1;	// now right heavy   
                    shorter = false;
                    break;
                case 1: // Case L_2 : was left heavy  	 
                    p.balance = 0;	// now balanced  
                    break;
                case -1: // Case L_3 : was right heavy     
                    p = DeletionRightBalance(p); //Right Balancing 
                    break;
            }
            return p;
        }

        private Node DeletionRightSubtreeCheck(Node p)
        {
            switch (p.balance)
            {
                case 0:	  // Case R_1 : was balanced  		
                    p.balance = 1;	// now left heavy  
                    shorter = false;
                    break;
                case -1:  // Case R_2 : was right heavy  	
                    p.balance = 0;	// now balanced  
                    break;
                case 1:   // Case R_3 : was left heavy  	
                    p = DeletionLeftBalance(p);  //Left Balancing 
                    break;
            }
            return p;
        }

        private Node DeletionLeftBalance(Node p)
        {
            Node a, b;
            a = p.lchild;
            if (a.balance == 0)  // Case R_3A  
            {
                a.balance = -1;
                shorter = false;
                p = RotateRight(p);
            }
            else if (a.balance == 1)   // Case R_3B 
            {
                p.balance = 0;
                a.balance = 0;
                p = RotateRight(p);
            }
            else						// Case R_3C  
            {
                b = a.rchild;
                switch (b.balance)
                {
                    case 0:				// Case R_3C1  
                        p.balance = 0;
                        a.balance = 0;
                        break;
                    case -1:			// Case R_3C2 
                        p.balance = 0;
                        a.balance = 1;
                        break;
                    case 1:			    // Case R_3C3  
                        p.balance = -1;
                        a.balance = 0;
                        break;
                }
                b.balance = 0;
                p.lchild = RotateLeft(a);
                p = RotateRight(p);
            }
            return p;
        }

        private Node DeletionRightBalance(Node p)
        {
            Node a, b;

            a = p.rchild;
            if (a.balance == 0)	// Case L_3A
            {
                a.balance = 1;
                shorter = false;
                p = RotateLeft(p);
            }
            else if (a.balance == -1)	// Case L_3B  
            {
                p.balance = 0;
                a.balance = 0;
                p = RotateLeft(p);
            }
            else						// Case L_3C 
            {
                b = a.lchild;
                switch (b.balance)
                {
                    case 0:				// Case L_3C1 
                        p.balance = 0;
                        a.balance = 0;
                        break;
                    case 1:				// Case L_3C2  
                        p.balance = 0;
                        a.balance = -1;
                        break;
                    case -1:			// Case L_3C3  
                        p.balance = 1;
                        a.balance = 0;
                        break;
                }
                b.balance = 0;
                p.rchild = RotateRight(a);
                p = RotateLeft(p);
            }
            return p;
        }
    }
}
