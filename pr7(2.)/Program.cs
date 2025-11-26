using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr7_2._
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words= new string[] {"Один","Два","Три","Четыре","Пять","Шесть"};
            Console.WriteLine("Массив: ");
            for( int i=0;i<words.Length;i++)
            {
                Console.WriteLine(words[i]);
            }
            string lon= words[0];
            for(int i = 0; i < words.Length; i++)
            {
                if (words[i].Length>lon.Length)
                {
                    lon = words[i];
                   
                }
            }
            Console.WriteLine($"Самая длинная строка: {lon}");

            Console.Write("Введите подстроку для поиска: ");
            string a = Console.ReadLine();
            Console.WriteLine("Найденные строки:");
            bool answer = false;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Contains(a))
                {
                    Console.WriteLine(words[i]);
                    answer = true;
                }
            }

            if (answer == false)
            {
                Console.WriteLine("Строк с такой подстрокой не найдены");
            }

            
            Console.WriteLine("Введите строку для поиска индекса: ");
            string b = Console.ReadLine();
            int num = -1;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == b)
                {
                    num = i;
                    break;
                }
            }

            if (num >= 0)
            {
                Console.WriteLine("Индекс первого вхождения: " + num);
            }
            else
            {
                Console.WriteLine("Строка не найдена в массиве");
            }
        }
    }
}
