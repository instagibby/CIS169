namespace M10_Davis_EmployeeAndProductionWorkerClasses
{
    partial class EmployeeAndProductionWorkerClass
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.numberLabel = new System.Windows.Forms.Label();
            this.employeeNameTextBox = new System.Windows.Forms.TextBox();
            this.employeeNumberTextBox = new System.Windows.Forms.TextBox();
            this.employeePayRateTextBox = new System.Windows.Forms.TextBox();
            this.payRateLabel = new System.Windows.Forms.Label();
            this.nameDisplayLabel = new System.Windows.Forms.Label();
            this.numberDisplayLabel = new System.Windows.Forms.Label();
            this.hourlyRateDisplay = new System.Windows.Forms.Label();
            this.shiftNumberDisplay = new System.Windows.Forms.Label();
            this.CreateWorkerBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.dayShiftCheckBox = new System.Windows.Forms.RadioButton();
            this.nightShiftCheckBox = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(81, 30);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(85, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Employee name:";
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Location = new System.Drawing.Point(70, 56);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(96, 13);
            this.numberLabel.TabIndex = 1;
            this.numberLabel.Text = "Employee Number:";
            // 
            // employeeNameTextBox
            // 
            this.employeeNameTextBox.Location = new System.Drawing.Point(178, 27);
            this.employeeNameTextBox.Name = "employeeNameTextBox";
            this.employeeNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.employeeNameTextBox.TabIndex = 4;
            // 
            // employeeNumberTextBox
            // 
            this.employeeNumberTextBox.Location = new System.Drawing.Point(178, 53);
            this.employeeNumberTextBox.Name = "employeeNumberTextBox";
            this.employeeNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.employeeNumberTextBox.TabIndex = 5;
            // 
            // employeePayRateTextBox
            // 
            this.employeePayRateTextBox.Location = new System.Drawing.Point(178, 79);
            this.employeePayRateTextBox.Name = "employeePayRateTextBox";
            this.employeePayRateTextBox.Size = new System.Drawing.Size(100, 20);
            this.employeePayRateTextBox.TabIndex = 7;
            // 
            // payRateLabel
            // 
            this.payRateLabel.AutoSize = true;
            this.payRateLabel.Location = new System.Drawing.Point(63, 82);
            this.payRateLabel.Name = "payRateLabel";
            this.payRateLabel.Size = new System.Drawing.Size(103, 13);
            this.payRateLabel.TabIndex = 6;
            this.payRateLabel.Text = "Employee Pay Rate:";
            // 
            // nameDisplayLabel
            // 
            this.nameDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameDisplayLabel.Location = new System.Drawing.Point(123, 136);
            this.nameDisplayLabel.Name = "nameDisplayLabel";
            this.nameDisplayLabel.Size = new System.Drawing.Size(91, 18);
            this.nameDisplayLabel.TabIndex = 8;
            this.nameDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numberDisplayLabel
            // 
            this.numberDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numberDisplayLabel.Location = new System.Drawing.Point(123, 169);
            this.numberDisplayLabel.Name = "numberDisplayLabel";
            this.numberDisplayLabel.Size = new System.Drawing.Size(91, 18);
            this.numberDisplayLabel.TabIndex = 9;
            this.numberDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hourlyRateDisplay
            // 
            this.hourlyRateDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hourlyRateDisplay.Location = new System.Drawing.Point(123, 232);
            this.hourlyRateDisplay.Name = "hourlyRateDisplay";
            this.hourlyRateDisplay.Size = new System.Drawing.Size(91, 18);
            this.hourlyRateDisplay.TabIndex = 10;
            this.hourlyRateDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // shiftNumberDisplay
            // 
            this.shiftNumberDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.shiftNumberDisplay.Location = new System.Drawing.Point(123, 199);
            this.shiftNumberDisplay.Name = "shiftNumberDisplay";
            this.shiftNumberDisplay.Size = new System.Drawing.Size(91, 18);
            this.shiftNumberDisplay.TabIndex = 11;
            this.shiftNumberDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CreateWorkerBtn
            // 
            this.CreateWorkerBtn.Location = new System.Drawing.Point(64, 269);
            this.CreateWorkerBtn.Name = "CreateWorkerBtn";
            this.CreateWorkerBtn.Size = new System.Drawing.Size(102, 31);
            this.CreateWorkerBtn.TabIndex = 12;
            this.CreateWorkerBtn.Text = "&Create Worker";
            this.CreateWorkerBtn.UseVisualStyleBackColor = true;
            this.CreateWorkerBtn.Click += new System.EventHandler(this.CreateWorkerBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitBtn.Location = new System.Drawing.Point(199, 269);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(79, 31);
            this.ExitBtn.TabIndex = 13;
            this.ExitBtn.Text = "E&xit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // dayShiftCheckBox
            // 
            this.dayShiftCheckBox.AutoSize = true;
            this.dayShiftCheckBox.Location = new System.Drawing.Point(98, 105);
            this.dayShiftCheckBox.Name = "dayShiftCheckBox";
            this.dayShiftCheckBox.Size = new System.Drawing.Size(68, 17);
            this.dayShiftCheckBox.TabIndex = 14;
            this.dayShiftCheckBox.TabStop = true;
            this.dayShiftCheckBox.Text = "Day Shift";
            this.dayShiftCheckBox.UseVisualStyleBackColor = true;
            // 
            // nightShiftCheckBox
            // 
            this.nightShiftCheckBox.AutoSize = true;
            this.nightShiftCheckBox.Location = new System.Drawing.Point(172, 105);
            this.nightShiftCheckBox.Name = "nightShiftCheckBox";
            this.nightShiftCheckBox.Size = new System.Drawing.Size(74, 17);
            this.nightShiftCheckBox.TabIndex = 15;
            this.nightShiftCheckBox.TabStop = true;
            this.nightShiftCheckBox.Text = "Night Shift";
            this.nightShiftCheckBox.UseVisualStyleBackColor = true;
            // 
            // EmployeeAndProductionWorkerClass
            // 
            this.AcceptButton = this.CreateWorkerBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ExitBtn;
            this.ClientSize = new System.Drawing.Size(348, 331);
            this.Controls.Add(this.nightShiftCheckBox);
            this.Controls.Add(this.dayShiftCheckBox);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.CreateWorkerBtn);
            this.Controls.Add(this.shiftNumberDisplay);
            this.Controls.Add(this.hourlyRateDisplay);
            this.Controls.Add(this.numberDisplayLabel);
            this.Controls.Add(this.nameDisplayLabel);
            this.Controls.Add(this.employeePayRateTextBox);
            this.Controls.Add(this.payRateLabel);
            this.Controls.Add(this.employeeNumberTextBox);
            this.Controls.Add(this.employeeNameTextBox);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "EmployeeAndProductionWorkerClass";
            this.Text = "Employee and Production Worker Class";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.TextBox employeeNameTextBox;
        private System.Windows.Forms.TextBox employeeNumberTextBox;
        private System.Windows.Forms.TextBox employeePayRateTextBox;
        private System.Windows.Forms.Label payRateLabel;
        private System.Windows.Forms.Label nameDisplayLabel;
        private System.Windows.Forms.Label numberDisplayLabel;
        private System.Windows.Forms.Label hourlyRateDisplay;
        private System.Windows.Forms.Label shiftNumberDisplay;
        private System.Windows.Forms.Button CreateWorkerBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.RadioButton dayShiftCheckBox;
        private System.Windows.Forms.RadioButton nightShiftCheckBox;
    }
}

