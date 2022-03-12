namespace MediaNote.manageMedia
{
    partial class AddAndViewImage
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnChoiseImage = new System.Windows.Forms.Button();
            this.PictureMedia = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureMedia)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnChoiseImage);
            this.groupBox1.Controls.Add(this.PictureMedia);
            this.groupBox1.Location = new System.Drawing.Point(12, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(310, 431);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "عکس رسانه";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(152, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "تایید";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnChoiseImage
            // 
            this.btnChoiseImage.Location = new System.Drawing.Point(6, 342);
            this.btnChoiseImage.Name = "btnChoiseImage";
            this.btnChoiseImage.Size = new System.Drawing.Size(140, 34);
            this.btnChoiseImage.TabIndex = 1;
            this.btnChoiseImage.Text = "انتخاب";
            this.btnChoiseImage.UseVisualStyleBackColor = true;
            this.btnChoiseImage.Click += new System.EventHandler(this.btnChoiseImage_Click);
            // 
            // PictureMedia
            // 
            this.PictureMedia.Image = global::MediaNote.Properties.Resources.Images_icon;
            this.PictureMedia.Location = new System.Drawing.Point(6, 25);
            this.PictureMedia.Name = "PictureMedia";
            this.PictureMedia.Size = new System.Drawing.Size(298, 311);
            this.PictureMedia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureMedia.TabIndex = 0;
            this.PictureMedia.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 382);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(298, 34);
            this.button2.TabIndex = 3;
            this.button2.Text = "لغو";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddAndViewImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 461);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Vazir", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddAndViewImage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "خالی";
            this.Load += new System.EventHandler(this.AddAndViewImage_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureMedia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox PictureMedia;
        private System.Windows.Forms.Button btnChoiseImage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}