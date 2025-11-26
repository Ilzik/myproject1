using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr7_1_
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            int[] num = new int[10];
            Random random = new Random();
           for(int i=0; i<num.Length; i++)
            {
                num[i] = random.Next(1, 101);
            }
            Console.WriteLine("Массив: ");
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write(num[i] + " ");
            }
                Console.WriteLine();
            int sum = 0;
            int sred = 0;
            for(int i=0; i< num.Length;i++)
            {
                sum += num[i];
                
            }  sred = sum / 10;
            Console.WriteLine($"Cумма всех элементов массива: {sum}");
            Console.WriteLine($"Среднее арифметическое: {sred}");
            int a = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] % 2 == 0)
                { a++; }
            }
                Console.WriteLine($"Количество четных чисел: {a} ");
            
        }
    }
}
