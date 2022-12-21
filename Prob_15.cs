using System;
using ReadWrite;

namespace Rezolvari
{
    class Prob_15
    {
        /// <summary> Elimina elementele care se repeta din vector, apoi afiseaza vectorul modificat </summary>
        public static void Driver()
        {
            int n = Read.Numar("Lungimea vectorului");
            int[] v = Read.Vector("Vectorul", n);

            Console.Write("Vectorul modificat dupa eliminari: ");
            DeleteRepeating(n, v);
        }

        /// <summary> Elimina elementele care se repeta din tabloul dat </summary>
        /// <param name="n"> Lungimea tabloului </param>
        /// <param name="v"> Tabloul </param>
        /// <returns> Tabloul modificat dupa eliminari </returns>
        static void DeleteRepeating(int n, int[] v)
        {
            int i = 0;
            // Urmareste daca s-a facut o modificare in pasul curent
            bool changed = false;

            while (i < n - 1)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (v[i] == v[j])
                    {
                        // Pentru a "elimina" un element, il inlocuieste cu ultimul element al vectorului,
                        // dupa care scade 1 din lungimea vectorului
                        v[j] = v[n-1];
                        n--;

                        changed = true;
                    }
                }

                // Creste valoarea lui i doar daca nu s-a facut nicio modificare in pasul curent,
                // pentru a nu rata un element duplicat
                if (!changed) i++;
                else changed = false;
            }

            Write.Vector(v, 0, n);
        }
    }
}