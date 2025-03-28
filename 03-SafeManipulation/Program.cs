using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_SafeManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();

            while (true)
            {
                string[] command = Console.ReadLine().Split(' ').ToArray();
                string instruction = command[0];
                if (instruction == "END")
                {
                    break;
                }
                switch (instruction)
                {
                    case "Distinct":
                        input = input.Distinct().ToArray();
                        break;
                    case "Reverse":
                        for (int i = 0; i < input.Length/2;  i++)
                        {
                            string temp = input[i];
                            input[i] = input[input.Length - i - 1];
                            input[input.Length - i - 1] = temp;
                        }
                        break;
                    case "Replace":
                        int index = int.Parse(command[1]);
                        string changeWord = command[2];
                        if (index < 0 || index >= input.Length)
                        {
                            Console.WriteLine("Invalid input!");  
                        }
                        else
                        {
                            input[index] = changeWord; 
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid input!");
                        break;
                       
                }
                
            }
            Console.WriteLine(String.Join(", ", input));
        }
    }
}
