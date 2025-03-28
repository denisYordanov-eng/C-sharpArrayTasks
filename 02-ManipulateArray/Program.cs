using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpMoreTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(' ').ToArray();
                string instruction = command[0];
                switch (instruction)
                {
                    case "Reverse":
                        for (int j = 0; j < input.Length / 2; j++)
                        {
                            string element = input[j];
                            input[j] = input[input.Length - j - 1];
                            input[input.Length - j - 1] = element;
                        }
                        break;
                    case "Distinct":
                         input = input.Distinct().ToArray();
                        break;
                    case "Replace":
                        int index = int.Parse(command[1]);
                        string replaceWord = command[2];
                        input[index] = replaceWord;
                        break;
                }
            }
            Console.WriteLine(String.Join(", ", input));
        }
    }
}
