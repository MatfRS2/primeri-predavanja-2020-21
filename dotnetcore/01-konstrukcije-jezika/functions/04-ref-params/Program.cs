﻿using System;

namespace RS2.RefParams
{
    class Program
    {

        // Parameters passed by value 
        static void DodajVrednost(int x)
        {
            x += 10;
        }

        // Parameters passed by ref 
        static void OduzmiVrednost(ref int y)
        {
            y -= 5;
        }

        static void Main(string[] args)
        {

            // Initialize a and b 
            int a = 10, b = 12;

            // Display initial values 
            Console.WriteLine("Vrednost promenljive {0} je {1}", nameof(a), a);
            Console.WriteLine("Vrednost promenljive {0} je {1}", nameof(b), b);
            Console.WriteLine();

            DodajVrednost(a);
            Console.WriteLine("Vrednost promenljive {0} " +
                "nakon izvrsenog dodavanja je {1}", nameof(a), a);
            Console.WriteLine();

            OduzmiVrednost(ref b);
            Console.WriteLine("Vrednost promenljive {0} " +
                "nakon izvrsenog oduzimanja je {1}", nameof(b), b);
            Console.WriteLine();
        }

    }
}