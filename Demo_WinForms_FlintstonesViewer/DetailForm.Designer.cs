namespace WinForms_DataViewer
{
    partial class DetailForm
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
            this.picBox_Photo = new System.Windows.Forms.PictureBox();
            this.lbl_FullName = new System.Windows.Forms.Label();
            this.lbl_Age = new System.Windows.Forms.Label();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Photo)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox_Photo
            // 
            this.picBox_Photo.Location = new System.Drawing.Point(24, 76);
            this.picBox_Photo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picBox_Photo.Name = "picBox_Photo";
            this.picBox_Photo.Size = new System.Drawing.Size(210, 264);
            this.picBox_Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_Photo.TabIndex = 3;
            this.picBox_Photo.TabStop = false;
            // 
            // lbl_FullName
            // 
            this.lbl_FullName.AutoSize = true;
            this.lbl_FullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FullName.Location = new System.Drawing.Point(17, 11);
            this.lbl_FullName.Name = "lbl_FullName";
            this.lbl_FullName.Size = new System.Drawing.Size(164, 37);
            this.lbl_FullName.TabIndex = 4;
            this.lbl_FullName.Text = "Full Name";
            // 
            // lbl_Age
            // 
            this.lbl_Age.AutoSize = true;
            this.lbl_Age.Location = new System.Drawing.Point(272, 105);
            this.lbl_Age.Name = "lbl_Age";
            this.lbl_Age.Size = new System.Drawing.Size(38, 20);
            this.lbl_Age.TabIndex = 5;
            this.lbl_Age.Text = "Age";
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Location = new System.Drawing.Point(272, 148);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(63, 20);
            this.lbl_Gender.TabIndex = 6;
            this.lbl_Gender.Text = "Gender";
            // 
            // lbl_Description
            // 
            this.lbl_Description.Location = new System.Drawing.Point(49, 344);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(536, 407);
            this.lbl_Description.TabIndex = 7;
            this.lbl_Description.Text = "Description";
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(276, 774);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(84, 35);
            this.btn_Close.TabIndex = 8;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.button1_Click);
            // 
            // DetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 832);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.lbl_Description);
            this.Controls.Add(this.lbl_Gender);
            this.Controls.Add(this.lbl_Age);
            this.Controls.Add(this.lbl_FullName);
            this.Controls.Add(this.picBox_Photo);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DetailForm";
            this.Text = "DetailForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.DetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picBox_Photo;
        private System.Windows.Forms.Label lbl_FullName;
        private System.Windows.Forms.Label lbl_Age;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.Button btn_Close;
    }
}