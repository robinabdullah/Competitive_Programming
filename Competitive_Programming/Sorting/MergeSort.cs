using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programming.Sorting
{
    public class MergeSort
    {
        public static int[] Sort(int[] array, int n)
        {
            if (array.Length != 2)
            {
                var divided = array.Take(n / 2).ToArray();

                return Sort(divided, divided.Length);
            }

            for (int i = 0; i < n; i++)
            {
                if (array[i] > array[i+1])
                {

                }

            }
            if (array[0] > array[1])
            {
                return Utility.Swap(array, 0, 1);
            }
            else return array;
            
        }
    }
}
