using System;
using ReadWrite;

namespace Rezolvari
{
    class Prob_22
    {
        /// <summary> Determina si afiseaza intersectia, reuniunea si diferentele a doua multimi </summary>
        public static void Driver()
        {
            int n1 = Read.Numar("N1");
            int[] v1 = Read.Vector("V1", n1);

            int n2 = Read.Numar("N2");
            int[] v2 = Read.Vector("V2", n2);

            Console.WriteLine();

            // TODO: Sort v1 ascending
            // TODO: Sort v2 ascending

            int[] intersectie = Prob_23.Intersectie(n1, n2, v1, v2);
            Console.Write("Intersectia celor doua multimi: ");
            Write.Vector(intersectie, 1, intersectie[0]);

            int[] reuniune = Prob_23.Reuniune(n1, n2, v1, v2);
            Console.Write("Reuniunea celor doua multimi: ");
            Write.Vector(reuniune, 1, reuniune[0]);

            int[] diferenta1 = Prob_23.Diferenta(n1, n2, v1, v2);
            Console.Write("Diferenta V1 - V2: ");
            Write.Vector(diferenta1, 1, diferenta1[0]);

            int[] diferenta2 = Prob_23.Diferenta(n2, n1, v2, v1);
            Console.Write("Diferenta V2 - V1: ");
            Write.Vector(diferenta2, 1, diferenta2[0]);
        }
    }
}