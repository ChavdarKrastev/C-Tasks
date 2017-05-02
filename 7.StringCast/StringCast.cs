using System;


namespace _7.StringCast
{
    class StringCast
    {
        static void Main(string[] args)
        {
            String a = "Hello";
            String b = "World";
            object HelloW = (a + b);
            String third = HelloW.ToString();
            Console.WriteLine(third);

        }
    }
}
