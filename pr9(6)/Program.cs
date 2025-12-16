using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr9_6_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= 10; i++)
            {
                sb.Append(i);
                sb.Append(",");
            }
            if (sb.Length > 0)
            {
                sb.Length--; 
            }

            sb.Insert(0, "Числа: ");
            sb.Append(".");

            Console.WriteLine(sb.ToString());
        }
    }
}
