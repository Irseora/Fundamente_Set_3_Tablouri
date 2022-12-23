using System;
using ReadWrite;

namespace Rezolvari
{
    class Prob_7
    {
        /// <summary> Inverseaza ordinea elementelor dintr-un vector dat, apoi afiseaza vectorul modificat </summary>
        public static void Driver()
        {
            int n = Read.Numar("N");
            int[] v = Read.Vector("", n);

            Console.Write($"{Environment.NewLine}Vectorul inversat: ");
            Write.Vector(Reverse(n, v));
        }

        /// <summary> Inverseaza ordinea elementelor dintr-un tablou dat </summary>
        /// <param name="n"> Lungimea tabloului </param>
        /// <param name="v"> Tabloul </param>
        /// <returns> Tabloul modificat dupa inserare </returns>
        public static int[] Reverse(int n, int[] v)
        {
            for (int i = 0; i < n / 2; i++)
            {
                if (v[i] != v[n - i - 1])
                {
                    int aux = v[i];
                    v[i] = v[n - i - 1];
                    v[n - i - 1] = aux;
                }
            }

            return v;
        }
    }
}