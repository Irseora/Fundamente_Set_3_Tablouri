using System;
using ReadWrite;

namespace Rezolvari
{
    class Prob_14
    {
        /// <summary> Muta toate elementele egale cu 0 la sfarsitul vectorului, apoi afiseaza vectorul modificat </summary>
        public static void Driver()
        {
            int n = Read.Numar("Lungimea vectorului");
            int[] v = Read.Vector("Tabloul", n);

            Console.Write($"{Environment.NewLine}Tabloul modificat: ");
            Write.Vector(Move0(n, v));
        }

        /// <summary> Muta toate elementele egale cu 0 la sfarsitul unui tablou </summary>
        /// <param name="n"> Lungimea tabloului </param>
        /// <param name="v"> Tabloul </param>
        /// <returns> Tabloul modificat dupa mutarea elementelor 0 </returns>
        static int[] Move0(int n, int[] v)
        {
            int stanga = 0, dreapta = n - 1;

            while (stanga < dreapta)
            {
                if (v[stanga] == 0)
                {
                    int aux = v[stanga];
                    v[stanga] = v[dreapta];
                    v[dreapta] = aux;

                    dreapta--;
                }
                else
                    stanga++;
            }

            return v;
        }
    }
}