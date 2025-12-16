using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr9_9_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите слово на английском (строчные буквы): ");
            string words = Console.ReadLine().ToLower();

            StringBuilder ss = new StringBuilder();

            foreach (char c in words)
            {
                if (char.IsLetter(c))
                {
                    char shifted = (char)(c + 3);
                    if (shifted > 'z')
                    {
                        shifted = (char)(shifted - 26); 
                    }
                    ss.Append(shifted);
                }
                else
                {
                    ss.Append(c);
                }
            }
            Console.WriteLine($"Зашифрованное слово: {ss}");
        }
    }
}
