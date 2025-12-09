using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr8_3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк: ");
            int M = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите количество столбцов: ");
            int N = Convert.ToInt32(Console.ReadLine());

            int[,] array = new int[M, N];
            Random random = new Random();

            Console.WriteLine($"Исходный массив {M}*{N}");
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    array[i, j] = random.Next(1, 101);
                    Console.Write($"{array[i, j]+ " "}");
                }
                Console.WriteLine();
            }
            int[,] tArray = new int[N, M];

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    tArray[j, i] = array[i, j];
                }
            }

            Console.WriteLine($"Транспонированный массив {N}*{M}:");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write($"{tArray[i, j]+ " "}");
                }
                Console.WriteLine();
                
             
            }
        }
    }
}
