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
            bool play = true;

            // At the end of the game, ask user if thy wish to continue
            while (play)
            {
                int[] userInput = CollectInput();

                Random rand = new Random();

                Console.WriteLine("Your random numbers: ");
                for (int i = 0; i < 3; i++) // Change i < val to change number of random numbers generated
                {
                    int output = GetRandom(userInput[0] * userInput[1], userInput[1], rand);
                    Console.WriteLine(output);
                }

                Console.WriteLine("Would you like to play again? (y/n)");
                string continuePlaying = Console.ReadLine();

                if (continuePlaying == "no" || continuePlaying == "n")
                {
                    play = false;
                }
            }
        }

        // Collect user input
        public static int[] CollectInput()
        {
            int sideNumber;
            int diceNumber;
            int[] inputs = new int[2];

            Console.WriteLine("Enter the number of sides on the dice: ");
            string sides = Console.ReadLine();
            Console.WriteLine("Enter the number of dice you want to roll: ");
            string dice = Console.ReadLine();
            Console.WriteLine();

            // User input validation
            int.TryParse(sides, out sideNumber);
            int.TryParse(dice, out diceNumber);
      
            if (sideNumber == 0 || diceNumber == 0)
            {
                Console.WriteLine("Invalid input. Enter sides and dice number as integers.");
                return CollectInput();
            }
            else
            {
                inputs[0] = sideNumber;
                inputs[1] = diceNumber;
                return inputs;
            }       
        }

        // Generate a random number between number of dice (number of dice * 1) and highest possible roll totals (sides * dice)
        public static int GetRandom(int max, int diceNumber, Random rand)
        {
            int number = rand.Next(diceNumber, max + 1);
            return number;
        }

        // Determine max possible
        public static int Roll(int sides, int dice)
        { 
            int maxRoll = sides * dice;
            return maxRoll;
        }
    }
}
