using Competitive_Programming.Math;
using Competitive_Programming.Recursion;
using Competitive_Programming.Sorting;

namespace Competitive_Programming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] { 7, 2, 1, 6, 8, 5, 3, 4 };
            var sorted = QuickSort.Sort(array , 0, array.Length - 1);
            foreach (var item in sorted)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Hello, World!");
            Console.ReadKey();
        }
    }
}