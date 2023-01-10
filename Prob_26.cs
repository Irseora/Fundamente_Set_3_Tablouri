using System;
using ReadWrite;

namespace Rezolvari
{
    class Prob_26
    {
        /// <summary> Determina si afiseaza suma, diferentele si produsul a 2 numere foarte mari </summary>
        public static void Driver()
        {
            int n1 = Read.Numar("Lungimea primului numar");
            int[] v1 = Read.VectorNoSpaces("Primul numar mare: V1", n1);
            v1 = Prob_7.Reverse(n1, v1);

            int n2 = Read.Numar("Lungimea celui de al doilea numar");
            int[] v2 = Read.VectorNoSpaces("Al doilea numar mare: V2", n2);
            v2 = Prob_7.Reverse(n2, v2);

            int maiMare = (n1 > n2) ? n1 : n2;

            int[] suma = Add(n1, v1, n2, v2);
            Console.Write("V1 + V2 = ");
            Write.VectorNoSpaces(Prob_7.Reverse(maiMare+1, suma));

            if (Bigger(n1, v1, n2, v2))
            {
                int[] diferenta = Subtract(n1, v1, n2, v2);
                Console.Write("V1 - V2 = ");
                //Write.VectorNoSpaces(Prob_7.Reverse())
            }
            
            
        }

        /// <summary> Determina primul numar este mai mare decat cel de al doilea </summary>
        /// <param name="n1"> Lungimea primului numar </param>
        /// <param name="v1"> Primul numar </param>
        /// <param name="n2"> Lungimea celui de al doilea numar </param>
        /// <param name="v2"> Al doilea numar </param>
        /// <returns>
        /// <para> Adevarat - daca v1 > v2 </para>
        /// <para> Fals - daca v1 <= v2 </para>
        /// </returns>
        static bool Bigger(int n1, int[] v1, int n2, int[] v2)
        {
            if (n1 > n2)
                return true;

            if (n1 < n2)
                return false;

            for (int i = 0; i < n1; i++)
                if (v1[i] > v2[i])
                    return true;

            return false;
        }

        /// <summary> Determina suma a doua numere foarte mari </summary>
        /// <param name="n1"> Lungimea primului numar </param>
        /// <param name="v1"> Primul numar mare </param>
        /// <param name="n2"> Lungimea celui de al doilea numar </param>
        /// <param name="v2"> Al doilea numar mare </param>
        /// <returns> Suma celor 2 numere </returns>
        static int[] Add(int n1, int[] v1, int n2, int[] v2)
        {
            int[] suma = new int[((n1 > n2) ? n1 : n2) + 1];  // + 1 pentru overflow

            int i = 0, carry = 0;
            while (i < n1 && i < n2)
            {
                int cif = v1[i] + v2[i];

                suma[i] = (cif + carry) % 10;
                carry = cif / 10;
                i++;
            }

            while (i < n1)
            {
                suma[i] = (v1[i] + carry) % 10;
                carry = v1[i] / 10;
                i++;
            }

            while (i < n2)
            {
                suma[i] = (v2[i] + carry) % 10;
                carry = v2[i] / 10;
                i++;
            }

            return suma;
        }

        /// <summary> Determina diferenta V1 - V2 a doua numere mari </summary>
        /// <param name="n1"> Lungimea primului numar </param>
        /// <param name="v1"> Primul numar mare </param>
        /// <param name="n2"> Lungimea celui de al doilea numar </param>
        /// <param name="v2"> Al doilea numar mare </param>
        /// <returns> Diferenta celor 2 numere </returns>
        static int[] Subtract(int n1, int[] v1, int n2, int[] v2)
        {
            int[] diferenta = new int[(n1 > n2) ? n1 : n2];

            int i = 0;
            while (i < n1-1 && i < n2)
            {
                int cif = v1[i] - v2[i];

                if (cif < 0)
                {
                    diferenta[i] = cif + 10;
                    v1[i+1]--;
                }
                else
                    diferenta[i] = cif;

                i++;
            }

            while (i < n1)
            {
                diferenta[i] = v1[i];
                i++;
            }

            while (i < n2)
            {
                diferenta[i] = v2[i];
                i++;
            }

            return diferenta;
        }

        /// <summary>  </summary>
        /// <param name="">  </param>
        /// <param name="">  </param>
        /// <returns>  </returns>
        static int[] Multiply()
        {
            return null;
        }
    }
}