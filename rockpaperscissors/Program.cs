using System;

namespace rockpaperscissors
{
    class Program
    {

enum RpsChoice
        {
            //without specifying the number equivalent of the enum type, the numbers default to start at 0.
            Rock = 1,//equivalent to 1
            Paper = 2,//equivalent to 2
            Scissors = 3//equivalent to 3
        }

        static void Main(string[] args)
        {   
            
            Console.WriteLine("\tWelcome to Rock-Paper-Scissors!\n\n Please enter your name.");
            String name = Console.ReadLine();

            int playerWinCount = 0;
            int computerWinCount = 0;
            String playAgain="yes";

            bool successfulConversion = false;
            int playerChoiceInt;
            while(playAgain == "yes"){
            for(int i = 0; i<3; i++){
            do
            {
                Console.WriteLine("Please choose one\n\n 1. Rock\n2. Paper\n3.Scissors");
                string playerChoice = Console.ReadLine();

                //create a int variable to catch the converted choice.
                successfulConversion = Int32.TryParse(playerChoice, out playerChoiceInt);

                //check if the user inputted a number but the numebr is out of bounds.
                if (playerChoiceInt > 3 || playerChoiceInt < 1)
                {
                    Console.WriteLine($"You inputted {playerChoiceInt}. That is not a valid choice.");
                }
                else if (!successfulConversion)
                {
                    Console.WriteLine($"You inputted {playerChoice}. That is not a valid choice.");
                }

            } //while (!successfulConversion || (playerChoiceInt < 1 || playerChoiceInt > 3));
            while (!successfulConversion || !(playerChoiceInt > 0 && playerChoiceInt < 4));//both of hte above are valid.

            //you can omit the {} if the body of hte statement is only 1 line
            if (successfulConversion == true) Console.WriteLine($"the conversion returned {successfulConversion} and the player chose {playerChoiceInt}");
            else
                Console.WriteLine($"the conversion returned {successfulConversion} and the player chose {playerChoiceInt}");

            //kget a random number generator object
            Random rand = new Random();
            //get a random number 1,2, or 3.
            int computerChoice = rand.Next(1, Enum.GetNames(typeof(RpsChoice)).Length + 1);

            //print the choices.
            Console.WriteLine($"the players choice is {playerChoiceInt}");
            Console.WriteLine($"the computers choice is {computerChoice}");

            //check who won.
            if ((playerChoiceInt == 1 && computerChoice == 2)
                || (playerChoiceInt == 2 && computerChoice == 3)
                || (playerChoiceInt == 3 && computerChoice == 1))
                {
                     Console.WriteLine("Computer Wins");
                     computerWinCount=computerWinCount+1;

                }
            else if (playerChoiceInt == computerChoice) Console.WriteLine("Tie Game!!");
            else{
                 Console.WriteLine($"{name}Wins!!!");
                 playerWinCount = playerWinCount +1;
            }

            //you can get typeDef the number to the equivalent RpsChoice Enum.
            Console.WriteLine((RpsChoice)playerChoiceInt);
            Console.WriteLine((RpsChoice)computerChoice);
            
            if (playerWinCount==2 || computerWinCount==2){
                break;
            }

            }
            if(playerWinCount>computerWinCount){
                Console.WriteLine($"{name} has one the Game with {playerWinCount}");
            }
            else if (playerWinCount == computerWinCount){
                Console.WriteLine("Tie game there is no winner");
            }
            else{
                Console.WriteLine($"Sorry {name} The computer wins with {computerWinCount}");
            }
            Console.WriteLine("Do you want to play again yes or no ?");
            playAgain= Console.ReadLine();

            if(playAgain=="no")Console.WriteLine("Thank you for playing");
            
        }
        }
    }
}
