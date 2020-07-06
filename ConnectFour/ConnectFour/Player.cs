using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_Proekt_Connect4
{
    class Player
    {
        public bool turn;
        public Color color;
        public int time;
        public string name;
        public Player(bool turn, Color color, int time, string name)
        {
            this.turn = turn;
            this.color = color;
            this.time = time;
            this.name = name;
        }
        public Player() { }
    }
}
