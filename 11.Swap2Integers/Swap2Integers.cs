using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Swap2Integers
{
    class Swap2Integers
    {
        static void Main(string[] args)
        {
            byte a;
            byte b;
            byte temp = 0;

            Console.WriteLine("Enter first num:");
            a = byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter second num:");
            b = byte.Parse(Console.ReadLine());

            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After swapping first num gets value of {0}, and second num gets value of {1}",a,b);
        }
    }
}
