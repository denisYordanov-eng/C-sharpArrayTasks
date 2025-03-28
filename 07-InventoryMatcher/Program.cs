using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_InventoryMatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] product = Console.ReadLine().Split(' ').ToArray();

            long[] quantities = Console.ReadLine()
                .Split(' ').Select(long.Parse).ToArray();

            var prices = Console.ReadLine()
                .Split(' ').Select(decimal.Parse).ToArray();

            
            string[] input = Console.ReadLine().Split(' ').ToArray();
            while (input[0] != "Done")
            {

                for (int i = 0; i < product.Length; i++)
                {
                    if (input[0] == product[i])
                    {
                        Console.WriteLine("{0} costs: {1}; Available quantity: {2}", 
                            product[i], prices[i], quantities[i]);
                        break;
                    }
                }
                input = Console.ReadLine().Split(' ').ToArray();
            }
        }

      
    }
}
