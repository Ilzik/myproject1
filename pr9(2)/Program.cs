using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr9_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "С# это современный язык программирования.";
            int simvol = text.Length;
            Console.WriteLine($"Общее количество символов: {simvol}");
            string[] words = text.Split(' ');
            int count = words.Length;
            Console.WriteLine($"Количество слов: {count}");
            int index = text.IndexOf("язык");
            Console.WriteLine($"Позиция слова 'язык': {index}");
            bool starts= text.StartsWith("С#");
            Console.WriteLine($"Начинается с 'С#': {starts}");
        }
    }
}
