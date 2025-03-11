////////////////////////////////////
// Change History 
// Date         Developer  Description 
// 2025-02-10   mffarah0   Initialized the Tic-Tac-Toe game structure and designed the basic UI.
// 2025-02-12   mffarah0    Integrated button functionality for the game grid.
// 2025-02-14   mffarah0   Implemented input handling and managed the game state.
// 2025-02-15   mffarah0   Added event handling for button clicks and implemented win checking.
// 2025-02-16   mffarah0   Developed the computer's turn logic with random move selection and first-turn handling.
// 2025-02-17   mffarah0   Expanded the interface to include extra controls such as Turn Indicator, Winner Display, and Game Controls.
// 2025-02-18   mffarah0     Built a system to track and update player and computer scores.
// 2025-02-19   mffarah0   Refined the UI to dynamically reflect score updates.
// 2025-02-20   mffarah0   Finalized game logic, ensuring smooth player and computer turns, scoring, and game resets.
// 2025-02-22   mffarah0     Fixed issues with the new game reset logic and refined SetupGame mechanics.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        // Array representing the Tic-Tac-Toe board
        private Button[,] board;
        // Variable to track the current turn ('X' or 'O')
        private char turn;
        // Random number generator for computer moves
        private Random rnd = new Random();
        // Boolean flag to track if the game is over
        private bool gameOver;
        // Counters for player wins, computer wins, and ties
        private int pWins = 0, cWins = 0, ties = 0;
        // Player and computer marks ('X' or 'O')
        private char pMark, cMark;
        // Default player name
        private string pName = "Player";

        public Form1()
        {
            // Initialize form components
            InitializeComponent();
            // Set up the game board
            SetupGame();
        }

        private void SetupGame()
        {
            // Initialize the 3x3 board with button references
            board = new Button[3, 3] {
            { btn1, btn2, btn3 },
            { btn4, btn5, btn6 },
            { btn7, btn8, btn9 }
        };

            // Default first turn is 'X'
            turn = 'X';
            // Game is not over initially
            gameOver = false;

            // Loop through each button and set initial properties
            foreach (Button b in board)
            {
                // Clear button text
                b.Text = "";
                // Set font size
                b.Font = new System.Drawing.Font("Arial", 20);
                // Attach event handler for button clicks
                b.Click += Button_Click;
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            // Allow moves only if the game is not over
            if (!gameOver)
            {
                Button btn = sender as Button;
                // Ensure the button is empty before placing a mark
                if (btn != null && btn.Text == "")
                {
                    // Set button text to current turn's mark
                    btn.Text = turn.ToString();
                    // Check if the game has been won
                    CheckWin();

                    // If game is still on, switch turns
                    if (!gameOver)
                    {
                        // Change turn to the other player
                        ChangeTurn();
                        // If it's the computer's turn, make a move
                        if (turn == cMark) CompMove();
                    }
                }
            }
        }

        private void CheckWin()
        {
            // Check for row and column wins
            for (int i = 0; i < 3; i++)
            {
                if ((board[i, 0].Text == turn.ToString() && board[i, 1].Text == turn.ToString() && board[i, 2].Text == turn.ToString()) ||
                    (board[0, i].Text == turn.ToString() && board[1, i].Text == turn.ToString() && board[2, i].Text == turn.ToString()))
                {
                    // Declare the winner
                    DeclareWin();
                    return;
                }
            }

            // Check for diagonal wins
            if ((board[0, 0].Text == turn.ToString() && board[1, 1].Text == turn.ToString() && board[2, 2].Text == turn.ToString()) ||
                (board[0, 2].Text == turn.ToString() && board[1, 1].Text == turn.ToString() && board[2, 0].Text == turn.ToString()))
            {
                DeclareWin();
                return;
            }

            // Check for tie (if all buttons are filled and no winner)
            bool isTie = true;
            foreach (Button b in board)
            {
                if (b.Text == "")
                {
                    isTie = false;
                    break;
                }
            }

            // Declare a tie if all spots are filled
            if (isTie) DeclareTie();
        }

        private void DeclareWin()
        {
            string winner;
            // Check if the player won
            if (turn == pMark)
            {
                winner = pName;
                pWins++;
            }
            else
            {
                // Otherwise, the computer won
                winner = "Computer";
                cWins++;
            }

            // Display the winner
            txtGameStatus.Text = winner + " Wins!";
            // Update the scoreboard
            UpdateScore();
            // Set game over flag to true
            gameOver = true;
        }

        private void DeclareTie()
        {
            // Increment tie count
            ties++;
            // Display tie message
            txtGameStatus.Text = "It's a tie!";
            // Update the scoreboard
            UpdateScore();
            // Set game over flag to true
            gameOver = true;
        }

        private void UpdateScore()
        {
            // Update scoreboard labels
            lblPlayerWins.Text = "Wins: " + pWins;
            lblComputerWins.Text = "Losses: " + cWins;
            lblTies.Text = "Ties: " + ties;
        }

        private void ChangeTurn()
        {
            // Toggle turn between 'X' and 'O'
            turn = (turn == 'X') ? 'O' : 'X';
        }

        private void CompMove()
        {
            // List to store available moves
            List<Button> empty = new List<Button>();
            foreach (Button b in board)
            {
                if (b.Text == "")
                    empty.Add(b);
            }

            if (empty.Count > 0)
            {
                // Pick a random empty spot
                Button move = empty[rnd.Next(empty.Count)];
                // Assign mark to the chosen spot
                move.Text = turn.ToString();
                // Check if computer wins
                CheckWin();
                // Change turn to player
                ChangeTurn();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Initialize player name and marks
            pName = TxtPlayerName.Text.Trim();
            if (pName == "") pName = "Player";

            lblPlayerName.Text = "Welcome, " + pName + "!";
            TxtPlayerName.Visible = false;
            txtGameStatus.Text = pName + ", get ready!";

            if (rnd.Next(2) == 0)
            {
                pMark = 'X';
                cMark = 'O';
                txtGameStatus.Text += "\nYou are X.";
            }
            else
            {
                pMark = 'O';
                cMark = 'X';
                txtGameStatus.Text += "\nComputer is X.";
            }

            // Reset board
            foreach (Button b in board)
            {
                b.Text = "";
                b.Enabled = true;
            }

            UpdateScore();
            gameOver = false;
            turn = 'X';

            // If computer starts, make a move
            if (cMark == 'X') CompMove();
        }

        private void NewGamebtn_Click(object sender, EventArgs e)
        {
            // Reset game (same as Start button)
            btnStart_Click(sender, e);
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            // Exit the application
            Application.Exit();
        }
    }
}
