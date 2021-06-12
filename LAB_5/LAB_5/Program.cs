using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LAB_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер строк матрицы:\n");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Введите размер рядков матрицы:\n");
            int m = int.Parse(Console.ReadLine());
            var rand = new Random();
            int[,] A = new int[n, m];
            Console.Write("Вывод матрицы:\n");
            for (int i = 0; i < n; i++) //вывод матрицы на консоль
            {
                for (int j = 0; j < m; j++)
                {
                    A[i, j] = rand.Next(-10, 10);
                    Console.Write("{0,3} ", A[i, j]);
                }
                Console.WriteLine();
            }
            int maxpg = 0, minpg = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (i == 0 || A[i,j] > maxpg) maxpg = A[i,j]; //max для побочной диагонали
                    if (i == 0 || A[i,n - 1 - j] < minpg) minpg = A[i,n - 1 - j]; //min для побочной диагонали

                }
            }

            int maxpb = A[n - 1, 0];
            int minpb = A[n - 1, 0];
            for (int i = n - 1; i >= 0; i--)
            {
                for (int j = 0; j < m; j++)
                {
                    if (i + j == n - 1) // если элемент побочной диагонали
                    {
                        if (A[i, j] > maxpb) maxpb = A[i, j];   //max для побочной диагонали
                        if (A[i, j] < minpb) minpb = A[i, j];   //min для побочной диагонали
                    }
                }
            }
            Console.WriteLine("Максимальный элемент паралельной главной диагонали - " + maxpg);
            Console.WriteLine("Минимальный элемент паралельной главной диагонали - " + minpg);
            Console.WriteLine("Максимальный элемент паралельной побочной диагонали = " + maxpb);
            Console.WriteLine("Минимальный элемент паралельной побочной диагонали = " + minpb);
            
            Console.ReadKey();
        }
    }
}


