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

                double jackpot = 3600.00; // hardcoded jackpot amount per spec 
                double winnings = 0;
                int[] randomNumberArray = new int[6];
                int[] selectedNumberArray = new int[6];

                int highRange = 0;
                int lowRange = 0;
                int firstNumber = 0;
                int secondNumber = 0;
                int numberEntered = 0;
                int numberOfMatches = 0;


                String checkForExit = null;

                // Present Jackpot amount to user

                for (int i = 3; i > 0; i--)
                {
                    Console.WriteLine();
                }

                Console.WriteLine("Today's Jackpot is $" + jackpot);

                for (int i = 3; i > 0; i--)
                {
                    Console.WriteLine();
                }


                //INPUTS -get inputs here

                //get low range and high range numbers

                Console.WriteLine("Please enter a starting number");
                lowRange = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter an ending number");
                highRange = int.Parse(Console.ReadLine());

                //get six guessed numbers and set to array

                

                for (int i = 0; i < selectedNumberArray.Length; i++)
                {

                    Console.WriteLine("Please enter one of your six number guesses");
                    numberEntered = int.Parse(Console.ReadLine());

                    //trap for invalid

                    while ((numberEntered < lowRange) || (numberEntered > highRange))
                    {

                        Console.WriteLine("Please enter a valid number");
                        numberEntered = int.Parse(Console.ReadLine());
                    }

                    selectedNumberArray[i] = numberEntered;
                      
                }

                
                //LOGIC Section ---APPLICATION LOGIC

                // generate 6 random numbers and set to randomNumbersArray, trap for duplicates

                Random rand = new Random();
                int[] compareArray = new int[6];

                for (int i = 0; i < randomNumberArray.Length; i++)
                {
                    randomNumberArray[i] = rand.Next(lowRange, highRange + 1);
                    compareArray[i] = randomNumberArray[i];     
                }
                
                for (int i = 0; i < randomNumberArray.Length; i++)
                {
                    
                      while(randomNumberArray[i] == compareArray[i])
                        {
                            randomNumberArray[i] = rand.Next(lowRange, highRange + 1);
                        }

                 }
                



               // display random numbers to the console
                for (int i = 0; i < randomNumberArray.Length; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine("Lucky Number: "+randomNumberArray[i]);
                    Console.WriteLine();
                }

                

                //Check for winning numbers (matches)
                for (int i = 0; i < selectedNumberArray.Length; i++)
                {
                    firstNumber = selectedNumberArray[i];

                    for (int j=0;j<randomNumberArray.Length;j++)
                    {
                        secondNumber = randomNumberArray[j];
                        if (firstNumber == secondNumber)
                        {
                            numberOfMatches++;
                        }
                    }
                }

                
                //OUTPUT
                
                
                
                //calculate prize amount

                switch(numberOfMatches)
                   { case 1:
                        winnings = (jackpot/6)*.01;
                        break;
                    case 2:
                        winnings = jackpot/3*.01;
                        break;

                    case 3:
                        winnings = jackpot/1.5*.01;
                        break;
                    case 4:
                        winnings = jackpot /0.75 * .01;
                        break;
                    case 5:
                        winnings = jackpot /0.0375 * .01;
                        break;
                    case 6:
                        winnings = jackpot/1;
                        break;
                    default: winnings = 0/jackpot;
                        break;

                }


                

                Console.Write("You guessed {0} numbers correctly!  You won ${1}!", numberOfMatches,winnings);


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
                        //Array.Clear(selectedNumberArray, 0, selectedNumberArray.Length);
                        Array.Clear(randomNumberArray, 0, randomNumberArray.Length);
                        highRange = 0;
                        lowRange = 0;
                        firstNumber = 0;
                        secondNumber = 0;                        
                        numberEntered = 0;
                        numberOfMatches = 0;
                        checkForExit = null;

                } //end if else exit option


                //NO CODE BEYOND HERE DANGER


            } while (appRunState);



        }// end run state loop
    }
} 
