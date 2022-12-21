using System;
using ReadWrite;

namespace Rezolvari
{
    class Prob_9
    {
        /// <summary> Roteste elementele unui vector cu k pozitii spre stanga, apoi afiseaza vectorul modificat </summary>
        public static void Driver()
        {
            int n = Read.Numar("N");
            int[] v = Read.Vector("", n);
            int k = Read.Numar("K");

            Console.Write($"{Environment.NewLine}Vectorul modificat dupa {k} rotiri: ");
            Write.Vector(RotateK(n, v, k));
        }

        // TODO: more efficient?
        /// <summary> Roteste elementele unui vector cu k pozitii spre stanga </summary>
        /// <param name="n"> Numarul de elemente din vector </param>
        /// <param name="v"> Vectorul de numere intregi </param>
        /// <param name="k"> Numarul de pozitii cu care trebuie rotit vectorul la stanga </param>
        /// <returns> Vectorul modificat dupa rotire </returns>
        static int[] RotateK(int n, int[] v, int k)
        {
            for (int i = 1; i <= k; i++)
                v = Prob_8.Rotate(n, v);

            return v;
        }
    }
}