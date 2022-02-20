using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExpressionTreeProject
{
    class StackNode
    {
        private Node[] stackArray;
        private int top;

        public StackNode()
        {
            stackArray = new Node[10];
            top = -1;
        }

        public StackNode(int maxSize)
        {
            stackArray = new Node[maxSize];
            top = -1;
        }

        public int Size()
        {
            return top + 1;
        }

        public bool IsEmpty()
        {
            return (top == -1);
        }

        public bool IsFull()
        {
            return (top == stackArray.Length - 1);
        }

        public void Push(Node x)
        {
    	    if( IsFull() )
    	    {
    		    Console.WriteLine("Stack Overflow\n");
    		    return;
    	    }
    	    top = top+1;
    	    stackArray[top] = x;
        }

        public Node Pop()
        {
    	    Node x;
    	    if ( IsEmpty() )
    	    {
    		    Console.WriteLine("Stack Underflow\n");
    		    throw new System.InvalidOperationException();
    	    }
    	    x = stackArray[top];
    	    top = top-1;
    	    return x;
        }

        public Node Peek()
        {
    	    if ( IsEmpty() )
    	    {
    		    Console.WriteLine("Stack Underflow\n");
    		    throw new System.InvalidOperationException();
    	    }
    	    return stackArray[top];
        }

        public void Display()
        {  	
            int i;
    	   	Console.WriteLine("top= " + top);

    	    if ( IsEmpty() )
    	    {
    		    Console.WriteLine("Stack is empty");
    		    return;
    	    }
            Console.WriteLine("Stack is : ");
    	    for ( i = top; i >= 0; i--)
    	    	Console.WriteLine(stackArray[i] + " ");
    	    Console.WriteLine();
        }
    }
}
