using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programming.Sorting
{
    public class Selection_Sort
    {
        public static int[] Sort(int[] array)
        {
            int j = 0, minIndex=0;
            for (int i = 0; i < array.Length-1; i++)
            {
                minIndex = i;
                for (j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[minIndex])
                        minIndex = j;
                }
                if (minIndex != i)
                    swap(array, minIndex, i);
            }

            return array;
        }
        public static void swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
