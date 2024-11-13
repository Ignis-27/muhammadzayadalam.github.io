//Muhammad Zayad Alam
//100938343
//Lab 2 Tic tac toe 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private Label[] gameBoard;
        bool xTurn = true;   //this checks for the players turns starts with player x 
        private int xPlayerScore = 0;
        private int oPlayerScore = 0;
        private Color xPlayerColor ; // Default color for Player X
        private Color oPlayerColor ; // Default color for Player Y


        public Form1()
        {
            InitializeComponent();
            StartGame();
        }

        // Initialize the game board and link labels to the array
        private void StartGame()
        {
            gameBoard = new Label[] { label2, label3, label4, label5, label6, label7, label8, label9, label10 };

            foreach (Label square in gamePanel.Controls)
            {
                square.Text = "";
              
            }
             

        }

        
        private void labelclicked(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;

            // Check if both player names are entered before the first move
            if (xPlayerTextBox.Text == "" || oPlayerTextBox.Text == "")
            {
                MessageBox.Show("Please enter both player names to start the game!");
                return; // Stop execution if names are not entered
            }

         

            // Disable the player name text boxes after both names are entered
            xPlayerTextBox.ReadOnly = true;
            oPlayerTextBox.ReadOnly = true;




            // Ensure label is empty before marking
            if (clickedLabel.Text == "")
            {
                if (xTurn)
                {
                    clickedLabel.Text = "X";
                    playerTurnLabel.Text = $"{oPlayerTextBox.Text}'s turn (O)";
                    clickedLabel.ForeColor = xPlayerColor;


                }
                else
                {
                    clickedLabel.Text = "O";
                    playerTurnLabel.Text = $"{xPlayerTextBox.Text}'s turn (X)";
                    clickedLabel.ForeColor = oPlayerColor;

                }
            }

            // Check if there's a winner or the board is full
            if (CheckForWinner())
            {
                
                if (xTurn)
                {
                    // Player X wins
                    MessageBox.Show($"{xPlayerTextBox.Text} (X) Wins!Click Ok to reset ");
                  

                    // Increase X player's score by 1
                    xPlayerScore++;
                    xPlayerScoreTextBox.Text = xPlayerScore.ToString();

                }
                else
                {
                    MessageBox.Show($"{oPlayerTextBox.Text} (O) Wins! Click Ok to reset ");
                    

                    // Increase O player's score by 1
                    oPlayerScore++;
                    oPlayerScoreTextBox.Text = oPlayerScore.ToString();


                }
                ResetGame();
                return;
            }
            else if (BoardFull())
            {
                MessageBox.Show("It's a draw! Click Ok  to reset ");
                ResetGame();
                winnerDisplayLabel.Text = "";
                return;
            }

            // Switch turns
            if (xTurn)
            {
                xTurn = false;
            }
            else
            {
                xTurn = true;

            }

        }

        // Check all winning combinations
        private bool CheckForWinner()
        {
            int[][] winningCombinations = {
            new int[] { 0, 1, 2 }, // Top row
            new int[] { 3, 4, 5 }, // Middle row
            new int[] { 6, 7, 8 }, // Bottom row
            new int[] { 0, 3, 6 }, // Left column
            new int[] { 1, 4, 7 }, // Middle column
            new int[] { 2, 5, 8 }, // Right column
            new int[] { 0, 4, 8 }, // Top-left to bottom-right diagonal
            new int[] { 2, 4, 6 }  // Top-right to bottom-left diagonal
        };


            foreach (var combo in winningCombinations)
            {
                if (gameBoard[combo[0]].Text == gameBoard[combo[1]].Text &&
                    gameBoard[combo[1]].Text == gameBoard[combo[2]].Text &&
                    gameBoard[combo[0]].Text != "")
                {
                    return true; // Winner found
                }
            }

            return false; // No winner
        }



        // Check if the board is full
        private bool BoardFull()
        {
            foreach (var label in gameBoard)
            {
                if (label.Text == "")
                {
                    return false; // There's still an empty square
                }
            }
            return true; // All squares are filled
        }




        // Reset the board for a new game
        private void ResetGame()
        {
            foreach (var label in gameBoard)
            {
                label.Text = ""; // Clear each label
                playerTurnLabel.Text = $"{xPlayerTextBox.Text}'s turn (X)";
            }

            // Update the winner display label based on current scores
            if (xPlayerScore > oPlayerScore)
            {
                winnerDisplayLabel.Text = "X";  //if player x is winning
            }
            else if (oPlayerScore > xPlayerScore)
            {
                winnerDisplayLabel.Text = "O"; //if player o is winning
            }
            else
            {
                winnerDisplayLabel.Text = ""; // If scores are equal, no overall leader
            }

            xTurn = true; // X starts
        }

        private void XPlayerButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorBox = new ColorDialog();

            if (colorBox.ShowDialog() == DialogResult.OK)
            {
                // Store the selected color for Player X
                xPlayerColor = colorBox.Color;

                // Set the selected color to X player's text box and button
                xPlayerTextBox.ForeColor = xPlayerColor;
                XPlayerButton.BackColor = xPlayerColor; // Change button color to show chosen color

                // Update existing "X" labels on the board to use the selected color
                foreach (var label in gameBoard)
                {
                    if (label.Text == "X")
                    {
                        label.ForeColor = xPlayerColor;
                    }
                }
            }

        }


        private void oPlayerButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorBox = new ColorDialog();

            if (colorBox.ShowDialog() == DialogResult.OK)
            {
                // Store the selected color for Player O
                oPlayerColor = colorBox.Color;

                // Set the selected color to O player's text box and button
                oPlayerTextBox.ForeColor = oPlayerColor;
                oPlayerButton.BackColor = oPlayerColor; // Change button color to show chosen color

                // Update existing "O" labels on the board to use the selected color
                foreach (var label in gameBoard)
                {
                    if (label.Text == "O")
                    {
                        label.ForeColor = xPlayerColor;
                    }
                }
            }
        }
    }
}
