using System;

namespace HelloConsoleProperties
{
    internal class Poruka
    {
        public string Sadrzaj
        {
            get;
            set;
        }

        public void PrikazNaKonzolu()
        {
            Console.WriteLine(Sadrzaj);
        }
    }
}