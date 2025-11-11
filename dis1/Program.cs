using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dis1
{
    internal class Program
    {
        static void Main(string[] args)
        {   //создание массива на 15 чисел
            int[] numbers = new int[15];
            Random random = new Random(); //генератор случайных исел
            // заполнение массиварандомными числами
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(-10, 11); //next(min,max) дает числа от мин до мах-1
            }
            Console.WriteLine("Массив: ");
            //выводим массив
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            //иннициалзация счеткиа и суммы
            int positiveCount = 0;
            int negativeCount = 0;
            int zeroCount = 0;
            int positiveSum = 0;
            int negativeSum = 0;
            //анализ каждого элемента массива
            for (int i = 0; i < numbers.Length; i++)
            { //если элемент полож
                if (numbers[i] > 0)
                {
                    positiveCount++; //увелич счетчик полож ччисел
                    positiveSum = positiveSum + numbers[i]; //увел сумму полож чисел
                }
                //если эл отриц
                else if (numbers[i] < 0)
                {
                    negativeCount++; //увелич счетчик отриц чисел
                    negativeSum = negativeSum + numbers[i]; //увелич сумм отриц чисел

                }
                //если элемент равен 0
                else
                {
                    zeroCount++; //увелич сетчикк нулей
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Количество положительных чисел: {positiveCount}. Сумма положительных чисел : {positiveSum}");
            Console.WriteLine($"Количество  отрицательных чисел: {negativeCount}. Сумма отрицательных чисел : {negativeSum}");
            Console.WriteLine("Количество нулей: " + zeroCount);
        }
    }
}
