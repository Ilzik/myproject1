using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr9_3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string phone = "+79161234567";
            string one = phone.Substring(0, 2); 
            string two = phone.Substring(2, 3); 
            string three = phone.Substring(5, 3); 
            string four = phone.Substring(8, 2); 
            string five = phone.Substring(10, 2); 

            string number = $"{one} ({two}) {three}-{four}-{five}";
            Console.WriteLine(number);
        }
    }
}
