using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programming.Recursion
{
    public class SumOfNNumbers
    {
        public static int PrintSumOfN(int n)
        {
            if (n == 0)
                return 0;

            return n + PrintSumOfN(n - 1);
        }
    }
}
