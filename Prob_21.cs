using System;
using ReadWrite;

namespace Rezolvari
{
    class Prob_21
    {
        /// <summary> Determina si afiseaza ordinea lexicografica a doi vectori </summary>
        public static void Driver()
        {
            int n1 = Read.Numar("N1");
            int[] v1 = Read.Vector("V1", n1);

            int n2 = Read.Numar("N2");
            int[] v2 = Read.Vector("V2", n2);

            int ordine = OrdineLexicografica(n1, v1, n2, v2);
            Console.Write($"{Environment.NewLine}In ordine lexicografica ");

            if (ordine == 1)
                Console.WriteLine("V1 urmeaza inainte de V2");
            else if (ordine == 0)
                Console.WriteLine("V1 si V2 sunt pe aceeasi pozitie");
            else
                Console.WriteLine("V1 urmeaza dupa V2");
        }

        /// <summary> Determina ordinea lexicografica a doua tablouri </summary>
        /// <param name="n1"> Lungimea primului tablou </param>
        /// <param name="v1"> Primul tablou </param>
        /// <param name="n2"> Lungimea celui de al doilea tablou </param>
        /// <param name="v2"> Al doilea tablou </param>
        /// <returns> 
        /// <para>  1 - daca v1 urmeaza inainte de v2 </para>
        /// <para>  0 - daca v1 si v2 sunt identice </para>
        /// <para> -1 - daca v1 urmeaza dupa v2 </para>
        /// </returns>
        static int OrdineLexicografica(int n1, int[] v1, int n2, int[] v2)
        {
            int i = 0;
            while (i < n1 && i < n2)
            {
                if (v1[i] < v2[i])
                    return 1;
                else if (v1[i] > v2[i])
                    return -1;

                i++;
            }

            return 0;
        }
    }
}