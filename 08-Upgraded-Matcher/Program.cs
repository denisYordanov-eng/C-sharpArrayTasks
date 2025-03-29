using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Upgraded_Matcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] product = Console.ReadLine().Split(' ').ToArray();

            long[] quantitiesInput = Console.ReadLine()
                .Split(' ').Select(long.Parse).ToArray();

            var prices = Console.ReadLine()
                .Split(' ').Select(decimal.Parse).ToArray();

            long[] quantities = new long[product.Length];
            for (int i = 0; i < quantitiesInput.Length; i++)
            {
                quantities[i] = quantitiesInput[i];
            }

            string[] input = Console.ReadLine().Split(' ').ToArray();

            while (input[0] != "done")
            {
                int inputIndex = Array.IndexOf(product, input[0]);
                long wantQuantity = long.Parse(input[1]);

                if (wantQuantity <= quantities[inputIndex])
                {
                    decimal finalPrice = wantQuantity * prices[inputIndex];
                    Console.WriteLine("{0} x {1} costs {2}"
                        , input[1], wantQuantity, Math.Round(finalPrice, 2));

                    quantities[inputIndex] = quantities[inputIndex] - wantQuantity;
                }
                else
                {
                    Console.WriteLine("We do not have enough {0}", product[inputIndex]);
                }

                input = Console.ReadLine().Split(' ').ToArray();
            }
        }
    }
}
