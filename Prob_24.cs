using System;
using ReadWrite;

namespace Rezolvari
{
    class Prob_24
    {
        /// <summary> Determina si afiseaza intersectia, reuniunea si diferentele a doua multimi de valori binare </summary>
        public static void Driver()
        {
            int n1 = Read.Numar("Lungimea vectorului V1, de valori binare (cel mai mare element zecimal)");
            bool[] v1 = Read.VectorBool("V1, de valori binare", n1);

            int n2 = Read.Numar("Lungimea vectorului V2, de valori binare (cel mai mare element zecimal)");
            bool[] v2 = Read.VectorBool("V2, de valori binare", n2);

            Console.WriteLine();

            bool[] intersectie = Intersectie(n1, n2, v1, v2);
            Console.Write("Intersectia celor doua multimi: ");
            Write.Vector(intersectie, "binar");
            Write.Vector(intersectie, "zecimal");
            Console.WriteLine();

            bool[] reuniune = Reuniune(n1, n2, v1, v2);
            Console.Write("Reuniunea celor doua multimi: ");
            Write.Vector(reuniune, "binar");
            Write.Vector(reuniune, "zecimal");
            Console.WriteLine();

            bool[] diferenta1 = Diferenta(n1, n2, v1, v2);
            Console.Write("Diferenta V1 - V2: ");
            Write.Vector(diferenta1, "binar");
            Write.Vector(diferenta1, "zecimal");
            Console.WriteLine();

            bool[] diferenta2 = Diferenta(n2, n1, v2, v1);
            Console.Write("Diferenta V2 - V1: ");
            Write.Vector(diferenta2, "binar");
            Write.Vector(diferenta2, "zecimal");
            Console.WriteLine();
        }

        /// <summary> Determina intersectia a doua multimi de valori binare </summary>
        /// <param name="n1"> Numarul de elemente din prima multime (cel mai mare element zecimal) </param>
        /// <param name="n2"> Numarul de elemente din a doua multime (cel mai mare element zecimal) </param>
        /// <param name="v1"> Prima multime de valori binare </param>
        /// <param name="v2"> A doua multime de valori binare </param>
        /// <returns> Intersectia celor doua multimi de valori binare </returns>
        static bool[] Intersectie(int n1, int n2, bool[] v1, bool[] v2)
        {
            bool[] intersectie = new bool [n1];

            for (int i = 0; i < n1 && i < n2; i++)
                intersectie[i] = v1[i] && v2[i];

            return intersectie;
        }

        /// <summary> Determina intersectia a doua multimi de valori binare </summary>
        /// <param name="n1"> Numarul de elemente din prima multime (cel mai mare element zecimal) </param>
        /// <param name="n2"> Numarul de elemente din a doua multime (cel mai mare element zecimal) </param>
        /// <param name="v1"> Prima multime de valori binare </param>
        /// <param name="v2"> A doua multime de valori binare </param>
        /// <returns> Intersectia celor doua multimi de valori binare </returns>
        static bool[] Reuniune(int n1, int n2, bool[] v1, bool[] v2)
        {
            bool[] reuniune = new bool [n1 + n2];

            int i = 0;
            while (i < n1 && i < n2)
            {
                reuniune[i] = v1[i] || v2[i];
                i++;
            }
            while (i < n1)
                reuniune[i] = v1[i++];
            while (i < n2)
                reuniune[i] = v2[i++];

            return reuniune;
        }

        /// <summary> Determina diferenta dintre doua multimi de valori binare </summary>
        /// <param name="n1"> Numarul de elemente din prima multime (cea mai mare valoare zecimala) </param>
        /// <param name="n2"> Numarul de elemente din a doua multime (cea mai mare valoare zecimala) </param>
        /// <param name="v1"> Prima multime de valori binare </param>
        /// <param name="v2"> A doua multime de valori binare </param>
        /// <returns> Diferenta dintre cele doua multimi de valori binare </returns>
        static bool[] Diferenta(int n1, int n2, bool[] v1, bool[] v2)
        {
            bool[] diferenta = new bool [n1];

            int i = 0;
            while (i < n1 && i < n2)
            {
                diferenta[i] = v1[i] && !v2[i];
                i++;
            }
            while (i < n1)
                diferenta[i] = v1[i++];

            return diferenta;
        }
    }
}