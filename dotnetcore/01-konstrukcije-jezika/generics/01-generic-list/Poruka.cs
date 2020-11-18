using System;

namespace RS2.GenericList
{
    internal class Poruka
    {
        private byte brojPonavljanja;

        public byte BrojPonavljanja{
            get {
                return brojPonavljanja;
            }
            set
            {
                brojPonavljanja = value;
            }
        }

        private string sadrzaj;

        public string Sadrzaj {
            get
            {
                return sadrzaj;
            }
            set
            {
                sadrzaj = value;
            }
        }

        public void PrikazNaKonzolu()
        {
            Console.WriteLine("---");
            for(int i=0; i<BrojPonavljanja; i++)
                Console.WriteLine(Sadrzaj);
            Console.WriteLine("---");
        }
    }
}