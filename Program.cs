using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1,1,2,1,2,3,3,20, 10, -1};
            int len = arr.Length;
            int max = arr[0]; 
            int min = arr[0] ;
            for (int i = 0; i < len; i++) 
            {
                if (arr[i] >max)
                    max = arr[i];
                else if (arr[i] <min)
                    min = arr[i];
            }
            Console.WriteLine($"maximun element is: {max}");
            Console.WriteLine($"minimum element is: {min}");

            Console.ReadLine();
        }
    }
}
