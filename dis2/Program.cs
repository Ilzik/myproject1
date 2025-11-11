using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dis2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //создаем маассив
            int[] num = new int[20];
            Random random = new Random(); 
            //заполняем массив рандомными числами
            
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = random.Next(1, 101); 
            }
           
            
            //выводим
            Console.WriteLine("Массив: ");
            for (int i = 0; i < num.Length; i++)
                { Console.Write(num[i] + " "); }
            Console.WriteLine();

           //нходим мин , мах и их индексы

            int max = num[0];
            int min = num[0];
            int maxInd = 0;
            int minInd = 0;
            for(int i=1; i<num.Length;i++)
            {
                if (num[i] > max)
                {
                    max = num[i];
                    maxInd = i;
                }
                if (num[i]<min)
                {
                    min = num[i];
                    minInd = i;
                }
            }
            //3проверяем есть ли дубликаты элемента
            int dupl = 0;
            for (int i = 0; i < num.Length; i++)
            {
                for (int b = i + 1; b < num.Length; b++)
                {
                    if (num[i] == num[b])
                    {
                        dupl++;
                    }
                }
            }
           //второе наиболҗшее число
            int Max = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] > Max && num[i] < max)
                {
                    Max = num[i];
                }
            }
            Console.WriteLine($"Минимальный элемент: {min}, Индекс: {minInd}");
            Console.WriteLine($"Максимальный элемент: {max}, Индекс: {maxInd}");
            Console.WriteLine($"Есть дубликаты: " + (dupl>0? "Да" : "Нет"));
            Console.WriteLine($"Второй по величине элемент: {Max}");
        }
    }
}
    

