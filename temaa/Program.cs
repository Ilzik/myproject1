using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temaa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] books =
            {
                "ВойнаИМир-Толстой-1869-4,8",
                "ПреступлениеИНаказание-Достоевский-1866-4,7",
                "1984-Оруэлл-1949-4,6",
                "МастерИМаргарита-Булгаков-1967-4,9",
                "ВластелинКолец-Толкин-1954-4,8",
                "ГарииПоттер-Роулинг-1997-45",
                "ВишневыйСад-Чехов-1904-4,3",
                "НоваяКнига-Автор-2020-4,2"
            };
            Console.WriteLine("==Анализ библиотеки==");
            Console.WriteLine("Книги с рейтингом > 4,5");
            var hightRated = books.Where(b => Convert.ToDouble(b.Split('-')[3]) > 4.5);
            foreach(var hR in hightRated)
            {
                Console.WriteLine($" - {hR.Split('-')[0]}");
            }
            Console.WriteLine("Книги которые были выпучены после 2015 года");
            var year = books.Where(b => Convert.ToInt32(b.Split('-')[2]) > 2015);
            foreach (var y in year)
            {
                Console.WriteLine($" - {y.Split('-')[0]} {y.Split('-')[2]}");
            }
        }
    }
}
