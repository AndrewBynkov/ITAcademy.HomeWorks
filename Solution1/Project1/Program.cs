using System;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("English alphabet!\n");

            for (char i = '\u005A'; i >= '\u0041'; i--)
                Console.WriteLine(i);
        }
    }
}
