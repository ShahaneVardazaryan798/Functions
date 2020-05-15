using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static ClassLibrary2.Class1;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] x = new int[5, 5];
            Matric(x);
        }
        public static void Matric(int[,] n)
        {
            Random rd = new Random();
            n = new int[5, 5];

            for (int i = 0; i < 5; i++)
            {
                int max = 0;
                for (uint j = 0; j < 5; j++)
                {
                    n[i, j] = rd.Next(0, 100);
                    Console.WriteLine(n[i, j]);
                    //if (n[i, j] > max)
                    //{
                    //    max = n[i, j];

                    //}

                }
                //Console.WriteLine($"{0} rows max = {1}", i, max);
                WriteLine();

            }
        }
    }
}
