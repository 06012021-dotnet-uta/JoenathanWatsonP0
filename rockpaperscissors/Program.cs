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
            PlayerClass player1 = new PlayerClass();
            PlayerClass player2 = new PlayerClass();
            GamePlayClass gamePlay = new GamePlayClass();
            Console.WriteLine("\tWelcome to Rock-Paper-Scissors!\n\n Please enter your name.");
            player1.FirstName = Console.ReadLine();
           
           
            while(gamePlay.playAgain == "yes"){
            for(int i = 0; i<3; i++){
            do
            {
                Console.WriteLine("Please choose one\n\n 1. Rock\n2. Paper\n3.Scissors");
                gamePlay.playerChoice = Console.ReadLine();

               

                //create a int variable to catch the converted choice.
                gamePlay.successfulConversion = Int32.TryParse(gamePlay.playerChoice, out gamePlay.playerChoiceInt);
                 Console.WriteLine(gamePlay.GameStart())  ;
               

            } //while (!successfulConversion || (playerChoiceInt < 1 || playerChoiceInt > 3));
            while (!gamePlay.successfulConversion || !(gamePlay.playerChoiceInt > 0 && gamePlay.playerChoiceInt < 4));//both of hte above are valid.

            gamePlay.CheckConversion();
           
            //kget a random number generator object
            Random rand = new Random();
            //get a random number 1,2, or 3.
            gamePlay.computerChoice = rand.Next(1, Enum.GetNames(typeof(RpsChoice)).Length + 1);

            //print the choices.
            Console.WriteLine($"the players choice is {gamePlay.playerChoiceInt}");
            Console.WriteLine($"the computers choice is {gamePlay.computerChoice}");

            //check who won.
                Console.WriteLine(gamePlay.WinnerCheck(player2.computerName,player1.FirstName));

    

            //you can get typeDef the number to the equivalent RpsChoice Enum.
            Console.WriteLine((RpsChoice)gamePlay.playerChoiceInt);
            Console.WriteLine((RpsChoice)gamePlay.computerChoice);
            
            if (gamePlay.playerWinCount==2 || gamePlay.computerWinCount==2){
                break;
            }

            }

            Console.WriteLine(gamePlay.FinalWinner(player2.computerName, player1.FirstName));
           
            Console.WriteLine("Do you want to play again yes or no ?");
            gamePlay.playAgain= Console.ReadLine();
           

            gamePlay.PlayAgainMeth();

            
        }
        }
    }
}
