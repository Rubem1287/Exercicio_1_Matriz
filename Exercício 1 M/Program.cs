using System;

namespace Exercício_1_M
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] a;

            string[] vetor = Console.ReadLine().Split(' ');
            int m = int.Parse(vetor[0]);
            int n = int.Parse(vetor[1]);

            a = new int[m, n];

           

            for (int l = 0; l < m; l++)
            {
                string[] vetor1 = Console.ReadLine().Split(' ');
                for (int c = 0; c < n; c++)
                {
                    a[l, c] = int.Parse(vetor1[c]);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Valores Negativos : ");
            for (int l = 0; l < m; l++)
            {

                for (int c = 0; c < n; c++)
                {
                    if (a[l,c] < 0)
                    {
                        Console.WriteLine(a[l, c]);
                    }
                  
                }

               
               

            }
        }
    }
}
