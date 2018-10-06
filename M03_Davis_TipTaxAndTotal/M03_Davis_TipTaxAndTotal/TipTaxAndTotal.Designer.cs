namespace M03_Davis_TipTaxAndTotal
{
    partial class TipTaxAndTotal
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
            this.mealPriceLabel = new System.Windows.Forms.Label();
            this.tipLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.mealPriceTextBox = new System.Windows.Forms.TextBox();
            this.tipTextBox = new System.Windows.Forms.TextBox();
            this.taxTextBox = new System.Windows.Forms.TextBox();
            this.saleTotalLabel = new System.Windows.Forms.Label();
            this.totalBillTextBox = new System.Windows.Forms.TextBox();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mealPriceLabel
            // 
            this.mealPriceLabel.AutoSize = true;
            this.mealPriceLabel.Location = new System.Drawing.Point(51, 38);
            this.mealPriceLabel.Name = "mealPriceLabel";
            this.mealPriceLabel.Size = new System.Drawing.Size(109, 13);
            this.mealPriceLabel.TabIndex = 0;
            this.mealPriceLabel.Text = "Enter your meal price:";
            // 
            // tipLabel
            // 
            this.tipLabel.AutoSize = true;
            this.tipLabel.Location = new System.Drawing.Point(47, 64);
            this.tipLabel.Name = "tipLabel";
            this.tipLabel.Size = new System.Drawing.Size(113, 13);
            this.tipLabel.TabIndex = 1;
            this.tipLabel.Text = "Your tip amount (15%):";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Location = new System.Drawing.Point(50, 90);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(110, 13);
            this.taxLabel.TabIndex = 2;
            this.taxLabel.Text = "Your tax amount (7%):";
            // 
            // mealPriceTextBox
            // 
            this.mealPriceTextBox.Location = new System.Drawing.Point(166, 31);
            this.mealPriceTextBox.Name = "mealPriceTextBox";
            this.mealPriceTextBox.Size = new System.Drawing.Size(118, 20);
            this.mealPriceTextBox.TabIndex = 3;
            // 
            // tipTextBox
            // 
            this.tipTextBox.Location = new System.Drawing.Point(166, 57);
            this.tipTextBox.Name = "tipTextBox";
            this.tipTextBox.Size = new System.Drawing.Size(118, 20);
            this.tipTextBox.TabIndex = 4;
            // 
            // taxTextBox
            // 
            this.taxTextBox.Location = new System.Drawing.Point(166, 83);
            this.taxTextBox.Name = "taxTextBox";
            this.taxTextBox.Size = new System.Drawing.Size(118, 20);
            this.taxTextBox.TabIndex = 5;
            // 
            // saleTotalLabel
            // 
            this.saleTotalLabel.AutoSize = true;
            this.saleTotalLabel.Location = new System.Drawing.Point(61, 116);
            this.saleTotalLabel.Name = "saleTotalLabel";
            this.saleTotalLabel.Size = new System.Drawing.Size(99, 13);
            this.saleTotalLabel.TabIndex = 6;
            this.saleTotalLabel.Text = "Your total bill today:";
            // 
            // totalBillTextBox
            // 
            this.totalBillTextBox.Location = new System.Drawing.Point(166, 109);
            this.totalBillTextBox.Name = "totalBillTextBox";
            this.totalBillTextBox.Size = new System.Drawing.Size(118, 20);
            this.totalBillTextBox.TabIndex = 7;
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(50, 154);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(93, 40);
            this.calculateBtn.TabIndex = 8;
            this.calculateBtn.Text = "&Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitBtn.Location = new System.Drawing.Point(191, 154);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(93, 40);
            this.exitBtn.TabIndex = 9;
            this.exitBtn.Text = "E&xit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // TipTaxAndTotal
            // 
            this.AcceptButton = this.calculateBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitBtn;
            this.ClientSize = new System.Drawing.Size(316, 223);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.totalBillTextBox);
            this.Controls.Add(this.saleTotalLabel);
            this.Controls.Add(this.taxTextBox);
            this.Controls.Add(this.tipTextBox);
            this.Controls.Add(this.mealPriceTextBox);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.tipLabel);
            this.Controls.Add(this.mealPriceLabel);
            this.Name = "TipTaxAndTotal";
            this.Text = "Tip Tax and Total";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mealPriceLabel;
        private System.Windows.Forms.Label tipLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.TextBox mealPriceTextBox;
        private System.Windows.Forms.TextBox tipTextBox;
        private System.Windows.Forms.TextBox taxTextBox;
        private System.Windows.Forms.Label saleTotalLabel;
        private System.Windows.Forms.TextBox totalBillTextBox;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}

