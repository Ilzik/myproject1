using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr8_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = {
                {1,2,3,4},
                {5,6,7,8},
                {9,10,11,12},
                {13,14,15,16}
            };

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                { Console.Write(matrix[i, j] + " "); }
                Console.WriteLine();
            }
        }
    }
}
