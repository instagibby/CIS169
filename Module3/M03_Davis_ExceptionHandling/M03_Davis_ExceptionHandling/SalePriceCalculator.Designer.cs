namespace M03_Davis_ExceptionHandling
{
    partial class SalePriceCalculator
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
            this.OriginalPriceLabel = new System.Windows.Forms.Label();
            this.SalePriceLabel = new System.Windows.Forms.Label();
            this.SalePriceValue = new System.Windows.Forms.Label();
            this.originalPriceTextBox = new System.Windows.Forms.TextBox();
            this.discountPercentageTextBox = new System.Windows.Forms.TextBox();
            this.salePriceTextBox = new System.Windows.Forms.TextBox();
            this.CalculateBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OriginalPriceLabel
            // 
            this.OriginalPriceLabel.AutoSize = true;
            this.OriginalPriceLabel.Location = new System.Drawing.Point(14, 17);
            this.OriginalPriceLabel.Name = "OriginalPriceLabel";
            this.OriginalPriceLabel.Size = new System.Drawing.Size(144, 13);
            this.OriginalPriceLabel.TabIndex = 0;
            this.OriginalPriceLabel.Text = "Enter the item\'s original price:";
            // 
            // SalePriceLabel
            // 
            this.SalePriceLabel.AutoSize = true;
            this.SalePriceLabel.Location = new System.Drawing.Point(5, 44);
            this.SalePriceLabel.Name = "SalePriceLabel";
            this.SalePriceLabel.Size = new System.Drawing.Size(153, 13);
            this.SalePriceLabel.TabIndex = 1;
            this.SalePriceLabel.Text = "Enter the discount percentage:";
            // 
            // SalePriceValue
            // 
            this.SalePriceValue.AutoSize = true;
            this.SalePriceValue.Location = new System.Drawing.Point(101, 79);
            this.SalePriceValue.Name = "SalePriceValue";
            this.SalePriceValue.Size = new System.Drawing.Size(57, 13);
            this.SalePriceValue.TabIndex = 2;
            this.SalePriceValue.Text = "Sale price:";
            // 
            // originalPriceTextBox
            // 
            this.originalPriceTextBox.Location = new System.Drawing.Point(179, 14);
            this.originalPriceTextBox.Name = "originalPriceTextBox";
            this.originalPriceTextBox.Size = new System.Drawing.Size(101, 20);
            this.originalPriceTextBox.TabIndex = 3;
            // 
            // discountPercentageTextBox
            // 
            this.discountPercentageTextBox.Location = new System.Drawing.Point(179, 41);
            this.discountPercentageTextBox.Name = "discountPercentageTextBox";
            this.discountPercentageTextBox.Size = new System.Drawing.Size(101, 20);
            this.discountPercentageTextBox.TabIndex = 4;
            // 
            // salePriceTextBox
            // 
            this.salePriceTextBox.Location = new System.Drawing.Point(179, 76);
            this.salePriceTextBox.Name = "salePriceTextBox";
            this.salePriceTextBox.Size = new System.Drawing.Size(101, 20);
            this.salePriceTextBox.TabIndex = 5;
            // 
            // CalculateBtn
            // 
            this.CalculateBtn.Location = new System.Drawing.Point(50, 114);
            this.CalculateBtn.Name = "CalculateBtn";
            this.CalculateBtn.Size = new System.Drawing.Size(87, 43);
            this.CalculateBtn.TabIndex = 6;
            this.CalculateBtn.Text = "Calculate &Sale Price";
            this.CalculateBtn.UseVisualStyleBackColor = true;
            this.CalculateBtn.Click += new System.EventHandler(this.CalculateBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitBtn.Location = new System.Drawing.Point(159, 114);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(87, 43);
            this.ExitBtn.TabIndex = 7;
            this.ExitBtn.Text = "E&xit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            // 
            // SalePriceCalculator
            // 
            this.AcceptButton = this.CalculateBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ExitBtn;
            this.ClientSize = new System.Drawing.Size(298, 173);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.CalculateBtn);
            this.Controls.Add(this.salePriceTextBox);
            this.Controls.Add(this.discountPercentageTextBox);
            this.Controls.Add(this.originalPriceTextBox);
            this.Controls.Add(this.SalePriceValue);
            this.Controls.Add(this.SalePriceLabel);
            this.Controls.Add(this.OriginalPriceLabel);
            this.Name = "SalePriceCalculator";
            this.Text = "Sale Price Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OriginalPriceLabel;
        private System.Windows.Forms.Label SalePriceLabel;
        private System.Windows.Forms.Label SalePriceValue;
        private System.Windows.Forms.TextBox originalPriceTextBox;
        private System.Windows.Forms.TextBox discountPercentageTextBox;
        private System.Windows.Forms.TextBox salePriceTextBox;
        private System.Windows.Forms.Button CalculateBtn;
        private System.Windows.Forms.Button ExitBtn;
    }
}

