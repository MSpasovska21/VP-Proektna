using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public partial class Form_Options : Form
    {
        public static string player1;
        public static string player2;
        public static int bestOf;
        public static int time;
        public Form_Options()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_Home home = new Form_Home();
            home.Show();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            bool tmp1 = true;
            string name1 = tbName1.Text;
            string name2 = tbName2.Text;
            bestOf = Convert.ToInt32(this.dUD_Rounds.SelectedItem);
            time = Convert.ToInt32(this.dUD_Seconds.SelectedItem);
            bool temp1 = true;
            bool temp2 = true;

            if (this.dUD_Seconds.SelectedItem == null && this.dUD_Rounds.SelectedItem == null && name1.Length < 2 && name2.Length < 2) // ako nisto ne e vneseno
            {
                MessageBox.Show("Please enter required fields");
                tmp1 = false;
            }
            if (name1.Length < 2 && name2.Length < 2 && tmp1) // ako ne se vneseni iminja
            {
                MessageBox.Show("Enter name for Player1 and Player2 longer than 1 character");
                temp1 = false; temp2 = false;
            }
            else
            {
                if (name1.Length < 2 && tmp1)
                {
                    MessageBox.Show("Enter name for Player1 longer than 1 character");
                    temp1 = false;
                }
                if (name2.Length < 2 && tmp1)
                {
                    MessageBox.Show("Enter name for Player2 longer than 1 character");
                    temp2 = false;
                }
            }
            if(this.dUD_Seconds.SelectedItem == null && this.dUD_Rounds.SelectedItem == null && tmp1) // ako ne se vneseni rundi i sekundi
            {
                MessageBox.Show("Select number of rounds and seconds for the game");
                temp1 = false; temp2 = false;
            }
            else
            {
                if (this.dUD_Seconds.SelectedItem == null && tmp1)
                {
                    MessageBox.Show("Select number of seconds for the round");
                    temp1 = false;
                }
                if (this.dUD_Rounds.SelectedItem == null && tmp1)
                {
                    MessageBox.Show("Select number of maximum rounds");
                    temp2 = false;
                }
            }

            player1 = tbName1.Text;
            player2 = tbName2.Text;

            if(temp1 && temp2 && tmp1)
            {
                //this.Close();
                Form1 f = new Form1();
                f.Show();
            }
           
        }

        private void btnBack_MouseHover(object sender, EventArgs e)
        {
            btnBack.Font = new Font(" ", 14);
        }

        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            btnBack.Font = new Font(" ", 12);
        }

        private void btnStart_MouseHover(object sender, EventArgs e)
        {
            btnStart.Font = new Font(" ", 14);
        }

        private void btnSart_MouseLeave(object sender, EventArgs e)
        {
            btnStart.Font = new Font(" ", 12);
        }

        private void Form_Options_Load(object sender, EventArgs e)
        {           
            DomainUpDown.DomainUpDownItemCollection collection = this.dUD_Rounds.Items;
            DomainUpDown.DomainUpDownItemCollection collectionSec = this.dUD_Seconds.Items;

            collection.Add("3");
            collection.Add("5");
            collection.Add("7");
            collection.Add("9");

            this.dUD_Rounds.Text = "Select";

            for(int i=10;i<=90;i++)
                collectionSec.Add(i.ToString());

            this.dUD_Seconds.Text = "Select";
        }
    }
}
