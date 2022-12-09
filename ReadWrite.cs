using System;

namespace ReadWrite
{
    class Read
    {
        /// <summary> Citeste un numar intreg </summary>
        /// <param name="varName"> Numele variabilei care va fi citita </param>
        /// <returns> Numarul citit </returns>
        public static int Numar(string varName)
        {
            Console.Write($"{varName} = ");
            return int.Parse(Console.ReadLine());
        }

        /// <summary> Citeste un numar intreg dintr-un interval dat </summary>
        /// <param name="varName"> Numele variabilei care va fi citita </param>
        /// <param name="limJos"> Limita inferioara a intervalului </param>
        /// <param name="limSus"> Limita superioara a intervalului </param>
        /// <returns> Numarul citit </returns>
        public static int Numar(string varName, int limJos, int limSus)
        {
            Console.Write($"{varName} = ");
            int numar = int.Parse(Console.ReadLine());
            
            // Citeste pana primeste valori din intervalul dat
            while (numar < limJos || numar > limSus)
            {
                Console.WriteLine($"{varName} trebuie sa fie din intervalul [{limJos}, {limSus}]!");
                Console.Write($"{varName} = ");
                numar = int.Parse(Console.ReadLine());
            }

            return numar;
        }

        /// <summary> Citeste un tablou de numere intregi </summary>
        /// <param name="varName"> Numele variabilei care va fi citita </param>
        /// <param name="n"> Numarul de elemente din tablou </param>
        /// <returns> Tabloul citit </returns>
        public static int[] Vector(string varName, int n)
        {
            int[] v = new int[n];
            
            if (varName != "")
                Console.Write($"Introduceti elementele vectorului {varName}: ");
            else
                Console.Write("Introduceti elementele vectorului: ");


            string[] input = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(input[i]);

            return v;
        }
    }

    class Write
    {
        /// <summary> Afiseaza in consola elementele unui vector </summary>
        /// <param name="v"> Vectorul care va fi afisat </param>
        public static void Vector(int[] v)
        {
            for (int i = 0; i < v.Length; i++)
                Console.Write($"{v[i]} ");
            Console.WriteLine();
        }

        /// <summary> Afiseaza in consola elementele unui vector intre doi indexi dati </summary>
        /// <param name="v"> Vectorul care va fi afisat </param>
        /// <param name="stanga"> Indexul de inceput </param>
        /// <param name="dreapta"> Indexul final </param>
        public static void Vector(int[] v, int stanga, int dreapta)
        {
            for (int i = stanga; i < dreapta; i++)
                Console.Write($"{v[i]} ");
            Console.WriteLine();
        }
    }
}