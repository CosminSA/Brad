using System;

namespace BradApp
{
    public class Bradmat
    {        
        public int[,] crearebrad(int n, int s)
        {
            int k = 0;
            int[,] a = new int[s, 2 * n + 1];
            int i;
            for (i = 2; i <= n + 1; i++)
            {
                int j, x, t;
                for (t = 1; t <= i * 2 - 1; t = t + 2)
                {
                    for (j = 0; j <= (n * 2 + 1 - t) / 2-1; j++) a[k, j] = 0; j--;
                    for (x = 1; x <= t; x++) a[k, j + x] = 1;
                    for (j = (n * 2 + 1 - t) / 2 + t; j <= n * 2; j++)a[k, j] = 0;


                    k++;
                }

            }
            for (i = 0; i < n; i++) a[k, i] = 0;
            a[k, n] = 1;
            for (i = n + 1; i <= n * 2; i++) a[k, i] = 0; k++;
            for (i = 0; i < n; i++) a[k, i] = 0;
            a[k, n] = 1;
            for (i = n + 1; i <= n * 2; i++) a[k, i] = 0;
            return a;
        }
    }
}
