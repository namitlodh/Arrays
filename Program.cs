using System;using System.Collections.Generic;using System.Linq;using System.Text;using System.Threading.Tasks;namespace Arrays_problems{    internal class Program    {        static void Main(string[] args)        {            int number = int.Parse(Console.ReadLine());            int sum = 0;            int m;            while (number > 0)
            {
                m= number%10;
                sum += m;
                number = number/10;
            }            Console.WriteLine($"Sum is = {sum}");            Console.ReadLine();        }    }}