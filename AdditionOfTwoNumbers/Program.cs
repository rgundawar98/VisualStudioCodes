using System;
using System.Runtime.Intrinsics.Arm;

namespace AdditionOfTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Calculator calculator= new Calculator();
            Console.WriteLine("please enter 1st number");
            int first=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter second number");
            int second=Convert.ToInt32(Console.ReadLine());
            calculator.Addition(first, second);
            Console.ReadLine();
        }
    }
}
