using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr7_6_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ежедневная температура за месяц");
            int[] temperatures = new int[28];
            Random random = new Random();
            for (int i = 0; i < temperatures.Length; i++)
            {
                temperatures[i] = random.Next(-10, 39);
            }
            //разбиваем по неделеям
            for (int i = 0; i < temperatures.Length; i++)
            {
                Console.Write(temperatures[i] + " ");
                if ((i+1) % 7 == 0)
                Console.WriteLine();
            }
            Console.WriteLine();
            //самая теплая и холодная неделя
            int warm = 0;
            int cold = 10000;
            int wawe = 0;
            int cowe = 0;
            for (int week = 0; week < 4; week++)
            {
                int weeksum = 0;
                for (int day = 0; day < 7; day++)
                {
                    int dayI = week * 7 + day;
                    weeksum += temperatures[dayI];
                }
                Console.WriteLine($"Неделя {week + 1} - средняя температура = {weeksum / 7}°C");
                if (weeksum > warm)
                {
                    warm = weeksum;
                    wawe = week + 1;
                }

                if (weeksum < cold)
                {
                    cold = weeksum;
                    cowe = week + 1;
                }
            }
            Console.WriteLine($"Самая теплая неделя:{wawe} неделя, {warm / 7}°C");
            Console.WriteLine($"Самая холодная неделя:{cowe}  неделя,  {cold / 7}°C");
            Console.WriteLine();

            //средняя тепм
            double average = temperatures.Average();
            Console.WriteLine($"Средняя температура за месяц: {average}°C");
            //температура больше ср знач
            Console.WriteLine("Дни с температурой выше средней:");
            for (int i = 0; i < temperatures.Length; i++)
            {
                if (temperatures[i] > average)
                {
                    Console.WriteLine($"День {i + 1}: {temperatures[i]}°C");
                }
            }
            Console.WriteLine("Мороз - < 0");
            Console.WriteLine("Холодно - от 1 до 10°C");
            Console.WriteLine("Тепло - от 11 до 25°C");
            Console.WriteLine("Жара - > 25°C");
            Console.WriteLine("Группировка дней по категориям:");
            int frostCount = 0;
            int coldCount = 0;
            int warmCount = 0;
            int hotCount = 0;
            for (int i = 0; i < temperatures.Length; i++)
            {
                if (temperatures[i] < 0)
                {
                    frostCount++;
                }
                else if (temperatures[i] <= 10)
                {
                    coldCount++;
                }
                else if (temperatures[i] <= 25)
                {
                    warmCount++;
                }
                else
                {
                    hotCount++;
                }
                
            }
            Console.WriteLine($"Морозные дни: {frostCount}");
            Console.WriteLine($"Холодные дни: {coldCount}");
            Console.WriteLine($"Теплые дни: {warmCount}");
            Console.WriteLine($"Жаркие дни: {hotCount}");

        }
    }
}
