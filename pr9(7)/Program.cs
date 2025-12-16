using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr9_7_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder table = new StringBuilder();
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    table.Append($"{i} x {j} = {i * j}");
                    table.AppendLine(); 
                }
            }
            Console.WriteLine(table.ToString());
        }
    }
}
