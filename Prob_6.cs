using System;
using ReadWrite;

namespace Rezolvari
{
    class Prob_6
    {
        /// <summary> Sterge un element de pe o pozitie data dintr-un vector, apoi afiseaza vectorul modificat </summary>
        public static void Driver()
        {
            int n = Read.Numar("N");
            int[] v = Read.Vector("", n);
            int k = Read.Numar("K", 0, n-1);

            Console.Write($"{Environment.NewLine}Vectorul modificat dupa stergere: ");
            Write.Vector(DeleteElement(n, v, k));
        }

        /// <summary> Sterge un element de pe o pozitie data din tablou </summary>
        /// <param name="n"> Numarul de elemente din tablou </param>
        /// <param name="v"> Tabloul </param>
        /// <param name="k"> Pozitia elementului care va fi sters </param>
        /// <returns> Tabloul modificat dupa stergere </returns>
        static int[] DeleteElement(int n, int[] v, int k)
        {
            int[] aux = new int[n - 1];
            
            for (int i = 0; i < k; i++)
                aux[i] = v[i];
            
            for (int i = k + 1; i < n; i++)
                aux[i - 1] = v[i];
            
            return aux;
        }
    }
}