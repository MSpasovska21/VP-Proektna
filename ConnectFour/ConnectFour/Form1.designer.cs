namespace VP_Proekt_Connect4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlBoard = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPlayerOne = new System.Windows.Forms.Label();
            this.lblPlayerTwo = new System.Windows.Forms.Label();
            this.lblPlayer2TL = new System.Windows.Forms.Label();
            this.lblRounds1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbPlayer1 = new System.Windows.Forms.ProgressBar();
            this.pbPlayer2 = new System.Windows.Forms.ProgressBar();
            this.lblTurn = new System.Windows.Forms.Label();
            this.lblPlayer1TL = new System.Windows.Forms.Label();
            this.lblRounds2 = new System.Windows.Forms.Label();
            this.lblDraw = new System.Windows.Forms.Label();
            this.lblBestOf = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlBoard
            // 
            this.pnlBoard.Location = new System.Drawing.Point(461, 34);
            this.pnlBoard.Name = "pnlBoard";
            this.pnlBoard.Size = new System.Drawing.Size(700, 600);
            this.pnlBoard.TabIndex = 0;
            this.pnlBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBoard_Paint);
            this.pnlBoard.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlBoard_MouseClick);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // lblPlayerOne
            // 
            this.lblPlayerOne.AutoSize = true;
            this.lblPlayerOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerOne.ForeColor = System.Drawing.Color.Green;
            this.lblPlayerOne.Location = new System.Drawing.Point(12, 40);
            this.lblPlayerOne.Name = "lblPlayerOne";
            this.lblPlayerOne.Size = new System.Drawing.Size(73, 17);
            this.lblPlayerOne.TabIndex = 1;
            this.lblPlayerOne.Text = "Player 1:";
            // 
            // lblPlayerTwo
            // 
            this.lblPlayerTwo.AutoSize = true;
            this.lblPlayerTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerTwo.ForeColor = System.Drawing.Color.Red;
            this.lblPlayerTwo.Location = new System.Drawing.Point(12, 174);
            this.lblPlayerTwo.Name = "lblPlayerTwo";
            this.lblPlayerTwo.Size = new System.Drawing.Size(73, 17);
            this.lblPlayerTwo.TabIndex = 2;
            this.lblPlayerTwo.Text = "Player 2:";
            // 
            // lblPlayer2TL
            // 
            this.lblPlayer2TL.AutoSize = true;
            this.lblPlayer2TL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2TL.ForeColor = System.Drawing.Color.Green;
            this.lblPlayer2TL.Location = new System.Drawing.Point(242, 194);
            this.lblPlayer2TL.Name = "lblPlayer2TL";
            this.lblPlayer2TL.Size = new System.Drawing.Size(106, 20);
            this.lblPlayer2TL.TabIndex = 3;
            this.lblPlayer2TL.Text = "lblPlayer2TL";
            // 
            // lblRounds1
            // 
            this.lblRounds1.AutoSize = true;
            this.lblRounds1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRounds1.ForeColor = System.Drawing.Color.Green;
            this.lblRounds1.Location = new System.Drawing.Point(12, 374);
            this.lblRounds1.Name = "lblRounds1";
            this.lblRounds1.Size = new System.Drawing.Size(184, 17);
            this.lblRounds1.TabIndex = 4;
            this.lblRounds1.Text = "Player 1 Rounds Won: 0";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbPlayer1
            // 
            this.pbPlayer1.Location = new System.Drawing.Point(91, 34);
            this.pbPlayer1.Name = "pbPlayer1";
            this.pbPlayer1.Size = new System.Drawing.Size(338, 23);
            this.pbPlayer1.TabIndex = 9;
            // 
            // pbPlayer2
            // 
            this.pbPlayer2.Location = new System.Drawing.Point(91, 168);
            this.pbPlayer2.Name = "pbPlayer2";
            this.pbPlayer2.Size = new System.Drawing.Size(338, 23);
            this.pbPlayer2.TabIndex = 10;
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.ForeColor = System.Drawing.Color.Red;
            this.lblTurn.Location = new System.Drawing.Point(776, 9);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(135, 24);
            this.lblTurn.TabIndex = 11;
            this.lblTurn.Text = "Player 1 Turn";
            // 
            // lblPlayer1TL
            // 
            this.lblPlayer1TL.AutoSize = true;
            this.lblPlayer1TL.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer1TL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1TL.ForeColor = System.Drawing.Color.Green;
            this.lblPlayer1TL.Location = new System.Drawing.Point(242, 60);
            this.lblPlayer1TL.Name = "lblPlayer1TL";
            this.lblPlayer1TL.Size = new System.Drawing.Size(106, 20);
            this.lblPlayer1TL.TabIndex = 12;
            this.lblPlayer1TL.Text = "lblPlayer1TL";
            // 
            // lblRounds2
            // 
            this.lblRounds2.AutoSize = true;
            this.lblRounds2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRounds2.ForeColor = System.Drawing.Color.Red;
            this.lblRounds2.Location = new System.Drawing.Point(12, 471);
            this.lblRounds2.Name = "lblRounds2";
            this.lblRounds2.Size = new System.Drawing.Size(184, 17);
            this.lblRounds2.TabIndex = 13;
            this.lblRounds2.Text = "Player 2 Rounds Won: 0";
            // 
            // lblDraw
            // 
            this.lblDraw.AutoSize = true;
            this.lblDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDraw.Location = new System.Drawing.Point(12, 560);
            this.lblDraw.Name = "lblDraw";
            this.lblDraw.Size = new System.Drawing.Size(71, 17);
            this.lblDraw.TabIndex = 14;
            this.lblDraw.Text = "Draws: 0";
            // 
            // lblBestOf
            // 
            this.lblBestOf.AutoSize = true;
            this.lblBestOf.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBestOf.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblBestOf.Location = new System.Drawing.Point(144, 274);
            this.lblBestOf.Name = "lblBestOf";
            this.lblBestOf.Size = new System.Drawing.Size(69, 29);
            this.lblBestOf.TabIndex = 15;
            this.lblBestOf.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 711);
            this.Controls.Add(this.lblBestOf);
            this.Controls.Add(this.lblDraw);
            this.Controls.Add(this.lblRounds2);
            this.Controls.Add(this.lblPlayer1TL);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.pbPlayer2);
            this.Controls.Add(this.pbPlayer1);
            this.Controls.Add(this.lblRounds1);
            this.Controls.Add(this.lblPlayer2TL);
            this.Controls.Add(this.lblPlayerTwo);
            this.Controls.Add(this.lblPlayerOne);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlBoard);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Connect 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBoard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPlayerOne;
        private System.Windows.Forms.Label lblPlayerTwo;
        private System.Windows.Forms.Label lblPlayer2TL;
        private System.Windows.Forms.Label lblRounds1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar pbPlayer1;
        private System.Windows.Forms.ProgressBar pbPlayer2;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Label lblPlayer1TL;
        private System.Windows.Forms.Label lblRounds2;
        private System.Windows.Forms.Label lblDraw;
        private System.Windows.Forms.Label lblBestOf;
    }
}

