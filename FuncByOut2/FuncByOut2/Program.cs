using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace FuncByOut2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] b;
            int x;
            CountByParameter(out b, out x);
        }
        public static int CountByParameter(out int[]arr,out int n)
        {
            Random rd = new Random();
            WriteLine("Enter the num");
            n = int.Parse(ReadLine());
            arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rd.Next(-100, 100);
                Write("Arr = " + arr[i]+"\t");
            }
            
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i]==n)
                {
                    count = 0;
                    count++;
                }
                
            }
            WriteLine("Count = " + count);
            int index = 0;
            for (int i = 0; i<arr.Length; i++)
            {
                if(arr[i]==n)
                {
                    index = i;
                   
                }
                else
                {
                    index = -1;
                }

            }
            WriteLine("Index = " + index);

            return index;
        }
    }
}
