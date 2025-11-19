using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr7_4_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 0, 2, 0, 3, 0, 4, 0, 5 };
            Console.WriteLine("Массив: ");
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write(num[i] + " ");
            }
            Console.WriteLine( );

            // Считаем количество ненулевых элементов
            int count = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] != 0)
                    count++;
            }

            // Создаем новый массив без нулей
            int[] result = new int[count];
            int index = 0;

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] != 0)
                {
                    result[index] = num[i];
                    index++;
                }
            }

            Console.Write("Массив без нулей: ");
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i]+ " ");
                   
            }
        }
    }
}
    

