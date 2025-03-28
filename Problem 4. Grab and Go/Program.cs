using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Grab_and_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArray = Console.ReadLine()
                .Split(' ').Select(int.Parse).ToArray();

            int searchNumber = int.Parse(Console.ReadLine());


            long sum = 0L;
            bool numberIsFound = false;
            int specialCounter = 0;
            int index = 0;
            for (int i = numbersArray.Length - 1; i >= 0; i--)
            {
                if (numbersArray[i] == searchNumber)
                {
                    specialCounter++;
                    if (specialCounter <= 1)
                    {
                        index = i;
                        numberIsFound = true;
                        for (int j = 0; j < i; j++)
                        {
                            sum += numbersArray[j];
                        }
                    }
                }
            }
                if (numberIsFound)
                {
                    Console.WriteLine(sum);
                }
                else
                {
                    Console.WriteLine("No occurrences were found!");
                }

            

        }

    }
}
    