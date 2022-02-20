using System;

namespace BtreeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Btree tree = new Btree();
	        int key,choice;
                        
            while(true)
	        {
		        Console.WriteLine("1.Search");
                Console.WriteLine("2.Insert");
                Console.WriteLine("3.Delete");
                Console.WriteLine("4.Display");
                Console.WriteLine("5.Inorder traversal");
                Console.WriteLine("6.Quit");

		        Console.Write("Enter your choice : ");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 6)
                    break;

		        switch(choice)
		        {
			        case 1:
			    	    Console.WriteLine("Enter the key to be searched : ");
                        key = Convert.ToInt32(Console.ReadLine());

                        if( tree.Search(key)==true)
                            Console.WriteLine("Key present");
                        else
                            Console.WriteLine("Key not present");
                        break;
			        case 2:
				        Console.Write("Enter the key to be inserted : ");
                        key = Convert.ToInt32(Console.ReadLine());
				        tree.Insert(key);
				        break;
			        case 3:
				        Console.WriteLine("Enter the key to be deleted : ");
                        key = Convert.ToInt32(Console.ReadLine());
				        tree.Delete(key);
				        break;
			        case 4:
				        Console.WriteLine("Btree is :\n\n");
				        tree.Display();
				        Console.WriteLine("\n\n");
				        break;
			        case 5:
				        tree.Inorder();
				        Console.WriteLine("\n\n");
				        break;
			         default:
				        Console.WriteLine("Wrong choice\n");
        				break;
		        }
	        }
        }
    }
}
