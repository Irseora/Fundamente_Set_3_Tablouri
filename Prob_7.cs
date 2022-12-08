namespace Rezolvari
{
    class Prob_7
    {
        public static int[] Reverse(int n, int[] v)
        {
            for (int i = 0; i < n / 2; i++)
            {
                if (v[i] != v[n - i - 1])
                {
                    int aux = v[i];
                    v[i] = v[n - i - 1];
                    v[n - i - 1] = aux;
                }
            }

            return v;
        }
    }
}