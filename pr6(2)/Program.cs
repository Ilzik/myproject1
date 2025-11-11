using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr6_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int sum = 0;
            do
            {
                Console.WriteLine("Введите ваше число");
                a=Convert.ToInt32(Console.ReadLine());
                if (a!=0)
                {
                    sum += a;
                }

            }while(a!=0);
            Console.WriteLine($"Сумма всех чисел равна {sum}");
        }
    }
}
