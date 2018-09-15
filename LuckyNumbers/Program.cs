using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean appRunState = true;

            do
            { // run state of program/// option to exit program.


                //Global variable declare here

                double jackpot = 3000000;

                int[] randomNumberArray = new int[6];
                int highRange = 0;
                int lowRange = 0;
                int firstNumber = 0;
                int secondNumber = 0;
                int thirdNumber = 0;
                int fourthNumber = 0;
                int fifthNumber = 0;
                int sixthNumber = 0;
                int numberCount = 0;
                int numberEntered = 0;


                String checkForExit = null;


                //INPUTS -get inputs here

                //get low range and high range numbers

                Console.WriteLine("Please enter a starting number");
                lowRange= int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter an ending number");
                highRange = int.Parse(Console.ReadLine());

                //get six guessed numbers and set to array

                numberCount = randomNumberArray.Length;

                for (int i = 0; i < randomNumberArray.Length; i++)
                {
                    
                    Console.WriteLine("Please enter one of your six number guesses");
                    numberEntered = int.Parse(Console.ReadLine());
                    randomNumberArray[i] = numberEntered;
                    numberCount--;
                    Console.WriteLine("you have " + numberCount + " entries left");
                    
                }

                //TEST Code --- display contents of an array
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("array contains");
                Console.WriteLine();
                for (int i = 0; i < randomNumberArray.Length; i++)
                {
                   Console.Write(randomNumberArray[i] + ", ");
                 }
                Console.WriteLine();

                //end test code


                //Console.WriteLine();
                //Console.WriteLine("GitHub is a ROYAL pain");
                //Console.WriteLine();


                //NO CODE BEYOND HERE DANGER

                //EXIT PROGRAM OPTION
                Console.WriteLine();
                Console.WriteLine("Do you wish to play again? Enter \"Yes\" or \"No\"");

                checkForExit = Console.ReadLine();
                checkForExit = checkForExit.ToLower();

                if (checkForExit.Equals("no"))
                {
                    appRunState = false;
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Thanks for playing!");
                    Console.WriteLine();
                   // good bye message  exit system here !

                } else { Console.WriteLine("");
                        Console.WriteLine("");
                        }

            } while (appRunState);



        }// end run state loop
    }
} 
