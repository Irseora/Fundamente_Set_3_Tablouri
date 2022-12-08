namespace Rezolvari
{
    class Prob_5
    {
        /// <summary> Insereaza un element intr-un tablou, pe o pozitie data </summary>
        /// <param name="n"> Numarul de elemente din tablou </param>
        /// <param name="v"> Tabloul </param>
        /// <param name="e"> Elementul care va fi inserat </param>
        /// <param name="k"> Pozitia pe care se insereaza </param>
        /// <returns> Tabloul modificat dupa inserare </returns>
        public static int[] InsertElement(int n, int[] v, int e, int k)
        {
            int[] aux = new int[n + 1];

            for (int i = 0; i < k; i++)
                aux[i] = v[i];
            
            aux[k] = e;

            for (int i = k; i <= n; i++)
                aux[i + 1] = v[i];

            return aux;
        }
    }
}