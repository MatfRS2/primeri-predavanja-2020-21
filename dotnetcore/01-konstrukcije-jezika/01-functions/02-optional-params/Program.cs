
using System;
using System.Text;

namespace OptionalParams
{
    class Program
    {
        static void prikazOdDo( int pocev = 40, int zakljucno = 42)
        {
            int i = pocev;
            while (i <= zakljucno)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        static void StampajViseLinija(int z=2)
        {
            for (int i = 0; i < z; i++)
                Console.WriteLine("-- " + i + " --");
        }

        static int BrojSlova(string s)
        {
            int ret = 0;
            foreach (char ch in s)
            {
                if (ch >= 'a' && ch <= 'z')
                    ret++;
                if (ch >= 'A' && ch <= 'Z')
                    ret++;
            }
            return ret;
        }

        static string Nalepi(string s, int brojPonavljanja = 2)
        {
            if (brojPonavljanja <= 1)
                return s;
            StringBuilder graditelj = new StringBuilder(s);
            for(int i = 1; i<brojPonavljanja; i++)
            {
                graditelj.Append(s);
            }
            return graditelj.ToString();
        }

        static public void Prikaz2(string fname = "John", int age = 20, 
            string lname = "Doe") 
        { 
            Console.WriteLine("First name: {0}", fname); 
            Console.WriteLine("Last name: {0}", lname); 
            Console.WriteLine("Age: {0}", age); 
        } 

        static void Main(string[] args)
        {
            prikazOdDo(35, 40);
            prikazOdDo();
            Console.WriteLine();

            StampajViseLinija(3);
            StampajViseLinija();
            Console.WriteLine();

            int z = BrojSlova("123 Miki Maus 123");
            Console.WriteLine(z);
            Console.WriteLine(Nalepi("Miki Maus ", 4));
            Console.WriteLine(Nalepi("Paja Patak "));
            Console.WriteLine();

            Prikaz2("Baja", 90, "Patak");
            Prikaz2("Miki", 95);
            Prikaz2("Baja");
            Prikaz2();
            Prikaz2( lname:"Patak", fname:"Paja");
            Console.WriteLine();
        }

    }
}
