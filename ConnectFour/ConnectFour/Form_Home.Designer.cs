namespace ConnectFour
{
    partial class Form_Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Home));
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnHowToPlay = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lnlRights = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.SystemColors.Control;
            this.btnPlay.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(154, 294);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(100, 40);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.Play_Click);
            this.btnPlay.MouseLeave += new System.EventHandler(this.Play_MouseLeave);
            this.btnPlay.MouseHover += new System.EventHandler(this.Play_MouseHover);
            // 
            // btnHowToPlay
            // 
            this.btnHowToPlay.BackColor = System.Drawing.SystemColors.Control;
            this.btnHowToPlay.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHowToPlay.Location = new System.Drawing.Point(290, 294);
            this.btnHowToPlay.Name = "btnHowToPlay";
            this.btnHowToPlay.Size = new System.Drawing.Size(150, 40);
            this.btnHowToPlay.TabIndex = 1;
            this.btnHowToPlay.Text = "How to play";
            this.btnHowToPlay.UseVisualStyleBackColor = false;
            this.btnHowToPlay.Click += new System.EventHandler(this.HowToPlay_Click);
            this.btnHowToPlay.MouseLeave += new System.EventHandler(this.HowToPlay_MouseLeave);
            this.btnHowToPlay.MouseHover += new System.EventHandler(this.HowToPlay_MouseHover);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Control;
            this.btnExit.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(477, 294);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 40);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.Exit_Click);
            this.btnExit.MouseLeave += new System.EventHandler(this.Exit_MouseLeave);
            this.btnExit.MouseHover += new System.EventHandler(this.Exit_MouseHover);
            // 
            // lnlRights
            // 
            this.lnlRights.AutoSize = true;
            this.lnlRights.BackColor = System.Drawing.Color.Transparent;
            this.lnlRights.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnlRights.LinkColor = System.Drawing.Color.White;
            this.lnlRights.Location = new System.Drawing.Point(23, 427);
            this.lnlRights.Name = "lnlRights";
            this.lnlRights.Size = new System.Drawing.Size(81, 15);
            this.lnlRights.TabIndex = 3;
            this.lnlRights.TabStop = true;
            this.lnlRights.Text = "© 2020 FCSE";
            this.lnlRights.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnlRights.Click += new System.EventHandler(this.lnlRights_Click);
            // 
            // Form_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::ConnectFour.Properties.Resources.naslovnaa;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.lnlRights);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnHowToPlay);
            this.Controls.Add(this.btnPlay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnHowToPlay;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.LinkLabel lnlRights;
    }
}

