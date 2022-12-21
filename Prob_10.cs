using System;
using ReadWrite;

namespace Rezolvari
{
    class Prob_10
    {
        /// <summary> Determina si afiseaza pozitia unui element intr-un vector prin cautare binara </summary>
        public static void Driver()
        {
            int n = Read.Numar("N");
            int[] v = Read.Vector("", n);
            int k = Read.Numar("K");

            Console.WriteLine($"{Environment.NewLine}Pozitia elementului {k} in vector: {BinSearch(n, v, k)}");
        }

        /// <summary> Cauta un element intr-un tablou sortat crescator folosind metoda cautarii binare </summary>
        /// <param name="n"> Numarul de elemente din tablou </param>
        /// <param name="v"> Tabloul </param>
        /// <param name="k"> Elementul cautat </param>
        /// <returns> Pozitia elementului daca se afla in tablou, altfel -1 </returns>
        public static int BinSearch(int n, int[] v, int k)
        {
            int limJos = 0, limSus = n - 1;

            while (limJos < limSus)
            {
                int mijloc = (limJos + limSus) / 2;

                // Daca elementul cautat este mai mare decat elementul din mijlocul tabloului,
                if (v[mijloc] < k)          // cauta mai departe doar in partea dreapta
                    limJos = mijloc + 1;
                // Daca elementul cautat este mai mic decat elementul din mijlocul tabloului,
                else if (v[mijloc] > k)     // cauta mai departe doar in partea stanga
                    limSus = mijloc;
                else if (v[mijloc] == k)
                    return mijloc;
            }

            // Daca a iesit din ciclu fara sa gaseasca elementul => el nu se afla in tablou
            return -1;
        }
    }
}