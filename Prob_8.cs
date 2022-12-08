namespace Rezolvari
{
    class Prob_8
    {
        /// <summary> Roteste elementele unui vector cu o pozitie spre stanga </summary>
        /// <param name="n"> Numarul de elemente din vector </param>
        /// <param name="v"> Vectorul de numere intregi </param>
        /// <returns> Vectorul modificat dupa rotire </returns>
        public static int[] Rotate(int n, int[] v)
        {
            // Salveaza primul element
            int aux = v[0];

            // Muta restul elemenetelor cu o pozitie spre stanga
            for (int i = 0; i < n - 1; i++)
                v[i] = v[i + 1];

            // Muta primul element pe ultima pozitie
            v[n - 1] = aux;

            return v;
        }
    }
}