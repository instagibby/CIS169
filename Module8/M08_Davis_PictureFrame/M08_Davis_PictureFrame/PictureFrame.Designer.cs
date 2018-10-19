namespace M08_Davis_PictureFrame
{
    partial class PictureFrame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PictureFrame));
            this.photoList = new System.Windows.Forms.ImageList(this.components);
            this.PictureBoxDisplay = new System.Windows.Forms.PictureBox();
            this.ExitBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // photoList
            // 
            this.photoList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("photoList.ImageStream")));
            this.photoList.TransparentColor = System.Drawing.Color.Transparent;
            this.photoList.Images.SetKeyName(0, "shin.png");
            this.photoList.Images.SetKeyName(1, "shin2.png");
            this.photoList.Images.SetKeyName(2, "shin3.png");
            this.photoList.Images.SetKeyName(3, "ramenOptions.png");
            this.photoList.Images.SetKeyName(4, "massRamen.png");
            // 
            // PictureBoxDisplay
            // 
            this.PictureBoxDisplay.BackColor = System.Drawing.Color.White;
            this.PictureBoxDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBoxDisplay.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxDisplay.Image")));
            this.PictureBoxDisplay.Location = new System.Drawing.Point(12, 12);
            this.PictureBoxDisplay.Name = "PictureBoxDisplay";
            this.PictureBoxDisplay.Size = new System.Drawing.Size(256, 256);
            this.PictureBoxDisplay.TabIndex = 0;
            this.PictureBoxDisplay.TabStop = false;
            this.PictureBoxDisplay.Click += new System.EventHandler(this.PictureBoxDisplay_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitBtn.Location = new System.Drawing.Point(101, 274);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 23);
            this.ExitBtn.TabIndex = 1;
            this.ExitBtn.Text = "E&xit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // PictureFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ExitBtn;
            this.ClientSize = new System.Drawing.Size(279, 305);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.PictureBoxDisplay);
            this.Name = "PictureFrame";
            this.Text = "Picture Frame";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList photoList;
        private System.Windows.Forms.PictureBox PictureBoxDisplay;
        private System.Windows.Forms.Button ExitBtn;
    }
}

