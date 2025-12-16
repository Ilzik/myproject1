using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr8_5_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] array = new int[4, 4];
            Random random = new Random();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    array[i, j] = random.Next(1, 101);
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }


            Console.WriteLine("Седловые точки:");
            bool b = false;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    int a = array[i, j];


                    bool MinStr = true;
                    for (int col = 0; col < 4; col++)
                    {
                        if (array[i, col] < a)
                        {
                            MinStr = false;
                            break;
                        }
                    }


                    bool Max = true;
                    for (int row = 0; row < 4; row++)
                    {
                        if (array[row, j] > a)
                        {
                            Max = false;
                            break;
                        }
                    }


                    if (MinStr && Max)
                    {
                        Console.WriteLine($"[{i},{j}] = {a}");
                        b = true;
                    }
                }
            }

            if (!b)
            {
                Console.WriteLine("Нет седловой точки");
            }
        }
    }
}



