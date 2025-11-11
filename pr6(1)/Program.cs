using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr6_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            do
            {
                Console.WriteLine("Введите ваш пароль");
                num=Convert.ToInt32(Console.ReadLine());
            }while (num!=1234) ;
            Console.WriteLine("Вы ввели правильный пароль");
        }
    }
}
