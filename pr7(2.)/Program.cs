using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr7_2._
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words= new string[] {"A","Б","В","Г","Д","Е"};
            Console.WriteLine("Массив: ");
            for( int i=0;i<words.Length;i++)
            {
                Console.Write(words[i]+ " ");
            }
            int lon= 0;
            for(int i = 0; i < words.Length; i++)
            {
                if (words[i].Length>lon)
                {
                    lon = words[i].Length;
                   
                }
            } Console.WriteLine(lon);

        }
    }
}
