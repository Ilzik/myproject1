using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr8_4_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] doska = new int[3, 3];
            Random random = new Random();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    doska[i, j] = random.Next(0, 3);
                }
            }

            Console.WriteLine("Крестики-нолики");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    char symbol = ' ';
                    switch (doska[i, j])
                    {
                        case 1:
                            symbol = 'X';
                            break;
                        case 2:
                            symbol = 'O';
                            break;
                        case 0:
                            symbol = '0';
                            break;
                    }
                    Console.Write(symbol + " ");
                }
                Console.WriteLine();
            }

            string win = "Победителя нет";

           
            for (int stroka = 0; stroka < 3; stroka++)
            {
                if (doska[stroka, 0] == doska[stroka, 1] && doska[stroka, 1] == doska[stroka, 2])
                {
                    if (doska[stroka, 0] == 1) win = "Победили крестики (X)";
                    if (doska[stroka, 0] == 2) win = " Победили нолики (O)";
                }
            }

            for (int stolb = 0; stolb < 3; stolb++)
            {
                if (doska[0, stolb] == doska[1, stolb] && doska[1, stolb] == doska[2, stolb])
                {
                    if (doska[0, stolb] == 1) win = " Победили крестики (X)";
                    if (doska[0, stolb] == 2) win = "Победили нолики (O)";
                }
            }

            if (doska[0, 0] == doska[1, 1] && doska[1, 1] == doska[2, 2])
            { 
                if (doska[0, 0] == 1) win = "Победили крестики (X)";
                if (doska[0, 0] == 2) win = "Победили нолики (O)";
            }

            if (doska[0, 2] == doska[1, 1] && doska[1, 1] == doska[2, 0])
            {
                if (doska[0, 2] == 1) win = "Победили крестики (X)";
                if (doska[0, 2] == 2) win = " Победили нолики (O)";
            }

            Console.WriteLine(" " + win);
            Console.WriteLine();
        }
    }
}   
   
