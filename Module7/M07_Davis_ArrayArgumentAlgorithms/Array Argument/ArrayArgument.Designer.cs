namespace Array_Argument
{
    partial class ArrayArgument
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
            this.outputListBox = new System.Windows.Forms.ListBox();
            this.goButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.FindMaxBtn = new System.Windows.Forms.Button();
            this.FindMinBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // outputListBox
            // 
            this.outputListBox.FormattingEnabled = true;
            this.outputListBox.Location = new System.Drawing.Point(43, 12);
            this.outputListBox.Name = "outputListBox";
            this.outputListBox.Size = new System.Drawing.Size(188, 134);
            this.outputListBox.TabIndex = 0;
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(43, 155);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(75, 23);
            this.goButton.TabIndex = 1;
            this.goButton.Text = "&Go";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(156, 155);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // FindMaxBtn
            // 
            this.FindMaxBtn.Location = new System.Drawing.Point(43, 184);
            this.FindMaxBtn.Name = "FindMaxBtn";
            this.FindMaxBtn.Size = new System.Drawing.Size(75, 23);
            this.FindMaxBtn.TabIndex = 3;
            this.FindMaxBtn.Text = "&Find Max";
            this.FindMaxBtn.UseVisualStyleBackColor = true;
            this.FindMaxBtn.Click += new System.EventHandler(this.FindMaxBtn_Click);
            // 
            // FindMinBtn
            // 
            this.FindMinBtn.Location = new System.Drawing.Point(156, 184);
            this.FindMinBtn.Name = "FindMinBtn";
            this.FindMinBtn.Size = new System.Drawing.Size(75, 23);
            this.FindMinBtn.TabIndex = 4;
            this.FindMinBtn.Text = "Find &Min";
            this.FindMinBtn.UseVisualStyleBackColor = true;
            this.FindMinBtn.Click += new System.EventHandler(this.FindMinBtn_Click);
            // 
            // ArrayArgument
            // 
            this.AcceptButton = this.goButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(275, 220);
            this.Controls.Add(this.FindMinBtn);
            this.Controls.Add(this.FindMaxBtn);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.outputListBox);
            this.Name = "ArrayArgument";
            this.Text = "Array Argument";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox outputListBox;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button FindMaxBtn;
        private System.Windows.Forms.Button FindMinBtn;
    }
}

