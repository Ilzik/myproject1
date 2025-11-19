using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer;
            Console.WriteLine("Введите первое число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int w = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Выберите операцию");
            Console.WriteLine("1.Сложение");
            Console.WriteLine("2.Вычетание");
            Console.WriteLine("3.Умножение");
            answer = Console.ReadLine();
            switch (answer)
            {
                case "1":
                    Console.WriteLine($"Результат сложения {n} + {w} = " + (n + w));
                    break;
                case "2":
                    Console.WriteLine($"Результат вычитания {n} - {w} = " + (n - w));
                    break;
                case "3":
                    Console.WriteLine($"Результат умножения {n} * {w} = " + (n * w));
                    break;
                default:
                    Console.WriteLine("Вы неправильно ввели операцию");
                    break;
            }
        }
    }
}

