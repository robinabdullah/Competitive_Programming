using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programming.Sorting
{
    public class MergeSort
    {
        public static void Sort(int[] array, int leftIndex, int rightIndex)
        {
            if (leftIndex >= rightIndex)
                return;

            int midIndex = (leftIndex + rightIndex) / 2;
            Sort(array, leftIndex, midIndex);
            Sort(array, midIndex + 1, rightIndex);
        }

        private void Merge(int[] array, int leftIndex, int rightIndex)
        {
            int[] arrayNew = new int[array.Length];
            int left = leftIndex;
            int right = rightIndex;
            int index = leftIndex;

            while (left <= right && right <= rightIndex)
            {
                if (array[left] > array[right])
                {
                    arrayNew[index] = array[left];
                    left++;
                }
                else
                {
                    arrayNew[index] = array[right];
                    right++;
                }
                index++;
            }

            //while()

        }
    }
}
