
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
        }
    }

    public class ClassB
    {
        public static void MethodB(string message)
        {
            Console.WriteLine("Called ClassB.MethodB() with parameter: " + message);
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

