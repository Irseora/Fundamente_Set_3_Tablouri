using System;
using ReadWrite;

namespace Rezolvari
{
    class Prob_18
    {
        /// <summary> Calculeaza si afiseaza valoare unui polinom intr-un punct dat </summary>
        public static void Driver()
        {
            int n = Read.Numar("N (gradul polinomului)");
            int[] coeficienti = Read.Vector("coeficienti", n);
            int x = Read.Numar("X");

            int rezultat = Polinom(x, n, coeficienti);
            Console.WriteLine($"{Environment.NewLine}Valoarea polinomului in punctul {x}: {rezultat}");
        }

        // TODO: Wrong solution ???
        /// <summary> Calculeaza valoarea unui polinom intr-un punct dat, in mod recursiv </summary>
        /// <param name="x"> Punctul in care se va calcula valoarea polinomului </param>
        /// <param name="n"> Gradul polinomului </param>
        /// <param name="coeficienti"> Coeficientii polinomului </param>
        /// <returns> Valoarea polinomului in punctul x </returns>
        static int Polinom(int x, int n, int[] coeficienti)
        {
            if (n == 0)
                return coeficienti[0];
            else
                return coeficienti[0] + x * Polinom(x, n - 1, coeficienti);
        }

        // f_5(x) = f + x * f_4(x) = f + x * (e + x * f_3(x)) = ...
        // f_n(x) = coef_n + x * f_(n-1)(x)
    }
}