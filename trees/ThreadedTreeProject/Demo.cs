using System;

namespace ThreadedTreeProject
{
    class Demo
    {
        static void Main(string[] args)
        {
            ThreadedBinaryTree tree = new ThreadedBinaryTree(); 
    		int choice,x;
                              
		    while(true)
		    {
			    Console.WriteLine("1.Insert a new node");
			    Console.WriteLine("2.Delete a node");
			    Console.WriteLine("3.Inorder Traversal");
			    Console.WriteLine("4.Exit");
			    
                Console.Write("Enter your choice : ");
			    choice = Convert.ToInt32(Console.ReadLine());

			    if(choice == 4)
				    break;

			    switch( choice )
			    {
			     case 1:
				    Console.Write("Enter the key to be inserted : ");
				    x = Convert.ToInt32(Console.ReadLine());
				    tree.Insert(x);
				    break;
			     case 2:
				    Console.Write("Enter the key to be deleted : ");
				    x = Convert.ToInt32(Console.ReadLine());
				    tree.Delete(x);
				    break;
			     case 3:
				    tree.Inorder();
				    break;
			    }
		    }
        }
    }
}
