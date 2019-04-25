using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            //int.TryParse(userInput, out number);

            //if (number == 0)
            //{
            //    Console.WriteLine("Invalid input.");
            //    return CollectInput();
            //}
            //else
            //{
            //    return number;
            //}

            //todo: add validation
            Console.WriteLine("Enter the number of sides on the dice: ");
            int sideNumber = Convert.ToInt16(Console.ReadLine());

            //todo: add validation
            Console.WriteLine("Enter the number of dice you want to roll: ");
            int diceNumber = Convert.ToInt16(Console.ReadLine());

            int maxRoll = Roll(sideNumber, diceNumber);

            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                int output = GetRandom(maxRoll, diceNumber, rand);
                Console.WriteLine(output);
            }
        }

        public static int GetRandom(int max, int diceNumber, Random rand)
        {
            int number = rand.Next(diceNumber, max + 1);
            return number;
        }

        public static int Roll(int sides, int dice)
        { 
            int maxRoll = sides * dice;
            return maxRoll;
        }
    }
}
