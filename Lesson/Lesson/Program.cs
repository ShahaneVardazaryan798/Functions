using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 4;
            F(n);

        }
        public static void F(int n)
        {
            if (n <1) return;
          
            F(n - 1);
             WriteLine(n );
           
        }

    }
}
