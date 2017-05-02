using System;

namespace _3.CompareFloatNumbers
{
    class CompareFloatNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            float b = float.Parse(Console.ReadLine());
            if ((a - b) < 0.000001 & (a - b) > -0.000001)
                { 
                Console.WriteLine("The first and the second number are equal"); 
                }
                else
                    {
                Console.WriteLine("The first and the second number are NOT equal"); 
                    }
        }
    }
}
