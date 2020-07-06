using System;
using System.CodeDom.Compiler;
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
    public partial class Form_Options : Form
    {

        private bool Exiting = true;

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
            string name1 = tbName1.Text;
            string name2 = tbName2.Text;

            bool temp1 = true;
            bool temp2 = true;

            if (name1.Length < 2 && name2.Length < 2)
            {
                MessageBox.Show("Enter name for Player1 and Player2 longer than 1 character");
                temp1 = false; temp2 = false;
            }
            else
            {
                if (name1.Length < 2)
                {
                    MessageBox.Show("Enter name for Player1 longer than 1 character");
                    temp1 = false;
                }
                if (name2.Length < 2)
                {
                    MessageBox.Show("Enter name for Player2 longer than 1 character");
                    temp2 = false;
                }
            }            


            if(temp1 && temp2)
            {
                Form1 f = new Form1();
                f.Show();
                Exiting = false;
                this.Close();
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

            this.dUD_Rounds.Text = "3";

            collectionSec.Add("10");
            collectionSec.Add("11");
            collectionSec.Add("12");
            collectionSec.Add("13");
            collectionSec.Add("14");
            collectionSec.Add("15");
            collectionSec.Add("16");
            collectionSec.Add("17");
            collectionSec.Add("18");
            collectionSec.Add("19");
            collectionSec.Add("20");
            collectionSec.Add("21");
            collectionSec.Add("22");
            collectionSec.Add("23");
            collectionSec.Add("24");
            collectionSec.Add("25");
            collectionSec.Add("26");
            collectionSec.Add("27");
            collectionSec.Add("28");
            collectionSec.Add("29");
            collectionSec.Add("30");

            this.dUD_Seconds.Text = "10";
        }

        private void Form_Options_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Exiting)
            {
                Application.Exit();
            }

        }
    }
}
