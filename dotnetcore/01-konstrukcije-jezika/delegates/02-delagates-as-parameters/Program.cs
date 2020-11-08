
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
        // MyDelegate type parameter
        public static void InvokeDelegate(MyDelegate del, string str) 
        {
            del(str);
        }
        static void Main(string[] args)
        {
            MyDelegate del = ClassA.MethodA;
            InvokeDelegate(del, "Zagor");

            del = ClassB.MethodB;
            InvokeDelegate(del, "Veliki Blek");
        }

     }

}

