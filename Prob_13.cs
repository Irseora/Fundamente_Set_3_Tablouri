using System;
using ReadWrite;

namespace Rezolvari
{
    class Prob_13
    {
        /// <summary> Sorteaza crescator si afiseaza un vector prin Insertion Sort </summary>
        public static void Driver()
        {
            int n = Read.Numar("Lungimea vectorului");
            int[] v = Read.Vector("Vectorul", n);

            Console.Write($"Vectorul sortat: ");
            Write.Vector(InsertionSort(n, v));
        }

        /// <summary> Sorteaza crescator un vector, prin algoritmul Insertion Sort </summary>
        /// <param name="n"> Lungimea vectorului </param>
        /// <param name="v"> Vectorul </param>
        /// <returns> Vectorul dupa sortare </returns>
        static int[] InsertionSort(int n, int[] v)
        {
            return null;
        }
    }
}