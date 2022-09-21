using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programming.Recursion
{
    public class FactorialOfNNumbers
    {
        public static int FactorialOfN(int n)
        {
            if (n == 0)
                return 1;

            return n * FactorialOfN(n - 1);
        }
    }
}
