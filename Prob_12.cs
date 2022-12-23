using System;
using ReadWrite;

namespace Rezolvari
{
    class Prob_12
    {
        /// <summary> Sorteaza crescator si afiseaza un vector prin Selection Sort </summary>
        public static void Driver()
        {
            int n = Read.Numar("Lungimea vectorului");
            int[] v = Read.Vector("Vetorul", n);

            Console.Write($"Vectorul sortat: ");
            Write.Vector(SelectionSort(n, v));
        }

        /// <summary> Sorteaza crescator un vector, prin algoritmul Selection Sort </summary>
        /// <param name="n"> Lungimea vectorului </param>
        /// <param name="v"> Vectorul </param>
        /// <returns> Vectorul dupa sortare </returns>
        static int[] SelectionSort(int n, int[] v)
        {
            for (int i = 0; i < n-1; i++)
            {
                // Cauta al i-lea cel mai mic element al vectorului
                int minim = i;
                for (int j = i + 1; j < n; j++)
                    if (v[j] < v[minim])
                        minim = j;

                // Interschimba elementul de pe pozitia i si al i-lea cel mai mic element
                if (minim != i)
                {
                    int aux = v[i];
                    v[i] = v[minim];
                    v[minim] = aux;
                }
            }

            return v;
        }
    }
}