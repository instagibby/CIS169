namespace M04_Davis_TimeCalculatorProgram
{
    partial class TimeCalculatorProgram
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
            this.resultsLabel = new System.Windows.Forms.Label();
            this.displayBoxOutline = new System.Windows.Forms.Label();
            this.secondsInputTextBox = new System.Windows.Forms.TextBox();
            this.enterSecondsLabel = new System.Windows.Forms.Label();
            this.daysLabel = new System.Windows.Forms.Label();
            this.hoursLabel = new System.Windows.Forms.Label();
            this.minutesLabel = new System.Windows.Forms.Label();
            this.secondsLabel = new System.Windows.Forms.Label();
            this.CalculateBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.daysPrintLabel = new System.Windows.Forms.Label();
            this.hoursPrintLabel = new System.Windows.Forms.Label();
            this.minutesPrintLabel = new System.Windows.Forms.Label();
            this.secondsPrintLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resultsLabel
            // 
            this.resultsLabel.AutoSize = true;
            this.resultsLabel.Location = new System.Drawing.Point(37, 60);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(42, 13);
            this.resultsLabel.TabIndex = 7;
            this.resultsLabel.Text = "Results";
            // 
            // displayBoxOutline
            // 
            this.displayBoxOutline.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.displayBoxOutline.Location = new System.Drawing.Point(27, 66);
            this.displayBoxOutline.Name = "displayBoxOutline";
            this.displayBoxOutline.Size = new System.Drawing.Size(242, 138);
            this.displayBoxOutline.TabIndex = 6;
            // 
            // secondsInputTextBox
            // 
            this.secondsInputTextBox.Location = new System.Drawing.Point(147, 18);
            this.secondsInputTextBox.Name = "secondsInputTextBox";
            this.secondsInputTextBox.Size = new System.Drawing.Size(122, 20);
            this.secondsInputTextBox.TabIndex = 5;
            // 
            // enterSecondsLabel
            // 
            this.enterSecondsLabel.AutoSize = true;
            this.enterSecondsLabel.Location = new System.Drawing.Point(24, 21);
            this.enterSecondsLabel.Name = "enterSecondsLabel";
            this.enterSecondsLabel.Size = new System.Drawing.Size(80, 13);
            this.enterSecondsLabel.TabIndex = 4;
            this.enterSecondsLabel.Text = "Enter Seconds:";
            // 
            // daysLabel
            // 
            this.daysLabel.AutoSize = true;
            this.daysLabel.Location = new System.Drawing.Point(37, 92);
            this.daysLabel.Name = "daysLabel";
            this.daysLabel.Size = new System.Drawing.Size(34, 13);
            this.daysLabel.TabIndex = 8;
            this.daysLabel.Text = "Days:";
            // 
            // hoursLabel
            // 
            this.hoursLabel.AutoSize = true;
            this.hoursLabel.Location = new System.Drawing.Point(37, 121);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(38, 13);
            this.hoursLabel.TabIndex = 9;
            this.hoursLabel.Text = "Hours:";
            // 
            // minutesLabel
            // 
            this.minutesLabel.AutoSize = true;
            this.minutesLabel.Location = new System.Drawing.Point(37, 148);
            this.minutesLabel.Name = "minutesLabel";
            this.minutesLabel.Size = new System.Drawing.Size(47, 13);
            this.minutesLabel.TabIndex = 10;
            this.minutesLabel.Text = "Minutes:";
            // 
            // secondsLabel
            // 
            this.secondsLabel.AutoSize = true;
            this.secondsLabel.Location = new System.Drawing.Point(37, 175);
            this.secondsLabel.Name = "secondsLabel";
            this.secondsLabel.Size = new System.Drawing.Size(52, 13);
            this.secondsLabel.TabIndex = 11;
            this.secondsLabel.Text = "Seconds:";
            // 
            // CalculateBtn
            // 
            this.CalculateBtn.Location = new System.Drawing.Point(12, 220);
            this.CalculateBtn.Name = "CalculateBtn";
            this.CalculateBtn.Size = new System.Drawing.Size(76, 23);
            this.CalculateBtn.TabIndex = 13;
            this.CalculateBtn.Text = "C&alculate";
            this.CalculateBtn.UseVisualStyleBackColor = true;
            this.CalculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(109, 220);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(76, 23);
            this.ClearBtn.TabIndex = 14;
            this.ClearBtn.Text = "&Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitBtn.Location = new System.Drawing.Point(206, 220);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(76, 23);
            this.ExitBtn.TabIndex = 15;
            this.ExitBtn.Text = "E&xit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // daysPrintLabel
            // 
            this.daysPrintLabel.AutoSize = true;
            this.daysPrintLabel.Location = new System.Drawing.Point(211, 92);
            this.daysPrintLabel.Name = "daysPrintLabel";
            this.daysPrintLabel.Size = new System.Drawing.Size(13, 13);
            this.daysPrintLabel.TabIndex = 16;
            this.daysPrintLabel.Text = "0";
            // 
            // hoursPrintLabel
            // 
            this.hoursPrintLabel.AutoSize = true;
            this.hoursPrintLabel.Location = new System.Drawing.Point(211, 121);
            this.hoursPrintLabel.Name = "hoursPrintLabel";
            this.hoursPrintLabel.Size = new System.Drawing.Size(13, 13);
            this.hoursPrintLabel.TabIndex = 17;
            this.hoursPrintLabel.Text = "0";
            // 
            // minutesPrintLabel
            // 
            this.minutesPrintLabel.AutoSize = true;
            this.minutesPrintLabel.Location = new System.Drawing.Point(211, 148);
            this.minutesPrintLabel.Name = "minutesPrintLabel";
            this.minutesPrintLabel.Size = new System.Drawing.Size(13, 13);
            this.minutesPrintLabel.TabIndex = 18;
            this.minutesPrintLabel.Text = "0";
            // 
            // secondsPrintLabel
            // 
            this.secondsPrintLabel.AutoSize = true;
            this.secondsPrintLabel.Location = new System.Drawing.Point(211, 175);
            this.secondsPrintLabel.Name = "secondsPrintLabel";
            this.secondsPrintLabel.Size = new System.Drawing.Size(13, 13);
            this.secondsPrintLabel.TabIndex = 19;
            this.secondsPrintLabel.Text = "0";
            // 
            // TimeCalculatorProgram
            // 
            this.AcceptButton = this.CalculateBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ExitBtn;
            this.ClientSize = new System.Drawing.Size(305, 271);
            this.Controls.Add(this.secondsPrintLabel);
            this.Controls.Add(this.minutesPrintLabel);
            this.Controls.Add(this.hoursPrintLabel);
            this.Controls.Add(this.daysPrintLabel);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.CalculateBtn);
            this.Controls.Add(this.secondsLabel);
            this.Controls.Add(this.minutesLabel);
            this.Controls.Add(this.hoursLabel);
            this.Controls.Add(this.daysLabel);
            this.Controls.Add(this.resultsLabel);
            this.Controls.Add(this.displayBoxOutline);
            this.Controls.Add(this.secondsInputTextBox);
            this.Controls.Add(this.enterSecondsLabel);
            this.Name = "TimeCalculatorProgram";
            this.Text = "Time Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label resultsLabel;
        private System.Windows.Forms.Label displayBoxOutline;
        private System.Windows.Forms.TextBox secondsInputTextBox;
        private System.Windows.Forms.Label enterSecondsLabel;
        private System.Windows.Forms.Label daysLabel;
        private System.Windows.Forms.Label hoursLabel;
        private System.Windows.Forms.Label minutesLabel;
        private System.Windows.Forms.Label secondsLabel;
        private System.Windows.Forms.Button CalculateBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label daysPrintLabel;
        private System.Windows.Forms.Label hoursPrintLabel;
        private System.Windows.Forms.Label minutesPrintLabel;
        private System.Windows.Forms.Label secondsPrintLabel;
    }
}

