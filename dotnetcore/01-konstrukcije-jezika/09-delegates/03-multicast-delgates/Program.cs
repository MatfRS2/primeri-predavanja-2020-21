
using System;

namespace RS2.MulticastDelegates
{
    //declaring a delegate
    public delegate void MyDelegate(string msg);

    public class ClassA
    {
        public static void MethodA(string message)
        {
            Console.WriteLine("Called ClassA.MethodA() with parameter: " + message);
            Console.WriteLine(message.ToUpper());
        }
    }

    public class ClassB
    {
        public static void MethodB(string message)
        {
            Console.WriteLine("Called ClassB.MethodB() with parameter: " + message);
            var n = message.Length;
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < i; j++)
                    Console.Write(" ");
                Console.WriteLine(message[i]);
            }
        }
    }

    public class Program
    {
        public static void InvokeDelegate(MyDelegate del) // MyDelegate type parameter
        {
            del("Hello World");
        }
        static void Main(string[] args)
        {
            MyDelegate del1 = ClassA.MethodA;
            MyDelegate del2 = ClassB.MethodB;

            MyDelegate del = del1;
            del += del2;
            del("Miki Maus");
            Console.WriteLine();

            del -= del1;
            del("Dusko Dugousko");
            Console.WriteLine();

            del -= del2;
            del += del1;
            del("Patak Daca");
            Console.WriteLine();
        }

    }

}

