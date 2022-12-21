using System;
using ReadWrite;

namespace Rezolvari
{
    class Prob_19
    {
        /// <summary> Determina si afiseaza de cate ori apare un vector intr-un alt vector </summary>
        public static void Driver()
        {
            int nS = Read.Numar("Lungimea lui S");
            int[] s = Read.Vector("S", nS);

            int nP = Read.Numar("Lungimea lui P");
            int[] p = Read.Vector("P", nP);

            Console.WriteLine($"Vectorul P apare in vectorul S de {FindPInS(nS, s, nP, p)} ori");
        }

        /// <summary> Determina de cate ori se gaseste tabloul p in tabloul s </summary>
        /// <param name="nS"> Lungimea tabloului s </param>
        /// <param name="s"> Tabloul in care se cauta </param>
        /// <param name="nP"> Lungimea tabloului p </param>
        /// <param name="p"> Tabloul care se cauta </param>
        /// <returns> Numarul de aparitii al tabloului p in tabloul s </returns>
        static int FindPInS(int nS, int[] s, int nP, int[] p)
        {
            int count = 0, pozCurentaInP = 0;

            for (int i = 0; i < nS; i++)
            {
                if (s[i] == p[pozCurentaInP])
                {
                    pozCurentaInP++;

                    if (pozCurentaInP == nP)
                    {
                        count++;
                        pozCurentaInP = 0;
                    }
                }
                else
                    pozCurentaInP = 0;
            }

            return count;
        }
    }
}