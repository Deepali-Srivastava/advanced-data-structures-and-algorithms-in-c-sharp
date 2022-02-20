using System;

namespace AVLTreeProject
{
    class Demo
    {
        static void Main(string[] args)
        {
       		AVLTree tree = new AVLTree(); 
    		int choice,x;
		
	    	while(true)
		    {
			    Console.WriteLine("1.Display Tree");
			    Console.WriteLine("2.Insert a new node");
			    Console.WriteLine("3.Delete a node");
			    Console.WriteLine("4.Inorder Traversal");
			    Console.WriteLine("5.Quit");
			    Console.Write("Enter your choice : ");
			    choice = Convert.ToInt32(Console.ReadLine());

			    if(choice==5)
				    break;

			    switch(choice)
			    {
			    case 1:
				    tree.Display();
				    break;
			    case 2:
				    Console.Write("Enter the key to be inserted : ");
				    x = Convert.ToInt32(Console.ReadLine());
				    tree.Insert(x);
				    break;
			    case 3:
				    Console.Write("Enter the key to be deleted : ");
				    x = Convert.ToInt32(Console.ReadLine());
				    tree.Delete(x);
				    break;
			     case 4:
			        tree.Inorder();
				    break;
			    }/*End of switch */
		    }/*End of while */
        }
    }
}
