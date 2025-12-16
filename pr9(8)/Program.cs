using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr9_8_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruits = "яблоко, банан, апельсин,киви, груша";
            string[] fruit = fruits.Split(',');
            for (int i = 0; i < fruit.Length; i++)
            {
                fruit[i] = fruit[i].Trim();
            }
            Array.Sort(fruit);
            string result = string.Join("; ", fruit);
            Console.WriteLine(result);
        }
    }
}
