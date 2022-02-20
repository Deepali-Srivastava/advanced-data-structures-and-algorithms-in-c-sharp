using System;

namespace ExpressionTreeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            ExpressionTree etree = new ExpressionTree();
            String postfix = "54+12*3*-";

            etree.BuildTree(postfix);
            etree.Display();

            Console.Write("Prefix : ");
            etree.Prefix();

            Console.Write("Postfix : ");
            etree.Postfix();

            Console.Write("Infix : ");
            etree.ParenthesizedInfix();
            
                
            Console.WriteLine("Value : " + etree.Evaluate() );
        }
    }
}
