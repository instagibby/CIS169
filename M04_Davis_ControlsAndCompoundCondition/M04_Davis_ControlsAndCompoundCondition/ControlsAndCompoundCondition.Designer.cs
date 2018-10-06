namespace M04_Davis_ControlsAndCompoundCondition
{
    partial class ControlsAndCompoundCondition
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
            this.promptLabel = new System.Windows.Forms.Label();
            this.cityListBox = new System.Windows.Forms.ListBox();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.timeZoneLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SubmitCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // promptLabel
            // 
            this.promptLabel.AutoSize = true;
            this.promptLabel.Location = new System.Drawing.Point(28, 9);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(221, 13);
            this.promptLabel.TabIndex = 0;
            this.promptLabel.Text = "Select a city and I will give you the time zone.";
            // 
            // cityListBox
            // 
            this.cityListBox.FormattingEnabled = true;
            this.cityListBox.Items.AddRange(new object[] {
            "Denver",
            "Honolulu",
            "Minneapolis",
            "New York",
            "San Francisco"});
            this.cityListBox.Location = new System.Drawing.Point(90, 34);
            this.cityListBox.Name = "cityListBox";
            this.cityListBox.Size = new System.Drawing.Size(96, 69);
            this.cityListBox.TabIndex = 1;
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Location = new System.Drawing.Point(44, 135);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(61, 13);
            this.outputDescriptionLabel.TabIndex = 2;
            this.outputDescriptionLabel.Text = "Time Zone:";
            // 
            // timeZoneLabel
            // 
            this.timeZoneLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeZoneLabel.Location = new System.Drawing.Point(111, 129);
            this.timeZoneLabel.Name = "timeZoneLabel";
            this.timeZoneLabel.Size = new System.Drawing.Size(96, 24);
            this.timeZoneLabel.TabIndex = 3;
            this.timeZoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(61, 169);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(64, 22);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "O&K";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(131, 169);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(64, 22);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // SubmitCheckBox
            // 
            this.SubmitCheckBox.AutoSize = true;
            this.SubmitCheckBox.Location = new System.Drawing.Point(47, 109);
            this.SubmitCheckBox.Name = "SubmitCheckBox";
            this.SubmitCheckBox.Size = new System.Drawing.Size(58, 17);
            this.SubmitCheckBox.TabIndex = 6;
            this.SubmitCheckBox.Text = "Submit";
            this.SubmitCheckBox.UseVisualStyleBackColor = true;
            this.SubmitCheckBox.CheckedChanged += new System.EventHandler(this.SubmitCheckBox_CheckedChanged);
            // 
            // ControlsAndCompoundCondition
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(263, 212);
            this.Controls.Add(this.SubmitCheckBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.timeZoneLabel);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.cityListBox);
            this.Controls.Add(this.promptLabel);
            this.Name = "ControlsAndCompoundCondition";
            this.Text = "Time Zone";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label promptLabel;
        private System.Windows.Forms.ListBox cityListBox;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.Label timeZoneLabel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.CheckBox SubmitCheckBox;
    }
}

