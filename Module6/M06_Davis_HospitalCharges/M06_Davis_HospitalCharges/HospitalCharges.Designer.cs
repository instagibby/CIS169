namespace M06_Davis_HospitalCharges
{
    partial class HospitalCharges
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
            this.daysLabel = new System.Windows.Forms.Label();
            this.medicationLabel = new System.Windows.Forms.Label();
            this.surgicalLabel = new System.Windows.Forms.Label();
            this.labFeeLabel = new System.Windows.Forms.Label();
            this.daysSpentTextBox = new System.Windows.Forms.TextBox();
            this.medicationTextBox = new System.Windows.Forms.TextBox();
            this.surgicalTextBox = new System.Windows.Forms.TextBox();
            this.labFeesTextBox = new System.Windows.Forms.TextBox();
            this.physicalRehabTextBox = new System.Windows.Forms.TextBox();
            this.physicalRehabLabel = new System.Windows.Forms.Label();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.chargesBox = new System.Windows.Forms.Label();
            this.totalChargeValueLabel = new System.Windows.Forms.Label();
            this.miscChargeValueLabel = new System.Windows.Forms.Label();
            this.totalChargeLabel = new System.Windows.Forms.Label();
            this.miscChargesLabel = new System.Windows.Forms.Label();
            this.baseChargeValueLabel = new System.Windows.Forms.Label();
            this.baseChargeLabel = new System.Windows.Forms.Label();
            this.resetBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // daysLabel
            // 
            this.daysLabel.AutoSize = true;
            this.daysLabel.Location = new System.Drawing.Point(22, 18);
            this.daysLabel.Name = "daysLabel";
            this.daysLabel.Size = new System.Drawing.Size(113, 13);
            this.daysLabel.TabIndex = 0;
            this.daysLabel.Text = "Days spent in hospital:";
            // 
            // medicationLabel
            // 
            this.medicationLabel.AutoSize = true;
            this.medicationLabel.Location = new System.Drawing.Point(32, 44);
            this.medicationLabel.Name = "medicationLabel";
            this.medicationLabel.Size = new System.Drawing.Size(104, 13);
            this.medicationLabel.TabIndex = 1;
            this.medicationLabel.Text = "Medication Charges:";
            // 
            // surgicalLabel
            // 
            this.surgicalLabel.AutoSize = true;
            this.surgicalLabel.Location = new System.Drawing.Point(46, 70);
            this.surgicalLabel.Name = "surgicalLabel";
            this.surgicalLabel.Size = new System.Drawing.Size(90, 13);
            this.surgicalLabel.TabIndex = 2;
            this.surgicalLabel.Text = "Surgical Charges:";
            // 
            // labFeeLabel
            // 
            this.labFeeLabel.AutoSize = true;
            this.labFeeLabel.Location = new System.Drawing.Point(84, 96);
            this.labFeeLabel.Name = "labFeeLabel";
            this.labFeeLabel.Size = new System.Drawing.Size(51, 13);
            this.labFeeLabel.TabIndex = 3;
            this.labFeeLabel.Text = "Lab fees:";
            // 
            // daysSpentTextBox
            // 
            this.daysSpentTextBox.Location = new System.Drawing.Point(141, 15);
            this.daysSpentTextBox.Name = "daysSpentTextBox";
            this.daysSpentTextBox.Size = new System.Drawing.Size(65, 20);
            this.daysSpentTextBox.TabIndex = 5;
            // 
            // medicationTextBox
            // 
            this.medicationTextBox.Location = new System.Drawing.Point(141, 41);
            this.medicationTextBox.Name = "medicationTextBox";
            this.medicationTextBox.Size = new System.Drawing.Size(65, 20);
            this.medicationTextBox.TabIndex = 6;
            // 
            // surgicalTextBox
            // 
            this.surgicalTextBox.Location = new System.Drawing.Point(141, 67);
            this.surgicalTextBox.Name = "surgicalTextBox";
            this.surgicalTextBox.Size = new System.Drawing.Size(65, 20);
            this.surgicalTextBox.TabIndex = 7;
            // 
            // labFeesTextBox
            // 
            this.labFeesTextBox.Location = new System.Drawing.Point(141, 93);
            this.labFeesTextBox.Name = "labFeesTextBox";
            this.labFeesTextBox.Size = new System.Drawing.Size(65, 20);
            this.labFeesTextBox.TabIndex = 8;
            // 
            // physicalRehabTextBox
            // 
            this.physicalRehabTextBox.Location = new System.Drawing.Point(141, 119);
            this.physicalRehabTextBox.Name = "physicalRehabTextBox";
            this.physicalRehabTextBox.Size = new System.Drawing.Size(65, 20);
            this.physicalRehabTextBox.TabIndex = 9;
            // 
            // physicalRehabLabel
            // 
            this.physicalRehabLabel.AutoSize = true;
            this.physicalRehabLabel.Location = new System.Drawing.Point(10, 122);
            this.physicalRehabLabel.Name = "physicalRehabLabel";
            this.physicalRehabLabel.Size = new System.Drawing.Size(125, 13);
            this.physicalRehabLabel.TabIndex = 10;
            this.physicalRehabLabel.Text = "Physical Rehab charges:";
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(10, 270);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(65, 23);
            this.calculateBtn.TabIndex = 11;
            this.calculateBtn.Text = "&Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(156, 270);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(46, 23);
            this.exitBtn.TabIndex = 12;
            this.exitBtn.Text = "E&xit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // chargesBox
            // 
            this.chargesBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chargesBox.Location = new System.Drawing.Point(10, 157);
            this.chargesBox.Name = "chargesBox";
            this.chargesBox.Size = new System.Drawing.Size(197, 96);
            this.chargesBox.TabIndex = 21;
            // 
            // totalChargeValueLabel
            // 
            this.totalChargeValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalChargeValueLabel.Location = new System.Drawing.Point(105, 221);
            this.totalChargeValueLabel.Name = "totalChargeValueLabel";
            this.totalChargeValueLabel.Size = new System.Drawing.Size(91, 19);
            this.totalChargeValueLabel.TabIndex = 27;
            this.totalChargeValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // miscChargeValueLabel
            // 
            this.miscChargeValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.miscChargeValueLabel.Location = new System.Drawing.Point(105, 196);
            this.miscChargeValueLabel.Name = "miscChargeValueLabel";
            this.miscChargeValueLabel.Size = new System.Drawing.Size(91, 19);
            this.miscChargeValueLabel.TabIndex = 26;
            this.miscChargeValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalChargeLabel
            // 
            this.totalChargeLabel.AutoSize = true;
            this.totalChargeLabel.Location = new System.Drawing.Point(21, 222);
            this.totalChargeLabel.Name = "totalChargeLabel";
            this.totalChargeLabel.Size = new System.Drawing.Size(76, 13);
            this.totalChargeLabel.TabIndex = 25;
            this.totalChargeLabel.Text = "Total Charges:";
            // 
            // miscChargesLabel
            // 
            this.miscChargesLabel.AutoSize = true;
            this.miscChargesLabel.Location = new System.Drawing.Point(22, 197);
            this.miscChargesLabel.Name = "miscChargesLabel";
            this.miscChargesLabel.Size = new System.Drawing.Size(74, 13);
            this.miscChargesLabel.TabIndex = 24;
            this.miscChargesLabel.Text = "Misc Charges:";
            // 
            // baseChargeValueLabel
            // 
            this.baseChargeValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.baseChargeValueLabel.Location = new System.Drawing.Point(105, 172);
            this.baseChargeValueLabel.Name = "baseChargeValueLabel";
            this.baseChargeValueLabel.Size = new System.Drawing.Size(91, 19);
            this.baseChargeValueLabel.TabIndex = 23;
            this.baseChargeValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // baseChargeLabel
            // 
            this.baseChargeLabel.AutoSize = true;
            this.baseChargeLabel.Location = new System.Drawing.Point(21, 173);
            this.baseChargeLabel.Name = "baseChargeLabel";
            this.baseChargeLabel.Size = new System.Drawing.Size(76, 13);
            this.baseChargeLabel.TabIndex = 22;
            this.baseChargeLabel.Text = "Base Charges:";
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(104, 270);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(46, 23);
            this.resetBtn.TabIndex = 28;
            this.resetBtn.Text = "&Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // HospitalCharges
            // 
            this.AcceptButton = this.calculateBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitBtn;
            this.ClientSize = new System.Drawing.Size(224, 314);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.totalChargeValueLabel);
            this.Controls.Add(this.miscChargeValueLabel);
            this.Controls.Add(this.totalChargeLabel);
            this.Controls.Add(this.miscChargesLabel);
            this.Controls.Add(this.baseChargeValueLabel);
            this.Controls.Add(this.baseChargeLabel);
            this.Controls.Add(this.chargesBox);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.physicalRehabLabel);
            this.Controls.Add(this.physicalRehabTextBox);
            this.Controls.Add(this.labFeesTextBox);
            this.Controls.Add(this.surgicalTextBox);
            this.Controls.Add(this.medicationTextBox);
            this.Controls.Add(this.daysSpentTextBox);
            this.Controls.Add(this.labFeeLabel);
            this.Controls.Add(this.surgicalLabel);
            this.Controls.Add(this.medicationLabel);
            this.Controls.Add(this.daysLabel);
            this.Name = "HospitalCharges";
            this.Text = "Hospital Charges";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label daysLabel;
        private System.Windows.Forms.Label medicationLabel;
        private System.Windows.Forms.Label surgicalLabel;
        private System.Windows.Forms.Label labFeeLabel;
        private System.Windows.Forms.TextBox daysSpentTextBox;
        private System.Windows.Forms.TextBox medicationTextBox;
        private System.Windows.Forms.TextBox surgicalTextBox;
        private System.Windows.Forms.TextBox labFeesTextBox;
        private System.Windows.Forms.TextBox physicalRehabTextBox;
        private System.Windows.Forms.Label physicalRehabLabel;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label chargesBox;
        private System.Windows.Forms.Label totalChargeValueLabel;
        private System.Windows.Forms.Label miscChargeValueLabel;
        private System.Windows.Forms.Label totalChargeLabel;
        private System.Windows.Forms.Label miscChargesLabel;
        private System.Windows.Forms.Label baseChargeValueLabel;
        private System.Windows.Forms.Label baseChargeLabel;
        private System.Windows.Forms.Button resetBtn;
    }
}

