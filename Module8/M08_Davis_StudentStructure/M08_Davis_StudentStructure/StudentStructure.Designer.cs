namespace M08_Davis_StudentStructure
{
    partial class StudentStructure
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
            this.CreateStudent = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.studentNameLabel = new System.Windows.Forms.Label();
            this.studentIDLabel = new System.Windows.Forms.Label();
            this.studentMajorLabel = new System.Windows.Forms.Label();
            this.EnterStudentInfoLabel = new System.Windows.Forms.Label();
            this.studentNameTextBox = new System.Windows.Forms.TextBox();
            this.studentIDTextBox = new System.Windows.Forms.TextBox();
            this.studentMajorTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CreateStudent
            // 
            this.CreateStudent.Location = new System.Drawing.Point(51, 135);
            this.CreateStudent.Name = "CreateStudent";
            this.CreateStudent.Size = new System.Drawing.Size(104, 23);
            this.CreateStudent.TabIndex = 0;
            this.CreateStudent.Text = "&Create Student";
            this.CreateStudent.UseVisualStyleBackColor = true;
            this.CreateStudent.Click += new System.EventHandler(this.CreateStudent_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitBtn.Location = new System.Drawing.Point(179, 135);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(53, 23);
            this.ExitBtn.TabIndex = 1;
            this.ExitBtn.Text = "E&xit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // studentNameLabel
            // 
            this.studentNameLabel.AutoSize = true;
            this.studentNameLabel.Location = new System.Drawing.Point(39, 58);
            this.studentNameLabel.Name = "studentNameLabel";
            this.studentNameLabel.Size = new System.Drawing.Size(78, 13);
            this.studentNameLabel.TabIndex = 2;
            this.studentNameLabel.Text = "Student Name:";
            // 
            // studentIDLabel
            // 
            this.studentIDLabel.AutoSize = true;
            this.studentIDLabel.Location = new System.Drawing.Point(56, 83);
            this.studentIDLabel.Name = "studentIDLabel";
            this.studentIDLabel.Size = new System.Drawing.Size(61, 13);
            this.studentIDLabel.TabIndex = 3;
            this.studentIDLabel.Text = "Student ID:";
            // 
            // studentMajorLabel
            // 
            this.studentMajorLabel.AutoSize = true;
            this.studentMajorLabel.Location = new System.Drawing.Point(41, 107);
            this.studentMajorLabel.Name = "studentMajorLabel";
            this.studentMajorLabel.Size = new System.Drawing.Size(76, 13);
            this.studentMajorLabel.TabIndex = 4;
            this.studentMajorLabel.Text = "Student Major:";
            // 
            // EnterStudentInfoLabel
            // 
            this.EnterStudentInfoLabel.AutoSize = true;
            this.EnterStudentInfoLabel.Location = new System.Drawing.Point(63, 30);
            this.EnterStudentInfoLabel.Name = "EnterStudentInfoLabel";
            this.EnterStudentInfoLabel.Size = new System.Drawing.Size(153, 13);
            this.EnterStudentInfoLabel.TabIndex = 6;
            this.EnterStudentInfoLabel.Text = "Please Enter the Student\'s Info";
            // 
            // studentNameTextBox
            // 
            this.studentNameTextBox.Location = new System.Drawing.Point(123, 55);
            this.studentNameTextBox.Name = "studentNameTextBox";
            this.studentNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.studentNameTextBox.TabIndex = 7;
            // 
            // studentIDTextBox
            // 
            this.studentIDTextBox.Location = new System.Drawing.Point(123, 80);
            this.studentIDTextBox.Name = "studentIDTextBox";
            this.studentIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.studentIDTextBox.TabIndex = 8;
            // 
            // studentMajorTextBox
            // 
            this.studentMajorTextBox.Location = new System.Drawing.Point(123, 104);
            this.studentMajorTextBox.Name = "studentMajorTextBox";
            this.studentMajorTextBox.Size = new System.Drawing.Size(100, 20);
            this.studentMajorTextBox.TabIndex = 9;
            // 
            // StudentStructure
            // 
            this.AcceptButton = this.CreateStudent;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ExitBtn;
            this.ClientSize = new System.Drawing.Size(287, 188);
            this.Controls.Add(this.studentMajorTextBox);
            this.Controls.Add(this.studentIDTextBox);
            this.Controls.Add(this.studentNameTextBox);
            this.Controls.Add(this.EnterStudentInfoLabel);
            this.Controls.Add(this.studentMajorLabel);
            this.Controls.Add(this.studentIDLabel);
            this.Controls.Add(this.studentNameLabel);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.CreateStudent);
            this.Name = "StudentStructure";
            this.Text = "Student Structure";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateStudent;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label studentNameLabel;
        private System.Windows.Forms.Label studentIDLabel;
        private System.Windows.Forms.Label studentMajorLabel;
        private System.Windows.Forms.Label EnterStudentInfoLabel;
        private System.Windows.Forms.TextBox studentNameTextBox;
        private System.Windows.Forms.TextBox studentIDTextBox;
        private System.Windows.Forms.TextBox studentMajorTextBox;
    }
}

