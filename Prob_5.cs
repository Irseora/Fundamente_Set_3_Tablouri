using System;
using ReadWrite;

namespace Rezolvari
{
    class Prob_5
    {
        /// <summary> Insereaza un element intr-un vector, pe o pozitie data, apoi afiseaza vectorul modificat </summary>
        public static void Driver()
        {
            int n = Read.Numar("N");
            int[] v = Read.Vector("", n);
            int e = Read.Numar("E");
            int k = Read.Numar("K", 0, n-1);
            Console.WriteLine();

            Console.Write($"Vectorul modificat dupa inserare: ");
            Write.Vector(InsertElement(n, v, e, k));
        }

        /// <summary> Insereaza un element intr-un tablou, pe o pozitie data </summary>
        /// <param name="n"> Numarul de elemente din tablou </param>
        /// <param name="v"> Tabloul </param>
        /// <param name="e"> Elementul care va fi inserat </param>
        /// <param name="k"> Pozitia pe care se insereaza </param>
        /// <returns> Tabloul modificat dupa inserare </returns>
        static int[] InsertElement(int n, int[] v, int e, int k)
        {
            int[] aux = new int[n + 1];

            for (int i = 0; i < k; i++)
                aux[i] = v[i];
            
            aux[k] = e;

            for (int i = k; i < n; i++)
                aux[i + 1] = v[i];

            return aux;
        }
    }
}