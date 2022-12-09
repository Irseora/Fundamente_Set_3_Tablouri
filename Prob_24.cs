using System;
using ReadWrite;

namespace Rezolvari
{
    class Prob_24
    {
        public static void Driver()
        {
            int n1 = Read.Numar("Lungimea vectorului v1, de valori binare");
            bool[] v1 = Read.VectorBool("v1, de valori binare", n1);

            int n2 = Read.Numar("Lungimea vectorului v2, de valori binare");
            bool[] v2 = Read.VectorBool("v2, de valori binare", n2);

            Console.WriteLine();

            // Intersectie
            // Reuniune
            // v1 - v2
            // v2 - v1
        }
    }
}