using System;

namespace HW._06_Additional_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tests!");

            long[] array = new long[10];
            Random rand = new Random();

            for (long i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next();
            }
            for (long i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
            Console.WriteLine();

            for (long j = array.Length-1; j > 0; j--)
            {
                if (j > array.Length || j < array.Length) 
                {
                    break;
                }
                array[j] = j;
            }
            Array.Reverse(array);
            for (long j = 0; j < array.Length; j++)
            {
                Console.Write(array[j]);
            }


        }
    }
}
