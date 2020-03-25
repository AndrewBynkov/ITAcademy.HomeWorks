using System;
using System.Linq;

namespace HW._06
{
    class Program
    {
        static void Task_1()
        {
            Console.WriteLine("Task_1"+"\n");
           

            int[] arr1 = new int[6];
            int[] arr2 = new int[6];
            int[] arr3 = new int[6];
            Random rand = new Random();

            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = rand.Next(6);  
            }
            Console.Write("1) Array contents is: ");
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr1[i]+ " ");
            }
            Console.WriteLine("\n");

            Console.WriteLine("2) Enter array values");
            for (int j = 0; j < arr2.Length; j++)
            {
                arr2[j] = int.Parse(Console.ReadLine());
            }
            Console.Write("2) Array contents is: ");
            for (int j = 0; j < arr2.Length; j++)
                Console.Write(arr2[j] + " ");
            Console.WriteLine("\n");

            Console.Write("3) Sum of Arrays: ");
            for (int k = 0; k < arr3.Length; k++)
            {
                arr3[k] = arr1[k] + arr2[k];
            }
            for (int k = 0; k < arr3.Length; k++)
            {
                Console.Write(arr3[k] + " ");
            }
            Console.WriteLine("\n"+"\n");
        }

        static void Task_2()
        {
            Console.WriteLine("Task_2" + "\n");

            int[] arr1 = new int[6];
            Console.Write("1) Array from the keyboards -1: ");

            for (int i =0; i < arr1.Length-1; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr1[i] + " ");
            }
            Console.WriteLine("\n");

            Console.WriteLine($"2) Position #2 in array:  {arr1[2]}");

            for (int j = arr1.Length - 1; j > 2; j--) 
            {
                arr1[j] = arr1[j - 1]; 
            }
            arr1[2] = 565;
            Console.WriteLine("\n");
            for (int j = 0; j < arr1.Length; j++)
            {
                Console.Write(arr1[j] + " ");
            }
        }

       static void Task_3()
        {
            Console.WriteLine("Task_3" + "\n");

            int[] arr1 = new int[10];
            int[] arr2 = new int[10];
            

            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = i;   
            }
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr1[i]);
            }
            Console.WriteLine("\n");

            for (int j = arr1.Length-1; j >= 0; j--) 
            {
                arr1[j] = j;
                Console.Write(arr1[j] = j);
            }
            Console.WriteLine("\n");
            Console.Write("REVERSE ARRAY \n");
            for (int k = 0; k < arr2.Length; k++)
            {
                arr2[k] = k;
                
                Console.Write(arr2[k]);
            }
            arr2.Reverse();
            Console.Write(arr2);
            for (int k = 0; k < arr2.Length; k++)
            {
                arr2.Reverse();
                Console.Write(arr2);
            }







            }   

        static void Main(string[] args)
        {
            Task_1();
            Task_2();
            Task_3();

        }
    }
}
