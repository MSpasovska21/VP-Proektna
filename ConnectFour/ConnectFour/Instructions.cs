using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectFour
{
    public partial class Instructions : Form
    {
        public Instructions()
        {
            InitializeComponent();
        }

        private void Instructions_Load(object sender, EventArgs e)
        {
            tbInstructions.Text = " Connect Four \r\n";
            tbInstructions.Text += "   For 2 players\r\n\r\n\r\n\r\n";
            tbInstructions.Text += "The rules are simple: Try to build a row of four checkers while keeping your " +
                "opponent from doing the same.Sounds easy, but it's not! The vertical strategy creates a unique " +
                "challenge:you must think in a whole new way to block your opponent's moves! \r\n\r\n\r\n";
            tbInstructions.Text += "OBJECT \r\n\r\n";
            tbInstructions.Text += "Be the first player to get four of your colored checkers in a row - horizontally, " +
                "vertivally or diagonally. \r\n\r\n\r\n";
            tbInstructions.Text += "HOW TO PLAY \r\n\r\n";
            tbInstructions.Text += "1. Decide who plays first. Players will alternate turns after playing a checker. \r\n";
            tbInstructions.Text += "    NOTE: The player starting the first game will play second in the next game. \r\n\r\n";
            tbInstructions.Text += "2. On your turn, drop one of your checkers i.e. point the cursor over the row you " +
                "wish to drop your piece in. \r\n\r\n";
            tbInstructions.Text += "3. Play alternates until one player gets FOUR checkers of his or her color in a row. " +
                "The four in a row can be horizontal, vertical or diagonal. \r\n\r\n\r\n";
            tbInstructions.Text += "HOW TO WIN \r\n\r\n";
            tbInstructions.Text += "If you are the first player to get four of your checkers in a row, you win the game! \r\n\r\n\r\n";
            tbInstructions.Text += "TO START ANOTHER GAME \r\n\r\n";
            tbInstructions.Text += "Once when you close the finished game, you will be returned on the main page and you can " +
                "choose PLAY again. \r\n\r\n\r\n";
            tbInstructions.Text += "HISTORY \r\n\r\n";
            tbInstructions.Text += "This game is centuries old, Captain James Cook used to play it with his fellow " +
                "officers on his long voyages, and so it has also been called \"Captain's Mistress\". Milton Bradley(now "+
                "owned by Hasbro) published a version of this game called \"Connect Four\" in 1974. \r\n\r\n";
            tbInstructions.Text += "Other names for this this game are \"Four -in-a - Row\" and \"Plot Four\". \r\n";
   
        }

        private void Insttructions_Resize(object sender, EventArgs e)
        {
            tbInstructions.Size = new System.Drawing.Size(this.Size.Width - 27, this.Size.Height - 48);
        }
    }
}
