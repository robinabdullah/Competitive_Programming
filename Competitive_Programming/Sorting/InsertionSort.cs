using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programming.Sorting
{
    public class InsertionSort
    {
        public static int[] EfficientOne(int[] array)
        {
            int length = array.Length;
            for (int i = 0; i < length; i++)
            {
                int hole = i;
                int value = array[i];
                while(hole > 0 && array[hole-1] > value)
                {
                    array[hole] = array[hole - 1];
                    hole--;
                }
                array[hole] = value;
            }

            return array;
        }
        public static int[] Sort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (array[i] < array[j])
                    {
                        int index = i - 1;
                        int value = array[i];
                        while (index >= j)
                        {
                            array[index + 1] = array[index];
                            index--;
                        }
                        array[j] = value;
                        break;
                    }
                }
            }

            return array;
        }
    }
}
