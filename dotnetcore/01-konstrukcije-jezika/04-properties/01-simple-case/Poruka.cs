using System;

namespace HelloConsoleProperties
{
    internal class Poruka
    {
        private string sadrzaj = "XXX";

        public string Sadrzaj
        {
            get { return sadrzaj; }
            set { sadrzaj = value; }
        }

        public void PrikazNaKonzolu()
        {
            Console.WriteLine(sadrzaj);
        }
    }
}