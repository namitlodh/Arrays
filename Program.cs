using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_problems
{
    internal class Program
    {
        static void CountOccurrences(int[] arr, int len)
        {
            Dictionary<int, int> elementCount = new Dictionary<int, int>();

            for (int i = 0; i < len; i++)
            {
                if (elementCount.ContainsKey(arr[i]))
                {
                    elementCount[arr[i]]++;
                }
                else
                {
                    elementCount.Add(arr[i], 1);
                }
            }
            Console.WriteLine("Unique elements in the array are: ");
            foreach (var entry in elementCount)
            {
                Console.WriteLine($"{entry.Key}");
            }
        }

        static void Main(string[] args)
        {
            int[] arr = { 1,1,2,1,2 };
            int n = arr.Length;
            CountOccurrences(arr, n);
            Console.ReadLine();
        }
    }
}
