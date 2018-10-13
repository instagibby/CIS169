namespace M02_Davis_HeadsOrTails
{
    partial class HeadsOrTails
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
            this.TailsImage = new System.Windows.Forms.PictureBox();
            this.HeadsImage = new System.Windows.Forms.PictureBox();
            this.ShowHeadsButton = new System.Windows.Forms.Button();
            this.FlipButton = new System.Windows.Forms.Button();
            this.ShowTailsButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TailsImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeadsImage)).BeginInit();
            this.SuspendLayout();
            // 
            // TailsImage
            // 
            this.TailsImage.Image = global::M02_Davis_HeadsOrTails.Properties.Resources.tails;
            this.TailsImage.Location = new System.Drawing.Point(135, 12);
            this.TailsImage.Name = "TailsImage";
            this.TailsImage.Size = new System.Drawing.Size(150, 150);
            this.TailsImage.TabIndex = 1;
            this.TailsImage.TabStop = false;
            // 
            // HeadsImage
            // 
            this.HeadsImage.BackgroundImage = global::M02_Davis_HeadsOrTails.Properties.Resources.heads;
            this.HeadsImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HeadsImage.Location = new System.Drawing.Point(135, 12);
            this.HeadsImage.Name = "HeadsImage";
            this.HeadsImage.Size = new System.Drawing.Size(150, 150);
            this.HeadsImage.TabIndex = 0;
            this.HeadsImage.TabStop = false;
            // 
            // ShowHeadsButton
            // 
            this.ShowHeadsButton.Location = new System.Drawing.Point(33, 197);
            this.ShowHeadsButton.Name = "ShowHeadsButton";
            this.ShowHeadsButton.Size = new System.Drawing.Size(92, 32);
            this.ShowHeadsButton.TabIndex = 2;
            this.ShowHeadsButton.Text = "Show &Heads";
            this.ShowHeadsButton.UseVisualStyleBackColor = true;
            this.ShowHeadsButton.Click += new System.EventHandler(this.ShowHeadsButton_Click);
            // 
            // FlipButton
            // 
            this.FlipButton.Location = new System.Drawing.Point(159, 197);
            this.FlipButton.Name = "FlipButton";
            this.FlipButton.Size = new System.Drawing.Size(92, 32);
            this.FlipButton.TabIndex = 3;
            this.FlipButton.Text = "&Flip it!";
            this.FlipButton.UseVisualStyleBackColor = true;
            this.FlipButton.Click += new System.EventHandler(this.FlipButton_Click);
            // 
            // ShowTailsButton
            // 
            this.ShowTailsButton.Location = new System.Drawing.Point(283, 197);
            this.ShowTailsButton.Name = "ShowTailsButton";
            this.ShowTailsButton.Size = new System.Drawing.Size(92, 32);
            this.ShowTailsButton.TabIndex = 4;
            this.ShowTailsButton.Text = "Show &Tails";
            this.ShowTailsButton.UseVisualStyleBackColor = true;
            this.ShowTailsButton.Click += new System.EventHandler(this.ShowTailsButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitButton.Location = new System.Drawing.Point(371, 235);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(38, 32);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "&Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // HeadsOrTails
            // 
            this.AcceptButton = this.FlipButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ExitButton;
            this.ClientSize = new System.Drawing.Size(421, 279);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ShowTailsButton);
            this.Controls.Add(this.FlipButton);
            this.Controls.Add(this.ShowHeadsButton);
            this.Controls.Add(this.TailsImage);
            this.Controls.Add(this.HeadsImage);
            this.Name = "HeadsOrTails";
            this.Text = "Heads or Tails";
            ((System.ComponentModel.ISupportInitialize)(this.TailsImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeadsImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox HeadsImage;
        private System.Windows.Forms.PictureBox TailsImage;
        private System.Windows.Forms.Button ShowHeadsButton;
        private System.Windows.Forms.Button FlipButton;
        private System.Windows.Forms.Button ShowTailsButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

