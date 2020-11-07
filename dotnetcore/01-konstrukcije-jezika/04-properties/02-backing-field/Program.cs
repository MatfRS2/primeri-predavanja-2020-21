
using System;

namespace RS2.PropertyBackingField
{
    class Program
    {
        static void Main()
        {
            Karakter lik = new Karakter("Paja", "Patak");
            Console.WriteLine("lik - ime: {0}", lik.Ime);
            Console.WriteLine("lik - prezime: {0}", lik.Prezime);
            Console.WriteLine("lik - puno ime: {0}", lik.PunoIme);
            Console.WriteLine();

            lik.Ime = "Baja";
            Console.WriteLine("lik - ime: {0}", lik.Ime);
            Console.WriteLine("lik - prezime: {0}", lik.Prezime);
            Console.WriteLine("lik - puno ime: {0}", lik.PunoIme);
            Console.WriteLine();

            lik.PunoIme = "Felipe Kaetano Lopez Martinez Gonzales";
            Console.WriteLine("lik - ime: {0}", lik.Ime);
            Console.WriteLine("lik - prezime: {0}", lik.Prezime);
            Console.WriteLine("lik - puno ime: {0}", lik.PunoIme);
            Console.WriteLine();

            lik.PunoIme = "Supermen";
            Console.WriteLine("lik - ime: {0}", lik.Ime);
            Console.WriteLine("lik - prezime: {0}", lik.Prezime);
            Console.WriteLine("lik - puno ime: {0}", lik.PunoIme);
            Console.WriteLine();
        }
    }

}

