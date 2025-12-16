using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr9_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
                string name = " анна ";
            string city = "москва";
                name = name.Trim().ToLower();
                if (name.Length > 0 && char.IsLetter(name[0]))
                {
                    name = char.ToUpper(name[0]) + name.Substring(1);
                }

                city = city.ToUpper();
                string gotov = $"Привет, {name} из {city}!";

                Console.WriteLine(gotov);
            }
        }

    }
       
    

