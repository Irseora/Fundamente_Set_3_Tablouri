using System;
using ReadWrite;

namespace Rezolvari
{
    class Prob_16
    {
        /// <summary> Determina si afiseaza cel mai mare divizor comun al elementelor unui vector </summary>
        public static void Driver()
        {
            int n = Read.Numar("N");
            int[] v = Read.Vector("", n);

            Console.WriteLine($"{Environment.NewLine}Cel mai mare divizor comun al elementelor vectorului: {CMMDCVector(n, v)}");
        }

        /// <summary> Determina cel mai mare divizor comun al unui tablou de numere intregi </summary>
        /// <param name="n"> Numarul de elemente din tablou </param>
        /// <param name="v"> Tabloul </param>
        /// <returns> Cel mai mare divizor comun al tuturor elementelor din tablou </returns>
        static int CMMDCVector(int n, int[] v)
        {
            int cmmdc = v[0];

            for (int i = 1; i < n; i++)
                cmmdc = CMMDC(cmmdc, v[i]);

            return cmmdc;
        }

        /// <summary> Determina cel mai mare divizor comun al doua numere date </summary>
        /// <param name="x"> Primul numar </param>
        /// <param name="y"> Al doilea numar </param>
        /// <returns> Cel mai mare divizor comun al celor doua numere </returns>
        static int CMMDC(int x, int y)
        {
            while (x != y)
            {
                if (x > y)
                    x -= y;
                else
                    y -= x;
            }

            return x;
        }
    }
}