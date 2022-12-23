using System;
using ReadWrite;

namespace Rezolvari
{
    class Prob_17
    {
        /// <summary> Converteste si afiseaza un numar din baza 10 in baza b </summary>
        public static void Driver()
        {
            // TODO: long
            int numarBaza10 = Read.Numar("Numarul din baza 10");
            int bazaB = Read.Numar("Baza tinta", 1, 17);

            Console.WriteLine($"{Environment.NewLine}Numarul dat in baza tinta: {ConvBase10BaseB(numarBaza10, bazaB)}");
        }

        /// <summary> Converteste un numar din baza 10 in baza b </summary>
        /// <param name="numarBaza10"> Un numar din baza 10 </param>
        /// <param name= "bazaB"> Baza tinta </param>
        /// <returns> Reprezentarea numarului in baza b </returns>
        static string ConvBase10BaseB(int numarBaza10, int bazaB)
        {
            string numarBazaB = "";

            while (numarBaza10 > 0)
            {
                numarBazaB = CifraIntChar(numarBaza10 % bazaB) + numarBazaB;
                numarBaza10 /= bazaB;
            }

            return numarBazaB;
        }

        /// <summary> Determina litera care ii corespunde unei valori numerice </summary>
        /// <param name="cifraNumeric"> Valoarea numerica a cifrei </param>
        /// <returns> Litera corespunzatoare valorii numerice </returns>
        static char CifraIntChar(int cifraNumeric)
        {
            switch (cifraNumeric)
            {
                case 1:  return '1';
                case 2:  return '2'; 
                case 3:  return '3';
                case 4:  return '4';
                case 5:  return '5';
                case 6:  return '6';
                case 7:  return '7';
                case 8:  return '8';
                case 9:  return '9';
                case 10: return 'A';
                case 11: return 'B';
                case 12: return 'C';
                case 13: return 'D';
                case 14: return 'E';
                case 15: return 'F';

                default: return 'X';
            }
        }
    }
}