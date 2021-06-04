using System;
namespace rockpaperscissors
{
    public class GamePlayClass
    {
        public string playAgain="yes";

        public bool successfulConversion = false;
        public int playerChoiceInt;

        public string playerChoice; 

        public int computerChoice; 

         public int playerWinCount=0;
        public int computerWinCount=0;

         public  string GameStart(){
           string message = "";

               if (playerChoiceInt > 3 || playerChoiceInt < 1)
                {
                    message=$"You inputted {playerChoiceInt}. That is not a valid choice.";
                }
                else if (!successfulConversion)
                {
                    message=$"You inputted {playerChoice}. That is not a valid choice.";
                
                }

                    return message;

    }

        public string WinnerCheck(string computerName,string FirstName){

            string messg="";
            if ((playerChoiceInt == 1 && computerChoice == 2)
                || (playerChoiceInt == 2 && computerChoice == 3)
                || (playerChoiceInt == 3 && computerChoice == 1))
                {
                     messg=$"{computerName} Wins";
                     computerWinCount=computerWinCount+1;

                }
            else if (playerChoiceInt == computerChoice){
                messg="Tie Game!!";
                }
            else{
                 messg=$"{FirstName} Wins!!!";
                 playerWinCount = playerWinCount +1;
            }
            return messg;

        }

        public string FinalWinner(string computerName,string FirstName)
        {
            string messg = "";
              if(playerWinCount>computerWinCount){
                messg= $"{FirstName} has one the Game with {playerWinCount}";
            }
            else if (playerWinCount == computerWinCount){
                messg="Tie game there is no winner";
            }
            else{
                messg = $"Sorry {FirstName} The {computerName} wins with {computerWinCount}";
            }
            return messg;
        }

        public string PlayAgainMeth(){
           playAgain=playAgain.ToLower();
            string messg = "";
            if(playAgain=="no"){
                messg ="Thank you for playing";
            }

            return messg;
        }


        public string CheckConversion(){
            string messg = "";
             if (successfulConversion == true) {
                 messg=$"the conversion returned {successfulConversion} and the player chose {playerChoiceInt}";
             }
            else
            {
                messg =$"the conversion returned {successfulConversion} and the player chose {playerChoiceInt}";
            }

            return messg;
        }
    }

   
}