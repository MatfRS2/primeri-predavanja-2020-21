
using System;

namespace RS2.DelegatesAsParameters
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

    public class Program
    {
        public static void InvokeDelegate(MyDelegate del) // MyDelegate type parameter
        {
            del("Hello World");
        }
        static void Main(string[] args)
        {
            MyDelegate del = ClassA.MethodA;
            InvokeDelegate(del);

            del = ClassB.MethodB;
            InvokeDelegate(del);
        }

     }

}

