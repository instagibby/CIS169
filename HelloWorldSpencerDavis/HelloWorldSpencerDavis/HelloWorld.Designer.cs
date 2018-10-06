namespace HelloWorldSpencerDavis
{
    partial class HelloWorld
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
            this.MessageButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MessageButton
            // 
            this.MessageButton.Location = new System.Drawing.Point(12, 12);
            this.MessageButton.Name = "MessageButton";
            this.MessageButton.Size = new System.Drawing.Size(142, 73);
            this.MessageButton.TabIndex = 0;
            this.MessageButton.Text = "Display Message";
            this.MessageButton.UseVisualStyleBackColor = true;
            this.MessageButton.Click += new System.EventHandler(this.MessageButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(155, 86);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(65, 25);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // HelloWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 123);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.MessageButton);
            this.Name = "HelloWorld";
            this.Text = "Hello World";
            this.Load += new System.EventHandler(this.HelloWorld_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MessageButton;
        private System.Windows.Forms.Button exitButton;
    }
}

