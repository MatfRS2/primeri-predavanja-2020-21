
using System;

namespace RS2.SimpleEnum
{
    enum Boja
    {
        Crvena,
        Zelena = 10,
        Plava
    }

    class Test
    {
        static string TekstualniOpis(Boja c)
        {
            switch (c)
            {
                case Boja.Crvena:
                    return String.Format("Crvena = {0}", (int)c);

                case Boja.Zelena:
                    return String.Format("Zelena = {0}", (int)c);

                case Boja.Plava:
                    return String.Format("Plava = {0}", (int)c);

                default:
                    return "Nepostojeca boja";
            }
        }

        static void Main()
        {
            Console.WriteLine(TekstualniOpis(Boja.Crvena));
            Console.WriteLine(TekstualniOpis(Boja.Zelena));
            Console.WriteLine(TekstualniOpis(Boja.Plava));
        }

    }
}

/* Izlaz dobijen prilikom izvrsavanja programa:
Crvena = 0
Zelena = 10
Plava = 11
 */

