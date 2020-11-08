
using System;

namespace RS2.SimpleIndexer
{
    class Niske
    {
        private string[] skladiste;

        public Niske()
        {
            skladiste = new string[10];
        }

        public Niske(int dimenzija)
        {
            skladiste = new string[dimenzija];
        }

        public string this[int index]
        {
            get
            {
                if (index < 0 || index >= skladiste.Length)
                    throw new IndexOutOfRangeException("Index out of range");

                return skladiste[index];
            }

            set
            {
                if (index < 0 || index >= skladiste.Length)
                    throw new IndexOutOfRangeException("Index out of range");

                skladiste[index] = value;
            }
        }
        public int Dimenzija
        {
            get { return skladiste.Length; }
        }
    }
}
