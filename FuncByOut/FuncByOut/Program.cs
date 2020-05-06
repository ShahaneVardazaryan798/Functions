using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace FuncByOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] b;
            Integer(out  b);  
        }
        public static int Integer(out int[]a)
        {
            Random rd = new Random();
            a = new int[10];
            for (int i = 0; i <a.Length; i++)
            {
                a[i] = rd.Next(-100, 100);
                Write(a[i] + "\t");
            }
            int max=-1;
            for (int i = 0; i <a.Length; i++)
            {
                if(a[i]>max)
                {
                    max = a[i];
                }
            }
            WriteLine("\n Max = " + max);
            int min = 1;
            for (int i = 0; i < a.Length; i++)
            {
                if(a[i]<min)
                {
                    min = a[i];
                }
            }
            WriteLine("Min = " + min);
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            WriteLine("Sum = " + sum);
            WriteLine("Midlle value = " + sum / 10);
            int middle = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if(a[i]<0)
                {
                    sum += a[i];
                    middle = sum / i;
                }
            }
            WriteLine("The negative sum = " + sum);
            WriteLine("The middle of negative nums = " + middle);

            return 0;
        }
    }
}
