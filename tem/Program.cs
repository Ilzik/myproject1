using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace tem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char Letter = 'a';
            char digit = '2';
            char symbol = '$';


            char heart = '\u2665';
            Console.WriteLine(heart);

            char.IsLetter('H');//проверяет, это буква?
            char.IsDigit('3');//проверяет, это цифра?
            char.ToLower('H'); //к нижнему регистру
            char.ToUpper('a'); //к верхний регистру

            string name = "Ильзиля";
            string group = "223 СИС";
            string emptyString = " ";
            Console.WriteLine(name +emptyString + group);//конкатенация

             //Интерполяция строк
            Console.WriteLine($"Студент {name}, обучается в группе {group}");

            int len = group.Length;  // 7
            char firstLetter = name[0]; //A


            //поиск подстроки
            string sentence = "Кот сидит на трубе";
            int position = sentence.IndexOf("сидит"); //4
            bool contains = sentence.Contains("на"); // true

            //проверка начала и конца строки
            bool start = sentence.StartsWith("Кот"); //начало
            bool end = sentence.EndsWith("трубе"); //конец

            // Изменение регситра
            string mixed = "ПрИвет";
            string lower = mixed.ToLower();
            Console.WriteLine(mixed.ToUpper());
            Console.WriteLine(lower);
             // Удаление лишних пробелов
             string withSpaces = "text" ;
             Console.WriteLine(withSpaces);
            Console.WriteLine(withSpaces.TrimStart()); //удаляет лишние пробелы в начале строки
            Console.WriteLine(withSpaces.TrimEnd());//удаляет лишние пробелы в конце строки




            //замена слова
            string original = "Я люблю яблоки";
            string replaced = original.Replace("яблоки", "груши");
            Console.WriteLine(original);
            Console.WriteLine(replaced);
            //разделение на подстроки
            string kanzTovars = "карандаш, ручка, линейка, тетрадь";
            string[] kanzTovArray = kanzTovars.Split(',');
            //kanxTovArray будет хранить:
            //﻿﻿[0] карандаш
            //﻿﻿[1] ручка
            //﻿﻿[2] линейка
            //[3] тетрадь
            //
            //объединение подстрок (склейка)
            string[] words = { "Привет", "223", "группа!" };
            string sentecnce1=string.Join(" ", words);
            string sentecnce2 = string.Join(", ", words);
            Console.WriteLine(sentecnce1);
            Console.WriteLine(sentecnce2);
            StringBuilder sb = new StringBuilder();
               // быстрое добавление sb. Append("Привет");
            sb.Append(" ");
            sb.Append("мир! ");
            //Вставка в определенную позицию
            sb. Insert(6, "Дорогой");
            ///замена
            sb.Replace( "Дорогой", " любимый");
            string finalString = sb.ToString();
            Console.WriteLine(finalString);

        }
    }
}
