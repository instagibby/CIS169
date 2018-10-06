namespace M04_Davis_DaysOfTheWeek
{
    partial class DaysOfTheWeek
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
            this.enterNumberLabel = new System.Windows.Forms.Label();
            this.numberInputTextBox = new System.Windows.Forms.TextBox();
            this.showDayBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.todayIsDisplay = new System.Windows.Forms.Label();
            this.dayIsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enterNumberLabel
            // 
            this.enterNumberLabel.AutoSize = true;
            this.enterNumberLabel.Location = new System.Drawing.Point(23, 45);
            this.enterNumberLabel.Name = "enterNumberLabel";
            this.enterNumberLabel.Size = new System.Drawing.Size(108, 13);
            this.enterNumberLabel.TabIndex = 0;
            this.enterNumberLabel.Text = "Enter a Number (1-7):";
            // 
            // numberInputTextBox
            // 
            this.numberInputTextBox.Location = new System.Drawing.Point(137, 42);
            this.numberInputTextBox.Name = "numberInputTextBox";
            this.numberInputTextBox.Size = new System.Drawing.Size(46, 20);
            this.numberInputTextBox.TabIndex = 1;
            this.numberInputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // showDayBtn
            // 
            this.showDayBtn.Location = new System.Drawing.Point(12, 105);
            this.showDayBtn.Name = "showDayBtn";
            this.showDayBtn.Size = new System.Drawing.Size(82, 29);
            this.showDayBtn.TabIndex = 2;
            this.showDayBtn.Text = "&Show day";
            this.showDayBtn.UseVisualStyleBackColor = true;
            this.showDayBtn.Click += new System.EventHandler(this.showDayBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(127, 105);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(82, 29);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "E&xit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // todayIsDisplay
            // 
            this.todayIsDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.todayIsDisplay.Location = new System.Drawing.Point(91, 70);
            this.todayIsDisplay.Name = "todayIsDisplay";
            this.todayIsDisplay.Size = new System.Drawing.Size(92, 23);
            this.todayIsDisplay.TabIndex = 4;
            this.todayIsDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dayIsLabel
            // 
            this.dayIsLabel.AutoSize = true;
            this.dayIsLabel.Location = new System.Drawing.Point(23, 75);
            this.dayIsLabel.Name = "dayIsLabel";
            this.dayIsLabel.Size = new System.Drawing.Size(62, 13);
            this.dayIsLabel.TabIndex = 5;
            this.dayIsLabel.Text = "That day is:";
            // 
            // DaysOfTheWeek
            // 
            this.AcceptButton = this.showDayBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitBtn;
            this.ClientSize = new System.Drawing.Size(221, 169);
            this.Controls.Add(this.dayIsLabel);
            this.Controls.Add(this.todayIsDisplay);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.showDayBtn);
            this.Controls.Add(this.numberInputTextBox);
            this.Controls.Add(this.enterNumberLabel);
            this.Name = "DaysOfTheWeek";
            this.Text = "Days of the Week";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterNumberLabel;
        private System.Windows.Forms.TextBox numberInputTextBox;
        private System.Windows.Forms.Button showDayBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label todayIsDisplay;
        private System.Windows.Forms.Label dayIsLabel;
    }
}

