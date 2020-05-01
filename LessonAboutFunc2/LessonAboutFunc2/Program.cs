using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LessonAboutFunc2
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter the number and the persent");
            int a, b;
            CountPersent(a = int.Parse(ReadLine()), b = int.Parse(ReadLine()));
        }
        public static int CountPersent(int a, int b)
        {
            int x = (a * b) / 100;
            WriteLine($"The {b} persent of {a} = " + x);
            return x;
        }
    }
}
