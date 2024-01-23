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
            int rows = Convert.ToInt32(Console.ReadLine());
            for(int i=rows; i>0; i--)
            {
                for(int j=0; j<i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
