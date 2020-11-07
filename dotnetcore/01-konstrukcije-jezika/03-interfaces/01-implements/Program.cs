
using System;

namespace RS2.InterfaceImplementation
{
    public interface IControl
    {
        void Paint();
    }

    public interface ISurface
    {
        void Paint();
    }
    
    public class SampleClass : IControl, ISurface
    {
        // Both ISurface.Paint and IControl.Paint call this method.
        public void Paint()
        {
            Console.WriteLine("Paint method in SampleClass");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            SampleClass sample = new SampleClass();
            IControl control = sample;
            ISurface surface = sample;

            // The following lines all call the same method.
            sample.Paint();
            control.Paint();
            surface.Paint();
            // Output:
            // Paint method in SampleClass
            // Paint method in SampleClass
            // Paint method in SampleClass
        }
    }
}
