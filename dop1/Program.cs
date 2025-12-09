using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dop1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        string[] sales = {
         "Январь-Ноутбуки-5-120000",
         "Февраль-Телефоны-12-360000",
         "Март-Ноутбуки-8-192000",
         "Апрель-Планшеты-3-90000",
         "Май-Телефоны-15-450000"
        };
            Console.WriteLine("=== Анализ продаж ===");

            var MaxV = sales.OrderByDescending(b => Convert.ToInt32(b.Split('-')[3])).First();
            Console.WriteLine($" Месяц с наибольшей выручкой: {MaxV.Split('-')[0]} - {MaxV.Split('-')[3]} руб.");

            var MaxK=sales.OrderByDescending(b => Convert.ToInt32(b.Split('-')[2])).First();
            Console.WriteLine($" Товар с наибольшим количеством продаж: {MaxK.Split('-')[0]} {MaxK.Split('-')[2]} шт. ");

            var average = sales.Average(b => Convert.ToDouble(b.Split('-')[3]));
            foreach (var av in sales)
            {
                Console.WriteLine($" Средний рейтинг: {average}");
            }
        }
    }
}
