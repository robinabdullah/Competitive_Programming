using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programming.Math
{
    public class Fibunacci
    {
        public static void FibunacciNumberPrint(int n)
        {
            int firstNumber = 0, secondNumber = 1;

            Console.Write(firstNumber + " ");
            Console.Write(secondNumber + " ");

            for (int i = 3; i < n + 2; i++)
            {
                int next = firstNumber + secondNumber;
                Console.Write(next + " ");
                firstNumber = secondNumber;
                secondNumber = next;
            }
        }
    }
}
