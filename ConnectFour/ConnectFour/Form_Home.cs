using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VP_Proekt_Connect4;

namespace ConnectFour
{
    public partial class Form_Home : Form
    {
        public Form_Home()
        {
            InitializeComponent();
        }

        private void Play_MouseHover(object sender, EventArgs e)
        {
            btnPlay.Font = new Font(" ", 18);
        }

        private void Play_MouseLeave(object sender, EventArgs e)
        {
            btnPlay.Font = new Font(" ", 14, FontStyle.Regular);
        }

        private void HowToPlay_MouseHover(object sender, EventArgs e)
        {
            btnHowToPlay.Font = new Font(" ", 18);
        }

        private void HowToPlay_MouseLeave(object sender, EventArgs e)
        {
            btnHowToPlay.Font = new Font(" ", 14);
        }

        private void Exit_MouseHover(object sender, EventArgs e)
        {
            btnExit.Font = new Font(" ", 18);
        }

        private void Exit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.Font = new Font(" ", 14);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HowToPlay_Click(object sender, EventArgs e)
        {
            Instructions uslovi = new Instructions();
            uslovi.ShowDialog();
        }

        private void Play_Click(object sender, EventArgs e)
        { 
            Form_Options fo = new Form_Options();
            this.Hide();
            fo.Show();
        }

        private void lnlRights_Click(object sender, EventArgs e)
        {
            string text = "Connect 4 is made by\r\n";
            text += "\t1. Monika Spasovska (186012)\r\n";
            text += "\t2. Vladimir Savic (186072)\r\n";
            text += "under mentorship of\r\n";
            text += "\t1. Gjorgji Madjarov, Ph.D.\r\n";
            text += "\t2. Aleksandar Stojmenski, M.Sc.\r\n\r\n";
            text += "This project is part of course Visual Programming in academic year 2019/2020.\r\n";
            text += "All rights reserved by FCSE.\r\n";

            MessageBox.Show(text, "COPYRIGHT");
        }

    }
}
