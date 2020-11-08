
using System;

namespace RS2.GenericDelegate
{
    public delegate T Add<T>(T param1, T param2); // generic delegate

    class Program
    {
        public static int Sum(int val1, int val2)
        {
            return val1 + val2;
        }

        public static string Concat(string str1, string str2)
        {
            return str1 + str2;
        }

        static void Main(string[] args)
        {
            Add<int> sum = Sum;
            Console.WriteLine(sum(10, 20));

            Add<string> con = Concat;
            Console.WriteLine(con("Miki ", "Maus"));
        }

     }
}

