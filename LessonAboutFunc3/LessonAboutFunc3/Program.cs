using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LessonAboutFunc3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            CountAreaOfRect(a = int.Parse(ReadLine()), b = int.Parse(ReadLine()));
        }
        public static double CountAreaOfRect(int a,int b)
        {
            int result=0;
            string s = "*";
            for(int i=0;i<a-1;i++)
            {
                Write(s);
            }
            for(int i=1; i>b; i++)
            {
                WriteLine(s);
            }
            for (int i = 0; i < a - 1; i++)
            {
                Write(s);
            }
                         

             
            return result;
        } 
            
            
           
    }
}
