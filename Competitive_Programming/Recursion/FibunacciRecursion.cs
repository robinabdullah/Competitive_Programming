using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programming.Recursion
{
    public class FibunacciRecursion
    {
        public static int Fibunacci(int n)
        {
            if(n <= 1)
                return n;
            int first = Fibunacci(n - 2);
            int second = Fibunacci(n - 1);

            return first + second;
        }
    }
}
