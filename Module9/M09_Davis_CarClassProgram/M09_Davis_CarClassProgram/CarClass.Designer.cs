namespace M09_Davis_CarClassProgram
{
    partial class CarClass
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
            this.yearLabel = new System.Windows.Forms.Label();
            this.makeLabel = new System.Windows.Forms.Label();
            this.speedLabel = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.AccelBtn = new System.Windows.Forms.Button();
            this.BrakeBtn = new System.Windows.Forms.Button();
            this.YearDisplayLabel = new System.Windows.Forms.Label();
            this.MakeDisplayLabel = new System.Windows.Forms.Label();
            this.SpeedDisplayLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(78, 43);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(32, 13);
            this.yearLabel.TabIndex = 0;
            this.yearLabel.Text = "Year:";
            // 
            // makeLabel
            // 
            this.makeLabel.AutoSize = true;
            this.makeLabel.Location = new System.Drawing.Point(73, 69);
            this.makeLabel.Name = "makeLabel";
            this.makeLabel.Size = new System.Drawing.Size(37, 13);
            this.makeLabel.TabIndex = 1;
            this.makeLabel.Text = "Make:";
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Location = new System.Drawing.Point(69, 95);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(41, 13);
            this.speedLabel.TabIndex = 2;
            this.speedLabel.Text = "Speed:";
            // 
            // ExitBtn
            // 
            this.ExitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitBtn.Location = new System.Drawing.Point(176, 127);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(37, 23);
            this.ExitBtn.TabIndex = 7;
            this.ExitBtn.Text = "E&xit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // AccelBtn
            // 
            this.AccelBtn.Location = new System.Drawing.Point(104, 127);
            this.AccelBtn.Name = "AccelBtn";
            this.AccelBtn.Size = new System.Drawing.Size(66, 23);
            this.AccelBtn.TabIndex = 8;
            this.AccelBtn.Text = "&Accelerate";
            this.AccelBtn.UseVisualStyleBackColor = true;
            this.AccelBtn.Click += new System.EventHandler(this.AccelBtn_Click);
            // 
            // BrakeBtn
            // 
            this.BrakeBtn.Location = new System.Drawing.Point(51, 127);
            this.BrakeBtn.Name = "BrakeBtn";
            this.BrakeBtn.Size = new System.Drawing.Size(47, 23);
            this.BrakeBtn.TabIndex = 9;
            this.BrakeBtn.Text = "&Brake";
            this.BrakeBtn.UseVisualStyleBackColor = true;
            this.BrakeBtn.Click += new System.EventHandler(this.BrakeBtn_Click);
            // 
            // YearDisplayLabel
            // 
            this.YearDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.YearDisplayLabel.Location = new System.Drawing.Point(119, 40);
            this.YearDisplayLabel.Name = "YearDisplayLabel";
            this.YearDisplayLabel.Size = new System.Drawing.Size(51, 19);
            this.YearDisplayLabel.TabIndex = 10;
            this.YearDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MakeDisplayLabel
            // 
            this.MakeDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MakeDisplayLabel.Location = new System.Drawing.Point(119, 66);
            this.MakeDisplayLabel.Name = "MakeDisplayLabel";
            this.MakeDisplayLabel.Size = new System.Drawing.Size(51, 19);
            this.MakeDisplayLabel.TabIndex = 11;
            this.MakeDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SpeedDisplayLabel
            // 
            this.SpeedDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SpeedDisplayLabel.Location = new System.Drawing.Point(119, 92);
            this.SpeedDisplayLabel.Name = "SpeedDisplayLabel";
            this.SpeedDisplayLabel.Size = new System.Drawing.Size(51, 19);
            this.SpeedDisplayLabel.TabIndex = 12;
            this.SpeedDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CarClass
            // 
            this.AcceptButton = this.AccelBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ExitBtn;
            this.ClientSize = new System.Drawing.Size(253, 178);
            this.Controls.Add(this.SpeedDisplayLabel);
            this.Controls.Add(this.MakeDisplayLabel);
            this.Controls.Add(this.YearDisplayLabel);
            this.Controls.Add(this.BrakeBtn);
            this.Controls.Add(this.AccelBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.makeLabel);
            this.Controls.Add(this.yearLabel);
            this.Name = "CarClass";
            this.Text = "Car Class";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label makeLabel;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button AccelBtn;
        private System.Windows.Forms.Button BrakeBtn;
        private System.Windows.Forms.Label YearDisplayLabel;
        private System.Windows.Forms.Label MakeDisplayLabel;
        private System.Windows.Forms.Label SpeedDisplayLabel;
    }
}

