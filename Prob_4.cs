using System;
using ReadWrite;

namespace Rezolvari
{
    class Prob_4
    {
        /// <summary> Determina si afiseaza cea mai mica valoare, cea mai mare valoare si numarul lor de aparitii dintr-un vector </summary>
        public static void Driver()
        {
            int n = Read.Numar("Lungimea vectorului");
            int[] v = Read.Vector("", n);
            Console.WriteLine();

            int[] pozitiiSiAparitii = ValoareMinMaxAparitii(n, v);
            Console.WriteLine($"Cea mai mica valoare: {pozitiiSiAparitii[0]}");
            Console.WriteLine($"Numarul de aparitii: {pozitiiSiAparitii[1]}{Environment.NewLine}");
            Console.WriteLine($"Cea mai mare valoare: {pozitiiSiAparitii[2]}");
            Console.WriteLine($"Numarul de aparitii: {pozitiiSiAparitii[3]}");
        }

        /// <summary> Determina cea mai mica valoare, cea mai mare valoare si numarul lor de aparitii dintr-un tablou dat </summary>
        /// <param name="n"> Numarul de elemente din tablou </param>
        /// <param name="v"> Tabloul </param>
        /// <returns> Cea mai mica valoare, cea mai mare valoare si numarul lor de apartii din tablou, sub forma unui tablou de 4 elemente: {minim, minAparitii, maxim, maxAparitii} </returns>
        static int[] ValoareMinMaxAparitii(int n, int[] v)
        {
            int minim = v[0], maxim = v[0], minAparitii = 1, maxAparitii = 1;

            for (int i = 1; i < n; i++)
            {
                if (v[i] < minim)
                {
                    minim = v[i];
                    minAparitii = 1;
                }
                else if (v[i] == minim)
                    minAparitii++;
                else if (v[i] > maxim)
                {
                    maxim = v[i];
                    maxAparitii = 1;
                }
                else if (v[i] == maxim)
                    maxAparitii++;
            }

            return new int[] { minim, minAparitii, maxim, maxAparitii };
        }
    }
}