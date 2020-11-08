using System;

namespace RS2.GenericList
{
    internal class Poruka
    {
        private byte brojPonavljanja;
        private string sadrzaj;

        public byte BrojPonavljanja{
            get {
                return brojPonavljanja;
            }
            set
            {
                brojPonavljanja = value;
            }
        }
        
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