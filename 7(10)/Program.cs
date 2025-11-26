using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_10_
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            string[] students =
            {
             "Хкимзянова Ильзиля,5,5,5,5",
             "Гараева Сюмбель,4,5,5,5",
             "Хасанова Илюза,5,3,4,5",
             "Андреева Татьяна,5,5,5,5",
             "Нуруллин Рустем,5,4,5,5",
             "Замалетдинов Адель,5,4,4,4",
             "Хакимзянов Рамиль,2,2,2,2"


};

            string[] subjects = { "Высшая математика", "Информационные технологии", "ОАИП", "История" };
            Console.WriteLine("База данных студентов(высшая математика, информационные технологии, ОАИП, история):");
            foreach (string student in students)
            {
                string[] students = student.Split(',');
                Console.WriteLine($"{students[0]}, {students[1]}, {students[2]}, {students[3]}, {students[4]}");

            }//поиск студентов со ср баллов выше указанного
            Console.WriteLine("Введите средний балл для поиска: ");
            double num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Студенты со средним баллом выше {num}:");
            foreach (string student in students)
            {
                string[] students = student.Split(',');
                string name = students[0];
                double sum = 0;
                for (int i = 1; i < students.Length; i++)
                {
                    sum += Convert.ToDouble(students[i]);
                }
                double average = sum / (students.Length - 1);
                if (average > num)
                {
                    Console.WriteLine($"{name}, Средний балл: {average}");
                }

            }
            Console.WriteLine("Предмет с наивысшим средним баллом: ");
            double highestAverage = 0;
            string topSubject = "";
            for (int i = 0; i < subjects.Length; i++) //по предмету
            {
                double sum = 0;
                for (int j = 0; j < students.Length; j++)//по студенту
                {
                    string[] students = students[j].Split(',');
                    sum += Convert.ToDouble(students[i + 1]);
                }
                double average = sum / students.Length;
                if (average > highestAverage)
                {
                    highestAverage = average;
                    topSubject = subjects[i];
                }
            }
            Console.WriteLine($"{topSubject}, Средний балл: {highestAverage}");
            Console.WriteLine();
            Console.WriteLine("Рейтинг студентов по успеваемости: ");
            string[] rating = new string[students.Length];

            for (int i = 0; i < students.Length; i++)
            {
                string[] students = students[i].Split(',');
                string name = students[0];

                double sum = 0;
                for (int j = 1; j < students.Length; j++)
                {
                    sum += Convert.ToDouble(students[j]);
                }
                double average = sum / (students.Length - 1);

                rating[i] = $"{name},{average:F2}";
            }
            for (int i = 0; i < rating.Length - 1; i++)
            {
                for (int j = i + 1; j < rating.Length; j++)
                {
                    string[] students = rating[i].Split(',');
                    string[] students1 = rating[j].Split(',');

                    double avg1 = Convert.ToDouble(students[1]);
                    double avg2 = Convert.ToDouble(students1[1]);

                    if (avg1 < avg2)
                    {
                        string temp = rating[i];
                        rating[i] = rating[j];
                        rating[j] = temp;
                    }
                }
            }
            for (int i = 0; i < rating.Length; i++)
            {
                string[] students = rating[i].Split(',');
                Console.WriteLine($"{i + 1} - {students[0]}, {students[1]}");
            }
            foreach (string student in students)
            {
                string[] students = student.Split(',');
                string name = students[0];
                double sum = 0;
                for (int i = 1; i < students.Length; i++)
                {
                    sum += Convert.ToDouble(students[i]);
                }
                double average = sum / (students.Length - 1);
                if (average == 5)
                { Console.WriteLine($"{name} - Отличник"); }
                else if (average < 3) { Console.WriteLine($"{name} - Двоечник"); }
            }

        }
    }
}
