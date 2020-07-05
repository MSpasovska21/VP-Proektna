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
    public partial class Form1 : Form
    {
        public Form1()
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
            //DA SE DOPUNI KOD !!!!!!!!!!
        }
    }
}
