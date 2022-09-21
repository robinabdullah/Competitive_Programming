using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programming.Sorting
{
    public class BubbleSort
    {
        /// <summary>
        /// O(n2) comparison based algorithm. very slow approach of sorting
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int[] Bubble(int[] array)
        {
            int temp = 0;
            bool swapped = false;

            do
            {
                swapped = false;
                for (int i = 0; i < array.Length; i++)
                {
                    if (i + 1 < array.Length && array[i] >= array[i + 1])
                    {
                        temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        swapped = true;
                    }
                }
            } while (swapped);

            return array;
        }
    }
}
