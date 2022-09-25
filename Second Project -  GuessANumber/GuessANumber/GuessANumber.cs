using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessANumber
{
    internal class GuessANumber
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int computerNumber = random.Next(1, 101);

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;

                Console.Write("Guess a number (1-100): ");

                string playerInput = Console.ReadLine();
                bool isValid = int.TryParse(playerInput, out int playerNumber);

                int difference = playerNumber - computerNumber;

                if (isValid)
                {
                    if (playerNumber == computerNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("You guessed it!");
                        break;
                    }
                    else if (difference >= -99 && difference <= -50)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("Too Low");
                    }
                    else if (difference > -50 && difference <= -25)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("Low");
                    }
                    else if (difference > -25 && difference <= -10)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Getting Closer! (Low)");
                    }
                    else if (difference > -10 && difference <= -1)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Almost guessed it! (Low)");
                    }
                    else if (difference <= 99 && difference >= 50)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Too High");
                    }
                    else if (difference < 50 && difference >= 25)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("High");
                    }
                    else if (difference < 25 && difference >= 10)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Getting Closer! (High)");
                    }
                    else if (difference < 10 && difference >= 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Almost guessed it! (High)");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Invalid input.");
                    }
                }             
            }

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
