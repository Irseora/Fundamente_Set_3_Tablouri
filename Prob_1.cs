using System;
using ReadWrite;

namespace Rezolvari
{
    class Prob_1
    {
        /// <summary> Determina si afiseaza suma elementelor unui vector </summary>
        public static void Driver()
        {
            int n = Read.Numar("N");
            int[] v = Read.Vector("", n);

            Console.WriteLine($"{Environment.NewLine}Suma elementelor din vector: {SumaElementelor(n, v)}");
        }

        /// <summary> Determina suma elementelor unui tablou de numere intregi dat </summary>
        /// <param name="n"> Numarul de elemente din tablou </param>
        /// <param name="v"> Tabloul de numere intregi </param>
        /// <returns> Suma elementelor tabloului </returns>
        static int SumaElementelor(int n, int[] v)
        {
            int sumElemente = 0;

            for (int i = 0; i < n; i++)
                sumElemente += v[i];

            return sumElemente;
        }
    }
}