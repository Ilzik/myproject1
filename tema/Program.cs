using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //объявляем массив
            int[] numbers = new int[10];
            //Заполняем мссив от 1 до 10
            for (int i=0; i<numbers.Length; i++)
            {  numbers[i] = i+1; }
            Console.WriteLine("Массив : ");
            //Выводим массив
            for (int i = 0; i < numbers.Length; i++)
            { Console.Write(numbers[i] + " "); }
             //сумма элементов массива
             int sum = 0;
             for (int i=0; i<numbers.Length; i++)
            { sum=sum+numbers[i]; }
            //произведение
            int proixv = 1;
            for (int i = 0; i < numbers.Length; i++)
            { proixv = proixv * numbers[i]; }
            double average=sum/ numbers.Length; //вычисление среднего арифимитечкого
            Console.WriteLine("Сумма: " + sum);
            Console.WriteLine("Произведение: " + proixv);
            Console.WriteLine("Среднее: " + average);
        }
       
    }
}
