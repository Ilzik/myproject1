using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace pr7_3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[15];
            Random random = new Random();
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = random.Next(1, 101);
            }
            Console.WriteLine("Массив: ");
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write(num[i] + " ");
            }
            Console.WriteLine();
//мин и мах элементы
           int min = num[0];
           int max = num[0];
            for (int i = 1; i < num.Length; i++)
            {
                if (num[i] < min)
                    min = num[i];
                if (num[i] > max)
                    max = num[i];
            }
            //разница между макс и мин значением
            int raz = max - min;
                //среднее арифмитическое
                int sum = 0;
            for (int i = 0; i < num.Length; i++) {
                sum += num[i]; }
            int average = sum / num.Length;
            //эл, которые больше ср арифмитического
            Console.WriteLine("Элементы,которые больше среднего аримитического: ");
            for (int i = 0; i < num.Length; i++) {
                if (num[i] < average)
                { Console.Write(num[i] + " "); }
            }Console.WriteLine();
            Console.WriteLine($"Минимальный элемент: {min}");
            Console.WriteLine($"Максимальный элемент: {max}");
            Console.WriteLine($"Разность между максимальным и минимальным: {raz}");
            Console.WriteLine($"Среднее арифметическое: {average}");

        }
    }
}
