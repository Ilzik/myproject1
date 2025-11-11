using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввведите первое число");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1.Сложение");
            Console.WriteLine("2.Вычетание");
            Console.WriteLine("3.Умножение");
            Console.WriteLine("4. Деление");

            string answer = Console.ReadLine();
            switch (answer)
            {
                case "1":
                    Console.WriteLine($"Результат сложения:{a} + {b}=" + (a + b));
                    break;
                case "2":
                    Console.WriteLine($"Результат вычитания:{a} - {b}=" + (a - b));
                    break;
                case "3":
                    Console.WriteLine($"Результат умножения:{a}*{b}=" + (a * b));
                    break;
                case "4":
                    Console.WriteLine($"Результат деления:{a}/{b}=" + (a / b));
                    break;
                default:
                    Console.WriteLine("Нет такого действия");
                    break;

            }
        }
    }
}
