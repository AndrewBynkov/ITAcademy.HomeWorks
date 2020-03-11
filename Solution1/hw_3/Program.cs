using System;

namespace HW._03
{
    class Program
    {
        static void Main(string[] args)
        {
            //expliced
            Console.WriteLine("Explicit conversions(casts):");
            double num1 = 78.5;
            int num2 = (int)num1;

            double num3 = 65648.363212;
            decimal num4 = (decimal)num3;

            int num5 = 257;
            byte num6 = (byte)num5;

            Console.WriteLine($"Double convert to int = {num2}" +
                $"\nDouble convert to decimal = {num4}" +
                $"\nInt convert to byte = {num6}");
            Console.WriteLine();

            //impliced
            Console.WriteLine("Implicit conversions:");
            byte number1 = 255;
            int number2 = number1;

            float number3 = 323445.4F;
            double number4 = number3;

            int number5 = 36645;
            long number6 = number5;

            Console.WriteLine($"Byte convert to int = {number2}" +
                $"\nFloat convert to double = {number4}" +
                $"\nInt convert to long = {number6}");

            Console.WriteLine();

            //Boxing & unboxing
            Console.WriteLine("Boxing & unboxing");

            //int -> ushort
            int box = 10000;
            object boxing = box;
            ushort unboxing = (UInt16)(int)boxing;

            //bool -> byte
            bool change = true;
            object lux = change;
            byte newboxing = Convert.ToByte((bool)lux);

            //char -> int
            char inse = (char)9;
            object lucky = inse;
            int newnumber = (int)(char)lucky;

            Console.WriteLine($"Boxing to int & unboxing to ushort = {unboxing}" +
                $"\nBoxing to bool & unboxing to byte = {newboxing}" +
                $"\nBoxing to char & unboxing to int = {newnumber}");
        }
    }
}
