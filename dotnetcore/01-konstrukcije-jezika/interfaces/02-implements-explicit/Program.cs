namespace RS2.ImplementsExplicit
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
        void IControl.Paint()
        {
            System.Console.WriteLine("IControl.Paint");
        }

        void ISurface.Paint()
        {
            System.Console.WriteLine("ISurface.Paint");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            SampleClass sample = new SampleClass();
            IControl control = sample;
            ISurface surface = sample;

            control.Paint();
            surface.Paint();
        }
        // Output:
        // IControl.Paint
        // ISurface.Paint
    }
}
