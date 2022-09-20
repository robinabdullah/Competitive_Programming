using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programming.Math
{
    public class Palindrome
    {
        public static bool IsPalindrome(int x)
        {
            string toCheck = x.ToString();
            int count = toCheck.Count();
            for (int i = 0; i < count; i++)
            {
                if (toCheck[i] == toCheck[count - 1 - i])
                    continue;
                else
                    return false;
            }

            return true;
        }
    }
}
