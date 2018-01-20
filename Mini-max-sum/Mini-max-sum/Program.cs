using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Mini_max_sum
{
    class Program
    {
        static void miniMaxSum(int[] arr)
        {
            int[] sums = new int[arr.Length];
            int count = 0;
            int currentSum = 0;
            for (int a = 0; a < arr.Length; a++)
            {
                for (int b = 0; b < arr.Length; b++)
                {
                    if(count != b)
                    {
                        currentSum += Convert.ToInt32(arr[b]);
                    }
                }
                sums[a] = currentSum;
                currentSum = 0;
                count++;
            }
            Console.WriteLine(sums.Min() + " " + sums.Max());
        }

        static void Main(String[] args)
        {
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            miniMaxSum(arr);
        }
    }
}
