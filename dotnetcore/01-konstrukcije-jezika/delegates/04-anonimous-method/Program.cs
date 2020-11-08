
using System;

namespace RS2.AnonimousMethod
{
    public delegate void Print(int value);

    public class Program
    {
        // ovde je delegat parametar metoda
        public static void PrintHelperMethod(Print printDel, int val)
        {
            val += 10;
            printDel(val);
        }

        static void Main(string[] args)
        {
            int i = 10;
            // napravljen je anonimni metod
            Print prnt = delegate (int val)
            {
                val += i;
                Console.WriteLine("Anonymous method: {0}", val);
            };
            // poyiva se prethodno napravljeni anonimni metod
            prnt(100);
            Console.WriteLine();

            // prilikom poziva metoda u kom je parametar delegat, argument moze biti anonimni metod
            PrintHelperMethod(delegate (int val) { 
                Console.WriteLine("Anonymous method: {0}", val); 
            }, 100);
            Console.WriteLine();
        }
    }

}

