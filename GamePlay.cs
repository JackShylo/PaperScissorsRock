using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperScissorsRock
{
    class GamePlay
    {
        public string HumanChoiceText { get; set; }
        public string ComputerChoiceText { get; set; }

        public string ComputerChoice()
        {
            Random myRandom = new Random();

            int tempComputerChoice = myRandom.Next(1, 4);

            switch (tempComputerChoice)
            {
                case 1:
                    return "Paper";

                case 2:
                    return "Scissors";

                case 3:
                    return "Rock";

            }

            return string.Empty;
        }

        public string FindWinner(string Human, string Computer)
        {
            if (Human == "Paper" && Computer == "Paper")
            {
                return "Draw";
            }
            if (Human == "Paper" && Computer == "Scissors")
            {
                return "The Computer Wins!";
            }
            if (Human == "Paper" && Computer == "Rock")
            {
                return "Win";
            }
            if (Human == "Scissors" && Computer == "Paper")
            {
                return "Win";
            }
            if (Human == "Scissors" && Computer == "Scissors")
            {
                return "Draw";
            }
            if (Human == "Scissors" && Computer == "Rock")
            {
                return "Lose";
            }
            if (Human == "Rock" && Computer == "Paper")
            {
                return "Lose";
            }
            if (Human == "Rock" && Computer == "Scissors")
            {
                return "Win";
            }
            if (Human == "Rock" && Computer == "Rock")
            {
                return "Draw";
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
