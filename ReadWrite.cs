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

        /// <summary> 
        /// <para> Citeste un numar intreg dintr-un interval dat </para>
        /// <para> limJos < numar < limSus </para>
        /// </summary>
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

        /// <summary> Citeste un tablou de cifre, fara spatii delimitatoare </summary>
        /// <param name="varName"> Numele variabilei care va fi citita </param>
        /// <param name="n"> Numarul de elemente din tablou </param>
        /// <returns> Tabloul citit </returns>
        public static int[] VectorNoSpaces(string varName, int n)
        {
            const int valoareDeScazutDinCaracter = '0';
            int[] v = new int[n];
            
            if (varName != "")
                Console.Write($"Introduceti elementele vectorului {varName}: ");
            else
                Console.Write("Introduceti elementele vectorului: ");

            char[] input = Console.ReadLine().ToCharArray();
            for (int i = 0; i < n; i++)
                v[i] = input[i] - valoareDeScazutDinCaracter;

            return v;
        }

        /// <summary> Citeste un tablou de valori binare </summary>
        /// <param name="varName"> Numele variabilei care va fi citita </param>
        /// <param name="n"> Numarul de elemente din tablou (cel mai mare element zecimal) </param>
        /// <returns> Tabloul citit </returns>
        public static bool[] VectorBool(string varName, int n)
        {
            bool[] v = new bool[n];

            if (varName != "")
                Console.Write($"Introduceti elementele vectorului {varName}: ");
            else
                Console.Write("Introduceti elementele vectorului: ");

            string[] input = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
                if (input[i] == "0")
                    v[i] = false;
                else if (input[i] == "1")
                    v[i] = true;

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

        /// <summary> Afiseaza in consola elementele unui vector care reprezinta cifrele unui numar foarte mare, fara spatii delimitatoare </summary>
        /// <param name="v"> Vectorul care va fi afisat </param>
        /// <param name="stanga"> Indexul de inceput </param>
        /// <param name="dreapta"> Indexul final </param>
        public static void VectorNoSpaces(int[] v)
        {
            for (int i = 0; i < v.Length; i++)
            {
                if (i == 0 && v[i] == 0) ;
                else
                    Console.Write(v[i]);
            }
            Console.WriteLine();
        }

        /// <summary> Afiseaza in consola un vector de valori binare
        /// in format binar, apoi reprezentarea lui zecimala </summary>
        /// <param name="v"> Vectorul binar care va fi afisat </param>
        /// <param name="format"> Formatul in care va fi afisat vectorul binar (zecimal / binar) </param>
        public static void Vector(bool[] v, string format)
        {
            for (int i = 0; i < v.Length; i++)
                if (v[i] == true )
                {
                    if (format == "binar")
                        Console.Write("1 ");
                    else if (format == "zecimal")
                        Console.Write($"{i+1} ");
                }
                else
                {
                    if (format == "binar")
                        Console.Write("0 ");
                }
            Console.WriteLine();
        }
    }
}