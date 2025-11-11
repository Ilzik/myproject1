using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr6_5_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            do
            {
                a = Convert.ToInt32(Console.ReadLine());
                if(a<10)
                { Console.WriteLine("Введите другое число"); }

            } while (a < 10); 
        }
    }
}
