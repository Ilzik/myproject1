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
            //  сотрудники, должность
            string[] name = {"Хакимзянова Ильзиля Райнуровна", "Иванов Иван Иванович", "Гараева Сюмбель Маратовна",
            "Скребнева Яна Генадьевна", "Габидуллина Зухра Рамилевна", "Хакимзянов Рамиль Райнурович" };

            string[] prof = {"Специалист по информационным системам", "Менеджер", "Специалист по информационным системам",
            "Программист", "Веб разработчик", "Тренер"};

            //  поиск с заданной долностҗю
            Console.Write("Должность: ");
            string job = Console.ReadLine();

            Console.WriteLine("С этой должностью:");
            for (int i = 0; i < name.Length; i++)
            {
                if (prof[i] == job)
                Console.WriteLine(name[i]);
            }

            // одинаковые первые буквы фамилии
            Console.Write("Первая буква фамилии: ");
            char A = Console.ReadLine()[0];

            Console.WriteLine("С этой буквы:");
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i][0] == A)
                    Console.WriteLine(name[i] + " " + prof[i]);
           else
            {
                Console.WriteLine("Нет сотрудникв с фамилией на эту букву");
            }
            }
            

                // по алфавиту
                Console.WriteLine("По алфавиту:");
            Array.Sort(name, prof);

            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i] + " " + prof[i]);
            }
        }
    }
}
