using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr7_5_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sotryd =
            {
            "Хакимзянова Ильзиля Райнуровна-СИС",
            "Гараева Сюмбель Маратовна-СИС",
            "Скребнева Яна Генадьевна-Программист",
            "Габидуллина Зухра Рамилевна-Веб разработчик",
            "Хакимзянов Рамиль Райнурович-Тренер",
            "Хасанова Илюза Фидаилевна-СИС",
            "Скребнева Аделина Генадьевна-Программист",
            };

            Console.WriteLine("==Анализ сотрудников==");

            Console.WriteLine("Сотрудники с должностью СИС:");
            var SIS = sotryd.Where(b => b.Split('-')[1] == "СИС");
            foreach (var sis in SIS)
            {
                Console.WriteLine($" - {sis.Split('-')[0]} {sis.Split('-')[1]}");
            }
            Console.WriteLine("Сотрудники с фамилией на букву 'Х':");
            var family = sotryd.Where(e => e.Split('-')[0].StartsWith("Х"));
            foreach (var fam in family)
            {
                Console.WriteLine($" - {fam.Split('-')[0]}");
            }

            
            Console.WriteLine("По алфавиту:");
            var alfavit = sotryd.OrderBy(e => e.Split('-')[0]);
            foreach (var alf in alfavit)
            {
                Console.WriteLine($" - {alf.Split('-')[0]} - {alf.Split('-')[1]}");
            }

        }
    }
}
