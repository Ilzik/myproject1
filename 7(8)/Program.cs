using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_8_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[25];
            Random random = new Random();
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = random.Next(0, 101);
            }
            Console.WriteLine("Результаты тестирования: ");
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write(num[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Отсортированные результаты: ");
            var sortedA = num.OrderBy(x => x).ToArray();
            foreach (var number in sortedA)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            //расчет медианы
            if (sortedA.Length % 2 == 0)
            {
                double median = (num[(num.Length / 2) - 1] + num[num.Length / 2]) / 2;
                Console.WriteLine($"Медиана: {median}");
            }
            else
            {
                double median = sortedA[sortedA.Length / 2];
                Console.WriteLine($"Медиана: {median}");
            }
            //расчет отклонения
            int sum = 0;
            for (int i = 0; i < num.Length; i++)
            {
                sum += num[i];
            }
            double average = sum / num.Length;
            double sumOfSquares = 0;
            for (int i = 0; i < num.Length; i++)
            {
                double difference = num[i] - sum;
                sumOfSquares += difference * difference;
            }
            double variance = sumOfSquares / num.Length;
            double standardDeviation = Math.Sqrt(variance);
            Console.WriteLine($"Стандартное отклонение: {standardDeviation}");
            //топ10
            int topCount = (int)Math.Ceiling(num.Length * 0.1);
            Console.WriteLine("Топ 10% лучших результатов: ");
            for (int i = sortedA.Length - topCount; i < sortedA.Length; i++)
            {
                Console.Write(sortedA[i] + " ");
            }
            //группировка
            int awful = 0;
            int bad = 0;
            int good = 0;
            int excellent = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] < 50) { awful++; }
                else if (num[i] < 70) { bad++; }
                else if (num[i] < 85) { good++; }
                else { excellent++; }
            }
            Console.WriteLine();
            Console.WriteLine($"85-100 баллов: {excellent} студентов");
            Console.WriteLine($"70-85 баллов: {good} студентов");
            Console.WriteLine($"50-70 баллов: {bad} студентов");
            Console.WriteLine($"0-50 баллов: {awful} студентов");
        }
    }
}
