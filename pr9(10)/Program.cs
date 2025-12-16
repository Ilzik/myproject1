using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr9_10_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 3; i++)
            { char letter = (char)random.Next('a', 'z' + 1);
                sb.Append(letter);
            }
            for (int i = 0; i < 3; i++)
            { char digit = (char)random.Next('0', '9' + 1);
                sb.Append(digit);
            }
            for (int i = 0; i < 2; i++)
            { char symbol = (char)random.Next('A', 'Z' + 1);
                sb.Append(symbol);
            }
            for (int i = sb.Length - 1; i > 0; i--) 
            { int j = random.Next(0, i + 1);
                char temp = sb[i];
                sb[i] = sb[j];
                sb[j] = temp;
            }
            Console.WriteLine("Сгенерированный пароль:"+ sb.ToString());

        }
    }
}
