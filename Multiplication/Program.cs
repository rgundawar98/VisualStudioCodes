using System;
using System.Runtime.Intrinsics.Arm;

namespace Multiplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Multiplication mul = new Multiplication();
            Console.WriteLine("please enter first number");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter second number");
            int second = Convert.ToInt32(Console.ReadLine());
            mul.Multiply(first, second);
            Console.ReadLine();
        }
    }


}