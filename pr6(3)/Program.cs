using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr6_3_
{
    internal class Program
    {
        static void Main(string [] args)
        {
            int sum = 0;
            int a;
            Console.WriteLine("Введите числа");
            do
            {
                a = Convert.ToInt32(Console.ReadLine());
                if (a > 0)
                { sum+=a; }
            } while (a >= 0);     
           Console.WriteLine(sum);
        } 
    }
}
