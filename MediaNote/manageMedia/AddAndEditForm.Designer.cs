namespace MediaNote.manageMedia
{
    partial class AddAndEditForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPersian = new System.Windows.Forms.TextBox();
            this.txtEnglish = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numerYear = new System.Windows.Forms.NumericUpDown();
            this.numerScore = new System.Windows.Forms.NumericUpDown();
            this.LblHide = new System.Windows.Forms.Label();
            this.txtCreator = new System.Windows.Forms.TextBox();
            this.LblCreator = new System.Windows.Forms.Label();
            this.txtInformation = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numerYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numerScore)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(394, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام فارسی:";
            // 
            // txtPersian
            // 
            this.txtPersian.Location = new System.Drawing.Point(267, 32);
            this.txtPersian.Name = "txtPersian";
            this.txtPersian.Size = new System.Drawing.Size(121, 25);
            this.txtPersian.TabIndex = 1;
            // 
            // txtEnglish
            // 
            this.txtEnglish.Location = new System.Drawing.Point(21, 32);
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.Size = new System.Drawing.Size(137, 25);
            this.txtEnglish.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "نام انگلیسی:";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(21, 97);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(385, 25);
            this.txtCountry.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "نام در کشور سازنده: (اگر فارسی یا انگلیسی نیست)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(412, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "سال انتشار:";
            // 
            // numerYear
            // 
            this.numerYear.Location = new System.Drawing.Point(270, 145);
            this.numerYear.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.numerYear.Minimum = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            this.numerYear.Name = "numerYear";
            this.numerYear.Size = new System.Drawing.Size(136, 25);
            this.numerYear.TabIndex = 7;
            this.numerYear.Value = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            // 
            // numerScore
            // 
            this.numerScore.Location = new System.Drawing.Point(22, 146);
            this.numerScore.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numerScore.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numerScore.Name = "numerScore";
            this.numerScore.Size = new System.Drawing.Size(136, 25);
            this.numerScore.TabIndex = 9;
            this.numerScore.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // LblHide
            // 
            this.LblHide.AutoSize = true;
            this.LblHide.Location = new System.Drawing.Point(163, 148);
            this.LblHide.Name = "LblHide";
            this.LblHide.Size = new System.Drawing.Size(88, 18);
            this.LblHide.TabIndex = 8;
            this.LblHide.Text = "نمره سایت IMDB:";
            // 
            // txtCreator
            // 
            this.txtCreator.Location = new System.Drawing.Point(21, 187);
            this.txtCreator.Name = "txtCreator";
            this.txtCreator.Size = new System.Drawing.Size(385, 25);
            this.txtCreator.TabIndex = 11;
            // 
            // LblCreator
            // 
            this.LblCreator.AutoSize = true;
            this.LblCreator.Location = new System.Drawing.Point(432, 190);
            this.LblCreator.Name = "LblCreator";
            this.LblCreator.Size = new System.Drawing.Size(40, 18);
            this.LblCreator.TabIndex = 10;
            this.LblCreator.Text = "سازنده:";
            // 
            // txtInformation
            // 
            this.txtInformation.Location = new System.Drawing.Point(21, 223);
            this.txtInformation.Multiline = true;
            this.txtInformation.Name = "txtInformation";
            this.txtInformation.Size = new System.Drawing.Size(385, 80);
            this.txtInformation.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(419, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "توضیحات:";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(394, 326);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 14;
            this.BtnSave.Text = "ثبت";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // AddAndEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.txtInformation);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCreator);
            this.Controls.Add(this.LblCreator);
            this.Controls.Add(this.numerScore);
            this.Controls.Add(this.LblHide);
            this.Controls.Add(this.numerYear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEnglish);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPersian);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Vazir", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddAndEditForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "خالی";
            this.Load += new System.EventHandler(this.AddAndEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numerYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numerScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPersian;
        private System.Windows.Forms.TextBox txtEnglish;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numerYear;
        private System.Windows.Forms.NumericUpDown numerScore;
        private System.Windows.Forms.Label LblHide;
        private System.Windows.Forms.TextBox txtCreator;
        private System.Windows.Forms.Label LblCreator;
        private System.Windows.Forms.TextBox txtInformation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnSave;
    }
}