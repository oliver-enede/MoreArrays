using System;

namespace MoreArrays
{
    internal class Program
    {
        public static int SumArray(int[] arr)
        {
            int total = 0;
            // Iterate through the array and add each element to total
            foreach (int num in arr)
            {
                total += num;
            }
            return total;
        }

        public static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine("Sum of values in array: " + SumArray(arr));
            Console.ReadLine();
        }
    }
}