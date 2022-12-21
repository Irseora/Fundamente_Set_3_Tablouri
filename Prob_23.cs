using System;
using ReadWrite;

namespace Rezolvari
{
    class Prob_23
    {
        /// <summary> Determina si afiseaza intersectia, reuniunea si diferentele a doua multimi ordonate strict crescator </summary>
        public static void Driver()
        {
            int n1 = Read.Numar("N1");
            int[] v1 = Read.Vector("V1", n1);

            int n2 = Read.Numar("N2");
            int[] v2 = Read.Vector("V2", n2);

            Console.WriteLine();

            int[] intersectie = Intersectie(n1, n2, v1, v2);
            Console.Write("Intersectia celor doua multimi: ");
            Write.Vector(intersectie, 1, intersectie[0]);

            int[] reuniune = Reuniune(n1, n2, v1, v2);
            Console.Write("Reuniunea celor doua multimi: ");
            Write.Vector(reuniune, 1, reuniune[0]);

            int[] diferenta1 = Diferenta(n1, n2, v1, v2);
            Console.Write("Diferenta V1 - V2: ");
            Write.Vector(diferenta1, 1, diferenta1[0]);

            int[] diferenta2 = Diferenta(n2, n1, v2, v1);
            Console.Write("Diferenta V2 - V1: ");
            Write.Vector(diferenta2, 1, diferenta2[0]);
        }

        /// <summary> Determina intersectia a doua multimi </summary>
        /// <param name="n1"> Numarul de elemente din prima multime </param>
        /// <param name="n2"> Numarul de elemente din a doua multime </param>
        /// <param name="v1"> Prima multime </param>
        /// <param name="v2"> A doua multime </param>
        /// <returns> Intersectia celor doua multimi </returns>
        public static int[] Intersectie(int n1, int n2, int[] v1, int[] v2)
        {
            // +1 pentru a putea stoca si lungimea multimii
            int[] intersectie = new int [n1 + 1];
            int k = 1;

            for (int i = 0; i < n1; i++)
                if (Prob_10.BinSearch(n2, v2, v1[i]) != -1)
                    intersectie[k++] = v1[i];

            // Stocheaza lungimea multimii in primul element al vectorului
            intersectie[0] = k;

            return intersectie;
        }

        /// <summary> Determina reuniunea a doua multimi </summary>
        /// <param name="n1"> Numarul de elemente din prima multime </param>
        /// <param name="n2"> Numarul de elemente din a doua multime </param>
        /// <param name="v1"> Prima multime </param>
        /// <param name="v2"> A doua multime </param>
        /// <returns> Reuniunea celor doua multimi </returns>
        public static int[] Reuniune(int n1, int n2, int[] v1, int[] v2)
        {
            // +1 pentru a putea stoca si lungimea multimii
            int[] reuniune = new int [n1 + n2 + 1];
            int k = 1;

            int i = 0, j = 0;
            while (i < n1 && j < n2)
            {
                if (v1[i] < v2[j])
                    reuniune[k++] = v1[i++];
                else if (v1[i] > v2[j])
                    reuniune[k++] = v2[j++];
                else
                {
                    reuniune[k++] = v1[i];
                    i++; j++;
                }
            }

            while (i < n1)
                reuniune[k++] = v1[i++];

            while (j < n2)
                reuniune[k++] = v2[j++];

            // Stocheaza lungimea multimii in primul element al vectorului
            reuniune[0] = k;

            return reuniune;
        }

        /// <summary> Determina diferenta dintre doua multimi </summary>
        /// <param name="n1"> Numarul de elemente din prima multime </param>
        /// <param name="n2"> Numarul de elemente din a doua multime </param>
        /// <param name="v1"> Prima multime </param>
        /// <param name="v2"> A doua multime </param>
        /// <returns> Diferenta dintre cele doua multimi </returns>
        public static int[] Diferenta(int n1, int n2, int[] v1, int[] v2)
        {
            // Diferenta poate avea maxim atatea elemente, cate are multimea mai mare dintre cele doua date
            int maiMare = (n1 > n2) ? n1 : n2;

            // +1 pentru a putea stoca si lungimea multimii
            int[] diferenta = new int [maiMare + 1];
            int k = 1;

            for (int i = 0; i < n1; i++)
                if (Prob_10.BinSearch(n2, v2, v1[i]) == -1)
                    diferenta[k++] = v1[i];

            // Stocheaza lungimea multimii in primul element al vectorului
            diferenta[0] = k;

            return diferenta;
        }
    }
}