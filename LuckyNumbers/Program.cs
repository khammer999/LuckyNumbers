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
            { // run state of program/// option to exit loop.


                //Global variable declare here

                double jackpot = 3600;

                int[] randomNumberArray = new int[6];
                int[] selectedNumberArray = new int[6];

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
                int numberOfMatches = 0;


                String checkForExit = null;

               

                //INPUTS -get inputs here

                //get low range and high range numbers

                Console.WriteLine("Please enter a starting number");
                lowRange= int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter an ending number");
                highRange = int.Parse(Console.ReadLine());


                //INPUT
                //get six guessed numbers and set to array

                numberCount = selectedNumberArray.Length;

                for (int i = 0; i < selectedNumberArray.Length; i++)
                {
                    
                    Console.WriteLine("Please enter one of your six number guesses");
                    numberEntered = int.Parse(Console.ReadLine());

                    while ((numberEntered < lowRange)|| (numberEntered > highRange)){

                        Console.WriteLine("Please enter a valid number");
                        numberEntered = int.Parse(Console.ReadLine());
                    }
                                                                       
                    selectedNumberArray[i] = numberEntered;
                    numberCount--;
                    Console.WriteLine("you have " + numberCount + " entries left");
                    
                }

                //TEST Code --- display contents of an array
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("array contains");
                Console.WriteLine();
                for (int i = 0; i < selectedNumberArray.Length; i++)
                {
                   Console.Write(selectedNumberArray[i] + ", ");
                 }
                Console.WriteLine();

                //end test code

                //LOGIC Section ---APPLICATION LOGIC

                // generate 6 random numbers and set to randomNumbersArray

                Random rand = new Random();

                for (int i=0; i < randomNumberArray.Length; i++)
                {
                    randomNumberArray[i] = rand.Next(lowRange, highRange + 1);
                }

                //TEST Code --- display contents of an array
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("random array contains");
                Console.WriteLine();
                for (int i = 0; i < randomNumberArray.Length; i++)
                {
                    Console.Write(randomNumberArray[i] + ", ");
                }
                Console.WriteLine();

                //end test code









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

                } else {Console.WriteLine("");// resets all values to first run state
                        Console.WriteLine("");
                       // Array.Clear(selectedNumberArray, 0, selectedNumberArray.Length);
                        highRange = 0;
                        lowRange = 0;
                        firstNumber = 0;
                        secondNumber = 0;
                        thirdNumber = 0;
                        fourthNumber = 0;
                        fifthNumber = 0;
                        sixthNumber = 0;
                        numberCount = 0;
                        numberEntered = 0;
                        numberOfMatches = 0;

                        checkForExit = null;

                } //end if else exit option


                //NO CODE BEYOND HERE DANGER


            } while (appRunState);



        }// end run state loop
    }
} 
