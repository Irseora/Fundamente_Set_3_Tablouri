namespace Rezolvari
{
    class Prob_3
    {
        /// <summary> Determina pozitia celui mai mic si celui mai mare element din tabloul dat </summary>
        /// <param name="n"> Numarul de elemente din tablou </param>
        /// <param name="v"> Tabloul de numere intregi </param>
        /// <returns> Pozitia celui mai mic si celui mai mare element din tablou, intr-un tablou de 2 elemente: {pozMin, pozMax} </returns>
        public static int[] PozitieElementMinMax(int n, int[] v)
        {
            int pozMin = 0, pozMax = 0;

            for (int i = 0; i < n; i++)
            {
                if (v[i] < v[pozMin])
                    pozMin = i;
                else if (v[i] > v[pozMax])
                    pozMax = i;
            }
        
            return new int[] { pozMin, pozMax };
        }
    }
}