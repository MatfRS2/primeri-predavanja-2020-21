
using System;

namespace HelloConsoleProperties
{
    public class Program
    {
        static void Main(string[] args)
        {
            Poruka p = new Poruka {
                BrojPonavljanja = 2, 
                Sadrzaj = "YYY"};
            p.PrikazNaKonzolu();
            p.BrojPonavljanja = 3;
            p.Sadrzaj = "Miki Maus";
            p.PrikazNaKonzolu();
        }

    }

}
