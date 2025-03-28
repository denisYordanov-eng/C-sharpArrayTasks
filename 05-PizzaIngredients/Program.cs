using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_PizzaIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ingrediments = Console.ReadLine().Split(' ').ToArray();

            int lengthOfWords = int.Parse(Console.ReadLine());


           var add = new List<string>();
           byte ingredimentCounter = 0;
            for (int i = 0; i < ingrediments.Length; i++)
            {


                if (ingrediments[i].Length == lengthOfWords && ingredimentCounter < 10)
                {
                    string currentIngrediment = ingrediments[i];
                    add.Add(currentIngrediment);
   
                    Console.WriteLine($"Adding {currentIngrediment}.");
                    ingredimentCounter++;
                }
            }
            
            Console.WriteLine($"Made pizza with total of {ingredimentCounter} ingredients.");
                Console.Write("The ingredients are: {0}.",String.Join(", ",add));
        }
    }
}
