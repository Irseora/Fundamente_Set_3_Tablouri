namespace Rezolvari
{
    class Prob_4
    {
        /// <summary> Determina cea mai mica valoare, cea mai mare valoare si numarul lor de aparitii dintr-un tablou dat </summary>
        /// <param name="n"> Numarul de elemente din tablou </param>
        /// <param name="v"> Tabloul </param>
        /// <returns> Cea mai mica valoare, cea mai mare valoare si numarul lor de apartii din tablou, sub forma unui tablou de 4 elemente: {minim, minAparitii, maxim, maxAparitii} </returns>
        public static int[] ValoareMinMaxAparitii(int n, int[] v)
        {
            int minim = v[0], maxim = v[0], minAparitii = 1, maxAparitii = 1;

            for (int i = 1; i < n; i++)
            {
                if (v[i] < minim)
                {
                    minim = v[i];
                    minAparitii = 1;
                }
                else if (v[i] == minim)
                    minAparitii++;
                else if (v[i] > maxim)
                {
                    maxim = v[i];
                    maxAparitii = 1;
                }
                else if (v[i] == maxim)
                    maxAparitii++;
            }

            return new int[] { minim, minAparitii, maxim, maxAparitii };
        }
    }
}