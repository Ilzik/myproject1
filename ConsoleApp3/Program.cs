using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
       
            static void Main()
            {
                int[,] board = new int[3, 3];
                Random random = new Random();

                // Заполняем массив случайными числами 0, 1 или 2
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        board[i, j] = random.Next(0, 3);
                    }
                }

                Console.WriteLine("Игровое поле:");
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        char symbol = ' ';
                        switch (board[i, j])
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

                // Проверка строк
                for (int row = 0; row < 3; row++)
                {
                    if (board[row, 0] == board[row, 1] && board[row, 1] == board[row, 2])
                    {
                        if (board[row, 0] == 1) win = "Результат: Победили крестики (X)";
                        if (board[row, 0] == 2) win= "Результат: Победили нолики (O)";
                    }
                }

                // Проверка столбцов
                for (int col = 0; col < 3; col++)
                {
                    if (board[0, col] == board[1, col] && board[1, col] == board[2, col])
                    {
                        if (board[0, col] == 1) win = "Результат: Победили крестики (X)";
                        if (board[0, col] == 2) win = "Результат: Победили нолики (O)";
                    }
                }

                // Проверка диагоналей
                if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
                {
                    if (board[0, 0] == 1) win = "Результат: Победили крестики (X)";
                    if (board[0, 0] == 2) win = "Результат: Победили нолики (O)";
                }

                if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
                {
                    if (board[0, 2] == 1) win = "Результат: Победили крестики (X)";
                    if (board[0, 2] == 2) win = "Результат: Победили нолики (O)";
                }

                Console.WriteLine(" " + win);
                Console.WriteLine();
            }
        }
    }
    

