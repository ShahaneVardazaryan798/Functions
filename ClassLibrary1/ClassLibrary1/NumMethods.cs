using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public static class NumMethods
    {
        public static int DigitCount(int n)
        {
            if (n / 10 ==0) return 1;
            return DigitCount(n / 10) + 1;
        }
    }
}
