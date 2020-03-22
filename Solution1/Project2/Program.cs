using System;

namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Push any button!\n");
            string pushButton = Console.ReadLine();
            char symbolButtons = Convert.ToChar(pushButton);

            switch (symbolButtons)
            {
                case ('w'):
                    Console.WriteLine("Move up!");
                    break;
                case ('a'):
                    Console.WriteLine("Move left!"); 
                    break;
                case ('d'):
                    Console.WriteLine("Move right");
                    break;
                case ('s'):
                    Console.WriteLine("Move down");
                    break;
                default:
                    Console.WriteLine("Error");
                    break; 
            }
        }
    }
}
