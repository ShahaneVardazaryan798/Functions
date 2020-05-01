using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace LessonAoutFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter the Num you want");
            int n;
            CountSqrt(n=int.Parse(ReadLine()));
        }
        public static int CountSqrt(int n)
        {
            int result=0;
            for(int i=1;i<n;i++)
            {

                result = i * i;
                WriteLine($"{i}-i qarakusin ="+ result); 
            }
            return result;
        }

    }
}
