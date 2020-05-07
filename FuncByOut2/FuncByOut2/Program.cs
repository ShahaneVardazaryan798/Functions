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
                arr =new int[10]{15, 10, 12, 15,8,10,45,78,36,0 };
                Write("Arr = " + arr[i]+"\t");
            }
            
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i]==n)
                {
                    
                    count++;
                }
                
            }
            WriteLine("\n"+"Count = " + count);
            int index = 0;
            for (int i = 0; i<arr.Length; i++)
            {
                if(arr[i]==n)
                {
                    index = i+1;
                    count--;
                    do
                    {
                        WriteLine("Index = " + index);
                        break;
                       
                    } while (count==0) ;
                  
                }
                else
                {
                    index = -1;
                }
               
            }
           
            return index;
            ReadLine();
        }
    }
}
