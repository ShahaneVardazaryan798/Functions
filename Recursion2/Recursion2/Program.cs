using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Recursion2
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter the num");
            int y = int.Parse(ReadLine());
            RecFunc(ref y);
        }
        public static int RecFunc(ref int  n)
        {
            
            if (n < 0) return 0;
            int x = 0;
            int a = 0;
            x = n / 10;
            a = 1;
            
            RecFunc(ref n);
            a += 1;
             return a;
            

        }
    }
}
