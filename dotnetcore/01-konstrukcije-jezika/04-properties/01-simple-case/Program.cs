
using System;

namespace RS2.SimpleProperty
{
    class Program
    {
        static void Main()
        {
            Poruka p = new Poruka();
            Console.WriteLine("Sadrzaj poruke posle kreiranja {0}", p.Sadrzaj);

            p.Sadrzaj = "Miki Maus";
            Console.WriteLine("Sadrzaj poruke posle postavljanja {0}", p.Sadrzaj);
            Console.Write("Alternativni prikaz sadrzaja poruke ");
            p.PrikazNaKonzolu();

        }

    }
}

