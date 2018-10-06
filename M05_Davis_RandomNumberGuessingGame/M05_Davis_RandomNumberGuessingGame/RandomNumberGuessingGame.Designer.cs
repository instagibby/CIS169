namespace M05_Davis_RandomNumberGuessingGame
{
    partial class RandomNumberGuessingGame
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
            this.enterGuessLabel = new System.Windows.Forms.Label();
            this.UserInputTextBox = new System.Windows.Forms.TextBox();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.CheckGuessBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enterGuessLabel
            // 
            this.enterGuessLabel.AutoSize = true;
            this.enterGuessLabel.Location = new System.Drawing.Point(14, 15);
            this.enterGuessLabel.Name = "enterGuessLabel";
            this.enterGuessLabel.Size = new System.Drawing.Size(234, 13);
            this.enterGuessLabel.TabIndex = 0;
            this.enterGuessLabel.Text = "Enter your guess for the random number (1-100):";
            // 
            // UserInputTextBox
            // 
            this.UserInputTextBox.Location = new System.Drawing.Point(89, 40);
            this.UserInputTextBox.Name = "UserInputTextBox";
            this.UserInputTextBox.Size = new System.Drawing.Size(80, 20);
            this.UserInputTextBox.TabIndex = 1;
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(157, 66);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(90, 23);
            this.ExitBtn.TabIndex = 2;
            this.ExitBtn.Text = "E&xit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // CheckGuessBtn
            // 
            this.CheckGuessBtn.Location = new System.Drawing.Point(16, 66);
            this.CheckGuessBtn.Name = "CheckGuessBtn";
            this.CheckGuessBtn.Size = new System.Drawing.Size(90, 23);
            this.CheckGuessBtn.TabIndex = 3;
            this.CheckGuessBtn.Text = "&Check Guess";
            this.CheckGuessBtn.UseVisualStyleBackColor = true;
            this.CheckGuessBtn.Click += new System.EventHandler(this.CheckGuessBtn_Click);
            // 
            // RandomNumberGuessingGame
            // 
            this.AcceptButton = this.CheckGuessBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ExitBtn;
            this.ClientSize = new System.Drawing.Size(266, 103);
            this.Controls.Add(this.CheckGuessBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.UserInputTextBox);
            this.Controls.Add(this.enterGuessLabel);
            this.Name = "RandomNumberGuessingGame";
            this.Text = "Random Number Guessing Game";
            this.Load += new System.EventHandler(this.RandomNumberGuessingGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterGuessLabel;
        private System.Windows.Forms.TextBox UserInputTextBox;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button CheckGuessBtn;
    }
}

