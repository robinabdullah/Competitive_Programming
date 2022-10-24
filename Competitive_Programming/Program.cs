using Competitive_Programming.Math;
using Competitive_Programming.Recursion;
using Competitive_Programming.Sorting;

namespace Competitive_Programming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sorted = QuickSort.Sort(new int[] { 7, 2, 4, 1, 5, 3, 6 }, 0, 6);
            foreach (var item in sorted)
            {
                Console.Write(item + " ");
            }
            //Console.WriteLine(InsertionSort.Sort(new int[] { 3, 44, 38, 5, 47, 15, 36, 26, 27, 2, 46, 4, 19, 50, 48 }));
            Console.WriteLine();
            Console.WriteLine("Hello, World!");
            Console.ReadKey();
        }
    }
}