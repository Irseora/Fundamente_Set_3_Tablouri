using System;
using ReadWrite;

namespace Rezolvari
{
    class Prob_25
    {
        public static void Driver()
        {
            int n1 = Read.Numar("N1");
            int[] v1 = Read.Vector("V1", n1);

            int n2 = Read.Numar("N2");
            int[] v2 = Read.Vector("V2", n2);


        }

        /// <summary> Interclaseaza elementele a doua tablouri date. Sunt permise elemente duplicate </summary>
        /// <param name="n1"> Lungimea primului tablou </param>
        /// <param name="v1"> Primul tablou </param>
        /// <param name="n2"> Lungimea celui de al doilea tablou </param>
        /// <param name="v2"> Al doilea tablou </param>
        /// <returns> Un tablou care reprezinta interclasarea celor 2 tablouri </returns>
        static int[] Merge(int n1, int[] v1, int n2, int[] v2)
        {
            // +1 pentru a putea stoca si lungimea vectorului
            int[] interclasat = new int[n1 + n2 + 1];

            int i = 0, j = 0, k = 1;
            while (i < n1 && j < n2)
            {
                if (v1[i] < v2[j])
                    interclasat[k++] = v1[i++];
            }
        }
    }
}