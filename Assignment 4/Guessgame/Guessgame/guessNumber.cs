using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessgame
{
    class guessNumber
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Welcome to Guess a number game (1-10) with in 4 attempts.");
                System.Random r = new Random(); //instantiate the random class
                int guess = r.Next(1, 10); //declaring variable for the random number;

                bool correctGuess = false; //declare a variable 
                for (int i = 1; i <= 4; i++) //set counter
                {
                    Console.Write("Please enter your " + i + ": guess: ");
                    int num = Convert.ToInt32(Console.ReadLine()); // declare a variable and receive the user input
                    if (num == guess)
                    {
                        Console.WriteLine("Congrats! You have guessed the number correctly");
                        correctGuess = true;
                        Console.ReadLine();
                        break;
                    }
                    
                    bool bMoveHigher = false;
                    if (guess > num)
                        bMoveHigher = true;
                    
                    {
                        if (bMoveHigher == false)
                            Console.WriteLine("The entered number is higher");
                        else
                            Console.WriteLine("The  entered number is lower");
                    }
                }
           
                if (correctGuess == false)
                {
                    Console.WriteLine("Sorry, you didn't guess it right. The correct number is: " + guess);
                    Console.ReadLine();
                }
            }
        }
    }
}