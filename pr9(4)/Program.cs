using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr9_4_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string email = "user.example@gmail.com";
            if (email.Contains('@'))
            { 
                int ind = email.IndexOf('@');
                string name = email.Substring(0, ind);
                string star = new string('*', name.Length);
                string domain = email.Substring(ind);
                string Email = star + domain;
                Console.WriteLine(Email);
            }
            else
            {
                Console.WriteLine("Некорректный email");
            }
        }
    }
}
