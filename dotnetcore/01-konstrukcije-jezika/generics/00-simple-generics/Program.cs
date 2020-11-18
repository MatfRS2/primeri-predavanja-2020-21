using System;

namespace RS2.SimpleGeneric
{
    public class SkladistePodataka<T>
    {
        private T[] podaci = new T[10];

        public void DodajIliAzuriraj(int index, T item)
        {
            if (index >= 0 && index < 10)
                podaci[index] = item;
        }

        public T Podatak(int index)
        {
            if (index >= 0 && index < 10)
                return podaci[index];
            else
                return default(T);
        }

        public void PrikaziNaKonzoli()
        {
            foreach (T elem in podaci)
                Console.WriteLine(elem);
        }
    }

    public class Program
    {
        static void Main()
        {
            SkladistePodataka<string> cities = new SkladistePodataka<string>();
            cities.DodajIliAzuriraj(0, "Bombaj");
            cities.DodajIliAzuriraj(1, "Cikago");
            cities.DodajIliAzuriraj(2, "London");
            cities.DodajIliAzuriraj(7, "Beograd");
            cities.PrikaziNaKonzoli();
            Console.WriteLine("---");

            SkladistePodataka<int> empIds = new SkladistePodataka<int>();
            empIds.DodajIliAzuriraj(0, 50);
            empIds.DodajIliAzuriraj(1, 65);
            empIds.DodajIliAzuriraj(2, 89);
            empIds.PrikaziNaKonzoli();
            Console.WriteLine();
        }
    }
}

/* Izlaz dobijen prilikom izvrsavanja programa:
Bombaj
Cikago
London




Beograd


---
50
65
89
0
0
0
0
0
0
0

 */
