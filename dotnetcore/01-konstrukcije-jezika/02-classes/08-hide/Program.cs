
using System;

namespace HelloConsole
{
    // roditeljska klasa 
    public class Roditelj
    {
        public void PrikaziSe()
        {
            Console.WriteLine("Ja sam primerak klase Roditelj.");
        }
    }

    // izvedena klasa 
    public class Potomak : Roditelj
    {
        // virtual method 
        public new void PrikaziSe()
        {
            Console.WriteLine("Ja sam primerak klase Potomak.");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Roditelj obj;

            obj = new Roditelj();
            obj.PrikaziSe();

            obj = new Potomak();
            obj.PrikaziSe();

            Potomak obj2 = new Potomak();
            obj2.PrikaziSe();
        }

    }
}
