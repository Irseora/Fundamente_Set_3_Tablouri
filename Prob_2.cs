using System;
using ReadWrite;

namespace Rezolvari
{
    class Prob_2
    {
        /// <summary> Determina si afiseaza pozitia unui element intr-un vector </summary>
        public static void Driver()
        {
            int n = Read.Numar("N");
            int[] v = Read.Vector("", n);
            int k = Read.Numar("K");

            Console.WriteLine($"{Environment.NewLine}Pozitia lui {k} in vector: {Search(n,v,k)}");
        }

        /// <summary> Determina pozitia unui element intr-un tablou de numere intregi dat </summary>
        /// <param name="n"> Numarul de elemente din tablou </param>
        /// <param name="v"> Tabloul de numere intregi </param>
        /// <param name="k"> Elementul cautat </param>
        /// <returns> Pozitia elementului cautat in tablou, sau -1 daca el nu apare </returns>
        static int Search(int n, int[] v, int k)
        {
            for (int i = 0; i < n; i++)
                if (v[i] == k)
                    return i;

            return -1;
        }
    }
}