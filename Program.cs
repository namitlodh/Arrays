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
            for(int i=0; i<rows; i++)
            {
                for(int j=0; j<rows; j++)
                {
                    if (i == 0 || j == 0 || i == rows - 1 || j == rows - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
