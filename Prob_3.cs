using System;
using ReadWrite;

namespace Rezolvari
{
    class Prob_3
    {
        // <summary> Determina si afiseaza pozitiile celui mai mic si celui mai mare element din vector </summary>
        public static void Driver()
        {
            int n = Read.Numar("Lungimea vectorului");
            int[] v = Read.Vector("", n);

            int[] pozitii = PozitiiElementeMinMax(n, v);
            Console.WriteLine($"Pozitia celui mai mic element: {pozitii[0]}");
            Console.WriteLine($"Pozitia celui mai mare element: {pozitii[1]}");
        }

        // TODO: 3n / 2 comparatii
        /// <summary> Determina pozitiile celui mai mic si celui mai mare element din tabloul dat </summary>
        /// <param name="n"> Numarul de elemente din tablou </param>
        /// <param name="v"> Tabloul de numere intregi </param>
        /// <returns> Pozitiile celui mai mic si celui mai mare element, sub forma unui tablou cu 2 elemente: {pozMin, pozMax} </returns>
        static int[] PozitiiElementeMinMax(int n, int[] v)
        {
            int pozMin = 0, pozMax = 0;

            for (int i = 0; i < n; i++)
            {
                if (v[i] < v[pozMin])
                    pozMin = i;
                else if (v[i] > v[pozMax])
                    pozMax = i;
            }
        
            return new int[] { pozMin, pozMax };
        }
    }
}