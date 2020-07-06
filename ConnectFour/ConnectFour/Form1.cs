using ConnectFour;
using Microsoft.Win32;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_Proekt_Connect4
{
    public partial class Form1 : Form
    {
        Rectangle rect;
        int[] allowedincolumn = { 6, 6, 6, 6, 6, 6, 6 }; //niza koja za sekoja kolona vodi smetka kolku krugovi ima smesteno. Koga nekoj element kje dojde do 6, vekje ne moze da se stavaat vo taa kolona.
        int[,] board = new int[6,7]; // inicijalno 0(nicie pole), 1(pole kade sto e zavzemeno od player1, 2(pole kade sto e zavzemeno od player2)
        int col, rounds1 = 0, rounds2 = 0, draw=0;
        Color color;
        int timeElapsed1 = 0, timeElapsed2 = 0, temp;
        bool start = true;
        static string name1 = Form_Options.player1;
        static string name2 = Form_Options.player2;
        static int bestOf = Form_Options.bestOf;
        static int time = Form_Options.time;
        Player player1 = new Player(true, Color.Green, time, name1);
        Player player2 = new Player(false, Color.Red, time, name2);
        public Form1()
        {
            InitializeComponent();
            
            pbPlayer1.Maximum = player1.time;
            pbPlayer2.Maximum = player2.time;
            pbPlayer1.Value = player1.time;
            pbPlayer2.Value = player2.time;
            lblPlayer1TL.Text = String.Format("{0:00}:{1:00}", player1.time / 60, player1.time % 60);
            lblPlayer2TL.Text = String.Format("{0:00}:{1:00}", player2.time / 60, player1.time % 60);
            lblBestOf.Text = "Best Of " + bestOf.ToString() + " Games";
            lblPlayerOne.Text = player1.name;
            lblPlayerTwo.Text = player2.name;
            lblRounds1.Text = player1.name + " Rounds Won: " + rounds1.ToString();
            lblRounds2.Text = player2.name + " Rounds Won: " + rounds2.ToString();
            lblTurn.Text = player1.name + "'s turn";
        }
        private void pnlBoard_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.BurlyWood, 0, 0, pnlBoard.Width, pnlBoard.Height);
            for(int i=0;i<=600;i+=100)
            {
                for(int j=0;j<=700;j+=100)
                {
                    rect = new Rectangle(i, j, 100, 100);
                    e.Graphics.FillEllipse(Brushes.White, rect);
                }
            }    
        }

        private void newRound()
        {
            Graphics e = this.pnlBoard.CreateGraphics();
            e.FillRectangle(Brushes.BurlyWood, 0, 0, pnlBoard.Width, pnlBoard.Height);
            for (int i = 0; i <= 600; i += 100)
            {
                for (int j = 0; j <= 700; j += 100)
                {
                    rect = new Rectangle(i, j, 100, 100);
                    e.FillEllipse(Brushes.White, rect);
                }
            }
            start = true;
            timeElapsed1 = 0; timeElapsed2 = 0;
            player1.turn = true;
            player2.turn = false;
            pbPlayer1.Value = player1.time;
            pbPlayer2.Value = player2.time;
            allowedincolumn = new int [] { 6, 6, 6, 6, 6, 6, 6 };
            board = new int [6, 7];
            lblPlayer1TL.Text = String.Format("{0:00}:{1:00}", player1.time / 60, player1.time % 60);
            lblPlayer2TL.Text = String.Format("{0:00}:{1:00}", player2.time / 60, player1.time % 60);
            lblTurn.Text = player1.name + "'s turn";
        }
        private void newGame()
        {
            Graphics e = this.pnlBoard.CreateGraphics();
            e.FillRectangle(Brushes.BurlyWood, 0, 0, pnlBoard.Width, pnlBoard.Height);
            for (int i = 0; i <= 600; i += 100)
            {
                for (int j = 0; j <= 700; j += 100)
                {
                    rect = new Rectangle(i, j, 100, 100);
                    e.FillEllipse(Brushes.White, rect);
                }
            }
            start = true;
            timeElapsed1 = 0; timeElapsed2 = 0;
            player1.turn = true;
            player2.turn = false;
            pbPlayer1.Value = player1.time;
            pbPlayer2.Value = player2.time;
            allowedincolumn = new int[] { 6, 6, 6, 6, 6, 6, 6 };
            board = new int[6, 7];
            lblPlayer1TL.Text = String.Format("{0:00}:{1:00}", player1.time / 60, player1.time % 60);
            lblPlayer2TL.Text = String.Format("{0:00}:{1:00}", player2.time / 60, player1.time % 60);
            rounds1 = 0;
            rounds2 = 0;
            lblRounds1.Text = player1.name + " Rounds Won: " + rounds1.ToString();
            lblRounds2.Text = player2.name + " Rounds Won: " + rounds2.ToString();
            lblTurn.Text = player1.name + "'s turn";
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private int Column(Point p)
        {
            for (int i = 0; i <= 600; i += 100)
            {
                for (int j = 0; j <= 700; j += 100)
                {
                    if (p.X >= i && p.X <= i + 100)
                        return i / 100;
                }
            }
            return -1;
        }
        public bool isWinning(int col, int pturn)
        {
            //horizontally
            int win = 0;
            for (int i = 0; i < 7; i++)
            {
                if (board[allowedincolumn[col], i] == pturn)
                {
                    win++;
                    if (win == 4)
                        return true;
                }
                else
                    win = 0;

            }
            //vertically
            win = 0;
            for (int i = 0; i < 6; i++)
            {
                if (board[i, col] == pturn)
                {
                    win++;
                    if (win == 4)
                        return true;
                }
                else
                    win = 0;
            }
            //diagonally (left-right)
            win = 0;
            int razlika = allowedincolumn[col] - col;
            for (int i = 0; i < 6; i++)
                for (int j = 0; j < 7; j++)
                    if (i - j == razlika)
                    {
                        if (board[i, j] == pturn)
                        {
                            win++;
                            if (win == 4)
                                return true;
                        }
                        else
                            win = 0;
                    }
            //diagonally (right-left)
            win = 0;
            int zbir = allowedincolumn[col] + col;
            for (int i = 0; i < 6; i++)
                for (int j = 0; j < 7; j++)
                    if (i + j == zbir)
                    {
                        if (board[i, j] == pturn)
                        {
                            win++;
                            if (win == 4)
                                return true;
                        }
                        else
                            win = 0;
                    }
            return false;
        }
        public bool isDraw()
        {
            for (int i = 0; i < 6; i++)
                for (int j = 0; j < 7; j++)
                    if (board[i, j] == 0)
                        return false;
            return true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(player1.turn)
            {
                temp = player1.time;
                timeElapsed1++;
                pbPlayer1.Value = temp - timeElapsed1;
                lblPlayer1TL.Text = String.Format("{0:00}:{1:00}", pbPlayer1.Value / 60, pbPlayer1.Value % 60);
                if(timeElapsed1==player1.time)
                {
                    rounds2++;
                    timer1.Stop();
                    if (rounds2 == (bestOf / 2) + 1)
                    {
                        lblRounds2.Text = player2.name + " Rounds Won: " + rounds2.ToString();
                        DialogResult result = MessageBox.Show(player2.name + " Won the Game", "Congratulations", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                            newGame();
                        else
                            Application.Exit();
                    }
                    else
                    {
                        rounds2++;
                        lblRounds2.Text = player2.name + " Rounds Won: " + rounds2.ToString();
                        DialogResult result = MessageBox.Show(player2.name + " Wins this Round.Are you ready for next round?", player1.name + "'s Time is Up", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                            newRound();
                        else
                            Application.Exit();
                    }
                }
            }
            else if(player2.turn)
            {
                temp = player2.time;
                timeElapsed2++;
                pbPlayer2.Value = temp - timeElapsed2;
                lblPlayer2TL.Text = String.Format("{0:00}:{1:00}", pbPlayer2.Value / 60, pbPlayer2.Value % 60);
                if (timeElapsed2 == player2.time)
                {
                    timer1.Stop();
                    if (rounds1 == (bestOf / 2) + 1)
                    {
                        lblRounds1.Text = player1.name + " Rounds Won: " + rounds1.ToString();
                        DialogResult result = MessageBox.Show(player1.name + " Won the Game", "Congratulations", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                            newGame();
                        else
                            Application.Exit();
                    }
                    else
                    {
                        rounds1++;
                        lblRounds1.Text = player1.name + " Rounds Won: " + rounds1.ToString();
                        DialogResult result = MessageBox.Show(player1.name + " Wins this Round.Are you ready for next round?", player2.name + "'s Time is Up", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                            newRound();        
                        else
                            Application.Exit();
                    }
                }
            }
        }

        private void pnlBoard_MouseClick(object sender, MouseEventArgs e)
        {
            if (start)
            {
                timer1.Start();
                start = false;
            }
            if(player1.turn)
            {
                lblTurn.Text = player2.name + "'s turn";
                player1.turn = false;
                player2.turn = true;
                col = Column(e.Location);
                if(allowedincolumn[col]>=0)
                {
                    board[allowedincolumn[col]-1, col] = 1;
                    rect = new Rectangle(col * 100, allowedincolumn[col] * 100 - 100,100, 100);
                    color = player1.color;
                    Graphics g = this.pnlBoard.CreateGraphics();
                    Brush br = new SolidBrush(color);
                    g.FillEllipse(br, rect);
                    allowedincolumn[col]--;
                }
                if (isWinning(col, 1))
                {
                    rounds1++;
                    timer1.Stop();
                    lblRounds1.Text = player1.name + " Rounds Won: " + rounds1.ToString();
                    if (rounds1 == (bestOf / 2) + 1)
                    {
                        DialogResult result = MessageBox.Show(player1.name + " Won the Game. New Game?", "Congratulations", MessageBoxButtons.YesNo);
                        if(result == DialogResult.Yes)
                        {
                            newGame();
                        }
                        else
                            Application.Exit();
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show(player1.name + " Wins this Round. Are you ready for next round?", "Congratulations", MessageBoxButtons.YesNo);
                        if(result == DialogResult.Yes)
                            newRound();
                        else
                            Application.Exit();
                    }
                }
                if(isDraw())
                {
                    draw++;
                    timer1.Stop();
                    lblDraw.Text = "Draws: " + draw.ToString();
                    DialogResult result = MessageBox.Show("This Round is a Draw. Are you ready for next round?", "Draw", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                        newRound();
                    else
                        Application.Exit();
                }
            }
            else if(player2.turn)
            {
                lblTurn.Text = player1.name + "'s turn";
                player2.turn = false;
                player1.turn = true;
                col = Column(e.Location);
                if (allowedincolumn[col] >= 0)
                {
                    board[allowedincolumn[col]-1, col] = 2;
                    rect = new Rectangle(col * 100, allowedincolumn[col] * 100 - 100, 100, 100);
                    color = player2.color;
                    Graphics g = this.pnlBoard.CreateGraphics();
                    Brush br = new SolidBrush(color);
                    g.FillEllipse(br, rect);
                    allowedincolumn[col]--;
                }
                if (isWinning(col, 2))
                {
                    timer1.Stop();
                    rounds2++;
                    lblRounds2.Text = player2.name + " Rounds Won: " + rounds2.ToString();
                    if (rounds2 == (bestOf/2)+1)
                    {
                        DialogResult result = MessageBox.Show(player2.name + " Won the Game. New Game?", "Congratulations", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                            newGame();
                        else
                            Application.Exit();
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show(player2.name + " Wins this Round. Are you ready for next round?", "Congratulations", MessageBoxButtons.YesNo);
                        if(result == DialogResult.Yes)
                            newRound();
                        else
                            Application.Exit();
                    }
                }
                if (isDraw())
                {
                    draw++;
                    timer1.Stop();
                    lblDraw.Text = "Draws: " + draw.ToString();
                    DialogResult result = MessageBox.Show("This Round is a Draw. Are you ready for next round?", "Draw", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                        newRound();
                    else
                        Application.Exit();
                }
            }
        }

    }
}
