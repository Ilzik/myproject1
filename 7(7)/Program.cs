using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_7_
{
    internal class Program
    {
        static void Main(string[] args)//название цена категория
        {
            string[] tovars =
            {
                "Куртка-5500-Одежда",
                "Телефон-60000-Электроника",
                "Тетрадь-45-Канцелярия",
                "Толстовка-2500-Одежда",
                "Ноутбук-60000-Электроника",
                "Ручка-15-Канцелярия"
            };
            Console.WriteLine("===Анализ товаров===");
            Console.WriteLine("Товары по определенной категории: Одежда");
            var wear = tovars.Where(b => b.Split('-')[2]=="Одежда");
            foreach (var wr in wear)
            {
                Console.WriteLine($" - {wr.Split('-')[0]}");
            }

            Console.WriteLine("Товары в определенном ценовом диапазоне");
            var price = tovars.Where(b => Convert.ToInt32(b.Split('-')[1]) > 0 && Convert.ToInt32(b.Split('-')[1]) < 2600);
           foreach ( var pr in price)
            {
                Console.WriteLine($" -{pr.Split('-')[0]} {pr.Split('-')[1]}");
            }

            Console.WriteLine("Товары по возрастанию цены");
            var pricee = tovars.OrderBy(b => Convert.ToDouble(b.Split('-')[1]));
            foreach (var pri in pricee)
            {
                Console.WriteLine($" -{pri.Split('-')[0]} {pri.Split('-')[1]}");
            }

        }
    }
}
