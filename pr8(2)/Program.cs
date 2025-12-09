using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr8_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк: ");
            int stroka= Convert.ToInt32(Console.ReadLine());


            Console.Write("Введите количество столбцов: ");
            int stolb = Convert.ToInt32(Console.ReadLine());

  
            if (stroka != stolb)
            {
                Console.WriteLine($"Вы ввели {stroka} строк и {stolb} столбцов.Массив должен быть квадратным.");
                Console.WriteLine($"Введите одинаковые числа");
                return;
            }

            int N = stroka;
            int[,] array = new int[N, N];
            Random random = new Random();

            Console.WriteLine($"Квадратный массив {N}x{N}:");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    array[i, j] = random.Next(1, 101);
                    Console.Write($"{array[i, j],4}");
                }
                Console.WriteLine();
            }
            //сумма главной диагонали
            int sum1 = 0;
            for (int i = 0; i < N; i++)
            {
                sum1 += array[i, i];
            }

            //сумма побочной диагонали
            int sum2 = 0;
            for (int i = 0; i < N; i++)
            {
                sum2 += array[i, N - 1 - i];
            }
            Console.WriteLine($"Сумма элементов главной диагонали: {sum1}");
            Console.WriteLine($"Сумма элементов побочной диагонали: {sum2}");
        }
    }
}
