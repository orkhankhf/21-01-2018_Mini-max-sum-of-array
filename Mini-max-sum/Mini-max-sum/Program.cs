using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Mini_max_sum
{
    class Program
    {
        static void Main(String[] args)
        {
            string[] arr_temp = Console.ReadLine().Split(' ');
            long[] arr = Array.ConvertAll(arr_temp, Int64.Parse);
            long minSum = arr.Sum() - arr.Max();
            long maxSum = arr.Sum() - arr.Min();
            Console.WriteLine("{0} {1}", minSum, maxSum);
        }
    }
}
