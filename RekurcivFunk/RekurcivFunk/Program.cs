using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace RekurcivFunk
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter the first num");
            int x = int.Parse(ReadLine());
            WriteLine("Enter the second num");
            int y = int.Parse(ReadLine());
            RecFunc(x, y);
        }
        public static int RecFunc(int a,int b)
        {    
            int result = 0;
            a--;
            result = b;
            if (a == 0) return result;
            WriteLine("Result = " +  (result +=RecFunc( a, b)));
            return result; 
           
                
           
           

        }
    }
}
