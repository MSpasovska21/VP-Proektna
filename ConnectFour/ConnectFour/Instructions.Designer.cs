namespace ConnectFour
{
    partial class Instructions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Instructions));
            this.tbInstructions = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbInstructions
            // 
            this.tbInstructions.Location = new System.Drawing.Point(0, 0);
            this.tbInstructions.Multiline = true;
            this.tbInstructions.Name = "tbInstructions";
            this.tbInstructions.ReadOnly = true;
            this.tbInstructions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbInstructions.Size = new System.Drawing.Size(285, 260);
            this.tbInstructions.TabIndex = 0;
            this.tbInstructions.TabStop = false;
            // 
            // Instructions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tbInstructions);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Instructions";
            this.Text = "How to play";
            this.Load += new System.EventHandler(this.Instructions_Load);
            this.Resize += new System.EventHandler(this.Insttructions_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInstructions;
    }
}