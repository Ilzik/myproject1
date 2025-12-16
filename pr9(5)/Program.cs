using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr9_5_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите слово: ");
            string word = Console.ReadLine();
            word = word.ToLower().Trim();

            bool Palindrome = true;
            for (int i = 0; i < word.Length / 2; i++)
            {
                if (word[i] != word[word.Length - 1 - i])
                {
                    Palindrome = false;
                    break;
                }
            }
            Console.WriteLine($"Словои {(Palindrome ? "является" : "не является")} палиндромом");
        }
    }
}
