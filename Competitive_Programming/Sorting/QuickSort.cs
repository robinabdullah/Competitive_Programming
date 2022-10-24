using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programming.Sorting
{
    public class QuickSort
    {
        /// <summary>
        /// very fast algorithom for sorting.
        /// O(n log n) for average case. O (n2) for worst case scenario.
        /// This sorting algorithom is used by default in most programming language.
        /// takes constant amount of memory
        /// </summary>
        /// <param name="array"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public static int[] Sort(int[] array, int start, int end)
        {
            if (start < end)
            {
                int pIndex = Partition(array, start, end);
                Sort(array, start, pIndex - 1);
                Sort(array, pIndex + 1, end);
            }

            return array;
        }
        public static int Partition(int[] array, int start, int end)
        {
            int pivot = array[end];
            int pIndex = start;

            for (int i = start; i < end; i++)
            {
                if (array[i] <= pivot)
                {
                    Utility.Swap(array, i, pIndex);
                    pIndex++;
                }
            }

            Utility.Swap(array, pIndex, end);
            return pIndex;
        }
    }
}
