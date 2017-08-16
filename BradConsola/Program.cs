using System;

namespace BradConsola
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.Write("Introduceti numarul de ramuri ");
        int n = int.Parse(Console.ReadLine());
        int s = (n + 1) * (n + 2) / 2 + 1;
        int[,] a = new int[s, 2 * n + 2];
        BradApp.Bradmat m = new BradApp.Bradmat();
        a = m.crearebrad(n, s);
        int i, j;
        for (i = 0; i < s; i++)
            {
            for (j = 0; j <= n * 2; j++) Console.Write(a[i, j]);
            Console.WriteLine();

            }
        Console.ReadLine();
        }
    }
}