using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _06_Heists
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Console.ReadLine().Split(' ')
                .Select(int.Parse).ToArray();

            int jewels = n[0];
            int gold = n[1];

            long spendings = 0L;
            long earnings = 0L;
            string[] input = Console.ReadLine().Split().ToArray();
            while (input[0] != "Jail" && input[1] != "Time")
                {
                int expenses = int. Parse(input[1]);
                spendings += expenses;
                for (int i = 0; i < input[0].Length; i++)
                {
                    if (input[0][i] == '%')
                    {
                        earnings += jewels;
                    }
                    else if (input[0][i]== '$')
                    {
                        earnings += gold;
                    }

                }

                input = Console.ReadLine().Split().ToArray();
            }
            long diff = Math.Abs(earnings - spendings);
            if(earnings >= spendings)
            {
                Console.WriteLine($"Heists will continue. Total earnings: {diff}.");
            }
            else
            {
                Console.WriteLine($"Have to find another job. Lost: {diff}.");
            }
        }
    }
}
