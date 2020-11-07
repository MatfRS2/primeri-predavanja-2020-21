
using System;

namespace RS2.ConversionEnum
{
    enum Color
    {
        Red,
        Green = 10,
        Blue,
        Yellow = 77,
        Purple,
        Black
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine(Color.Purple);
            Console.WriteLine();

            int purple = (int)Color.Purple; // enum to int conversion
            Console.WriteLine(purple);
            Console.WriteLine();

            var color = (Color)10; // int to enum conversion
            Console.WriteLine(color);

        }
        /*  Program output:
            Purple
            
            78

            Green

         */

    }
}

