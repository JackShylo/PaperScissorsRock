using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaperScissorsRock
{
    public partial class Form1 : Form
    {
        private GamePlay myGamePlay = new GamePlay();
        // TODO RNG(1, 4);
        // TODO GamePlay Class for all operations that don't modify a form object
        // TODO User Input - Radio Buttons - Pass it to class
        // TODO Output W/L/D
        // TODO get and load images for players and selection
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RbAll_CheckedChanged(object sender, EventArgs e)
        {
            // Temporarily store the radio button
            RadioButton tempRB = (RadioButton)sender;

            this.Text = tempRB.Text;

            if (tempRB.Checked == true)
            {
                switch (tempRB.Text)
                {
                    case "Paper":
                        myGamePlay.HumanChoiceText = "Paper";
                        PbxHumanChoice.Image = Properties.Resources.Paper;
                        break;

                    case "Scissors":
                        myGamePlay.HumanChoiceText = "Scissors";
                        PbxHumanChoice.Image = Properties.Resources.Scissors;
                        break;

                    case "Rock":
                        myGamePlay.HumanChoiceText = "Rock";
                        PbxHumanChoice.Image = Properties.Resources.Rock;
                        break;
                }
            }

        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            myGamePlay.ComputerChoiceText = myGamePlay.ComputerChoice();

            switch (myGamePlay.ComputerChoiceText)
            {
                case "Paper":
                    RbPaperComputer.Checked = true;
                    PbxComputerChoice.Image = Properties.Resources.Paper;
                    break;
                case "Scissors":
                    RbScissorsComputer.Checked = true;
                    PbxComputerChoice.Image = Properties.Resources.Scissors;
                    break;
                case "Rock":
                    RbRockComputer.Checked = true;
                    PbxComputerChoice.Image = Properties.Resources.Rock;
                    break;
            }

            string Outcome = myGamePlay.FindWinner(myGamePlay.HumanChoiceText, myGamePlay.ComputerChoiceText);
            switch (Outcome)
            {
                case "Win":
                    LblOutcome.Text = "YOU WIN!" + System.Environment.NewLine + System.Environment.NewLine + "The Computer Chose: " + myGamePlay.ComputerChoiceText;
                    break;
                case "Draw":
                    LblOutcome.Text = "IT'S A DRAW!" + System.Environment.NewLine + System.Environment.NewLine + "The Computer Chose: " + myGamePlay.ComputerChoiceText;
                    break;
                case "Lose":
                    LblOutcome.Text = "YOU LOSE!" + System.Environment.NewLine + System.Environment.NewLine + "The Computer Chose: " + myGamePlay.ComputerChoiceText;
                    break;
            }
        }

        private void PbxComputer_Click(object sender, EventArgs e)
        {

        }
    }
}
