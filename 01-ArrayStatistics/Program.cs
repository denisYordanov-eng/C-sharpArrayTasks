using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ArrayStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ')
                .Select(int.Parse).ToArray();

            long sum = 0;
            double average = 0;
            
            for (int i = 0; i < numbers.Length; i++)
            {  
                sum += numbers[i];
                average = (double)sum / numbers.Length ;
            }

            Console.WriteLine($"Min = {numbers.Min()}");
            Console.WriteLine($"Max = {numbers.Max()}");
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Average = {average}");


        }
    }
}
