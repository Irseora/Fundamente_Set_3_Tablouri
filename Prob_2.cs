namespace Rezolvari
{
    class Prob_2
    {
        /// <summary> Determina pozitia unui element intr-un tablou de numere intregi dat </summary>
        /// <param name="n"> Numarul de elemente din tablou </param>
        /// <param name="v"> Tabloul de numere intregi </param>
        /// <param name="k"> Elementul cautat </param>
        /// <returns> Pozitia elementului cautat in tablou </returns>
        public static int Search(int n, int[] v, int k)
        {
            int pozitieK = -1;

            for (int i = 0; i < n; i++)
                if (v[i] == k)
                {
                    pozitieK = i;
                    break;
                }

            return pozitieK;
        }
    }
}