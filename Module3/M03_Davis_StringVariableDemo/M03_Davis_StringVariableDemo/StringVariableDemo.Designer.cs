namespace M03_Davis_StringVariableDemo
{
    partial class StringVariableDemo
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
            this.EnterFirstName = new System.Windows.Forms.Label();
            this.EnterLastName = new System.Windows.Forms.Label();
            this.YourFullNameIs = new System.Windows.Forms.Label();
            this.FullNameDisplay = new System.Windows.Forms.Label();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.FirstNameInput = new System.Windows.Forms.TextBox();
            this.LastNameInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EnterFirstName
            // 
            this.EnterFirstName.AutoSize = true;
            this.EnterFirstName.Location = new System.Drawing.Point(63, 58);
            this.EnterFirstName.Name = "EnterFirstName";
            this.EnterFirstName.Size = new System.Drawing.Size(103, 13);
            this.EnterFirstName.TabIndex = 0;
            this.EnterFirstName.Text = "Enter your first name";
            // 
            // EnterLastName
            // 
            this.EnterLastName.AutoSize = true;
            this.EnterLastName.Location = new System.Drawing.Point(63, 83);
            this.EnterLastName.Name = "EnterLastName";
            this.EnterLastName.Size = new System.Drawing.Size(103, 13);
            this.EnterLastName.TabIndex = 1;
            this.EnterLastName.Text = "Enter your last name";
            // 
            // YourFullNameIs
            // 
            this.YourFullNameIs.AutoSize = true;
            this.YourFullNameIs.Location = new System.Drawing.Point(63, 112);
            this.YourFullNameIs.Name = "YourFullNameIs";
            this.YourFullNameIs.Size = new System.Drawing.Size(90, 13);
            this.YourFullNameIs.TabIndex = 2;
            this.YourFullNameIs.Text = "Your Full Name Is";
            // 
            // FullNameDisplay
            // 
            this.FullNameDisplay.AutoSize = true;
            this.FullNameDisplay.Location = new System.Drawing.Point(199, 112);
            this.FullNameDisplay.Name = "FullNameDisplay";
            this.FullNameDisplay.Size = new System.Drawing.Size(0, 13);
            this.FullNameDisplay.TabIndex = 3;
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Location = new System.Drawing.Point(68, 165);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(97, 26);
            this.SubmitBtn.TabIndex = 4;
            this.SubmitBtn.Text = "Show &Name";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitBtn.Location = new System.Drawing.Point(202, 165);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(97, 26);
            this.ExitBtn.TabIndex = 5;
            this.ExitBtn.Text = "E&xit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // FirstNameInput
            // 
            this.FirstNameInput.Location = new System.Drawing.Point(202, 55);
            this.FirstNameInput.Name = "FirstNameInput";
            this.FirstNameInput.Size = new System.Drawing.Size(97, 20);
            this.FirstNameInput.TabIndex = 6;
            // 
            // LastNameInput
            // 
            this.LastNameInput.Location = new System.Drawing.Point(202, 80);
            this.LastNameInput.Name = "LastNameInput";
            this.LastNameInput.Size = new System.Drawing.Size(97, 20);
            this.LastNameInput.TabIndex = 7;
            // 
            // StringVariableDemo
            // 
            this.AcceptButton = this.SubmitBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ExitBtn;
            this.ClientSize = new System.Drawing.Size(360, 226);
            this.Controls.Add(this.LastNameInput);
            this.Controls.Add(this.FirstNameInput);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.FullNameDisplay);
            this.Controls.Add(this.YourFullNameIs);
            this.Controls.Add(this.EnterLastName);
            this.Controls.Add(this.EnterFirstName);
            this.Name = "StringVariableDemo";
            this.Text = "String Variable Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EnterFirstName;
        private System.Windows.Forms.Label EnterLastName;
        private System.Windows.Forms.Label YourFullNameIs;
        private System.Windows.Forms.Label FullNameDisplay;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.TextBox FirstNameInput;
        private System.Windows.Forms.TextBox LastNameInput;
    }
}

