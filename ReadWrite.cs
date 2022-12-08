using System;

namespace ReadWrite
{
    class Read
    {
        /// <summary> Citeste un numar intreg </summary>
        /// <param name="varName"> Numele variabilei care va fi citita </param>
        /// <returns> Numarul citit </returns>
        public static int ReadNumar(string varName)
        {
            Console.Write(varName + " = ");
            return int.Parse(Console.ReadLine());
        }

        /// <summary> Citeste un tablou de numere intregi </summary>
        /// <param name="varName"> Numele variabilei care va fi citita </param>
        /// <param name="n"> Numarul de elemente din tablou </param>
        /// <returns> Tabloul citit </returns>
        public static int[] ReadVector(string varName, int n)
        {
            int[] v = new int[n];
            
            Console.Write($"Introduceti elementele vectorului {varName}: ");
            string[] input = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
                v[i] = int.Parse(input[i]);

            return v;
        }
    }

    class Write
    {
        
    }
}