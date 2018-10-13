namespace M02_Davis_TextBoxDemo
{
    partial class TextBoxDemo
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
            this.ReadInputButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.DisplayNameEntered = new System.Windows.Forms.Label();
            this.EnterYourNameBox = new System.Windows.Forms.TextBox();
            this.YouEnteredLabel = new System.Windows.Forms.Label();
            this.EnterYourNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ReadInputButton
            // 
            this.ReadInputButton.Location = new System.Drawing.Point(50, 112);
            this.ReadInputButton.Name = "ReadInputButton";
            this.ReadInputButton.Size = new System.Drawing.Size(83, 24);
            this.ReadInputButton.TabIndex = 18;
            this.ReadInputButton.Text = "Read I&nput";
            this.ReadInputButton.UseVisualStyleBackColor = true;
            this.ReadInputButton.Click += new System.EventHandler(this.ReadInputButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitButton.Location = new System.Drawing.Point(156, 112);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(83, 24);
            this.ExitButton.TabIndex = 17;
            this.ExitButton.Text = "E&xit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // DisplayNameEntered
            // 
            this.DisplayNameEntered.AutoSize = true;
            this.DisplayNameEntered.Location = new System.Drawing.Point(153, 82);
            this.DisplayNameEntered.Name = "DisplayNameEntered";
            this.DisplayNameEntered.Size = new System.Drawing.Size(0, 13);
            this.DisplayNameEntered.TabIndex = 16;
            // 
            // EnterYourNameBox
            // 
            this.EnterYourNameBox.Location = new System.Drawing.Point(156, 51);
            this.EnterYourNameBox.Name = "EnterYourNameBox";
            this.EnterYourNameBox.Size = new System.Drawing.Size(83, 20);
            this.EnterYourNameBox.TabIndex = 15;
            // 
            // YouEnteredLabel
            // 
            this.YouEnteredLabel.AutoSize = true;
            this.YouEnteredLabel.Location = new System.Drawing.Point(47, 82);
            this.YouEnteredLabel.Name = "YouEnteredLabel";
            this.YouEnteredLabel.Size = new System.Drawing.Size(68, 13);
            this.YouEnteredLabel.TabIndex = 14;
            this.YouEnteredLabel.Text = "You entered:";
            // 
            // EnterYourNameLabel
            // 
            this.EnterYourNameLabel.AutoSize = true;
            this.EnterYourNameLabel.Location = new System.Drawing.Point(47, 54);
            this.EnterYourNameLabel.Name = "EnterYourNameLabel";
            this.EnterYourNameLabel.Size = new System.Drawing.Size(87, 13);
            this.EnterYourNameLabel.TabIndex = 13;
            this.EnterYourNameLabel.Text = "Enter your name:";
            // 
            // TextBoxDemo
            // 
            this.AcceptButton = this.ReadInputButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ExitButton;
            this.ClientSize = new System.Drawing.Size(284, 193);
            this.Controls.Add(this.ReadInputButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.DisplayNameEntered);
            this.Controls.Add(this.EnterYourNameBox);
            this.Controls.Add(this.YouEnteredLabel);
            this.Controls.Add(this.EnterYourNameLabel);
            this.Name = "TextBoxDemo";
            this.Text = "TextBox Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReadInputButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label DisplayNameEntered;
        private System.Windows.Forms.TextBox EnterYourNameBox;
        private System.Windows.Forms.Label YouEnteredLabel;
        private System.Windows.Forms.Label EnterYourNameLabel;
    }
}

