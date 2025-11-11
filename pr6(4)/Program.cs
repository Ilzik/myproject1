using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr6_4_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a;
            do{
                Console.WriteLine("Привет!");
                Console.WriteLine("Вывести еще раз? 1.Yes 2.No");
                a = Convert.ToString(Console.ReadLine());
            }while (a == "1") ;
        }
    }
}
