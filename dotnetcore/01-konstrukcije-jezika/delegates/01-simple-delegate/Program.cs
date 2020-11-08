
using System;

namespace RS2.SimpleDelegate
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

    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate del = ClassA.MethodA;
            del("Hello World");

            del = ClassB.MethodB;
            del("Hello World");
        }
    }

}

