using System;using System.Collections.Generic;using System.Linq;using System.Text;using System.Threading.Tasks;namespace Arrays_problems{    internal class Program    {        static void Main(string[] args)        {
            Console.WriteLine("Enter rows:");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter columns:");
            int col = Convert.ToInt32(Console.ReadLine()); 
            int[,] Matrix = new int[row, col];
            Console.Write("Enter the elements of matrix: ");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("\nMatrix: ");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(Matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < row; i++)
            {
                int sum = 0;
                for (int j = 0; j < col; j++)
                {
                    sum += Matrix[i, j];
                }
                Console.WriteLine($"Sum of row [{i + 1}] is {sum}");
            }
            Console.ReadLine();
        }    }}