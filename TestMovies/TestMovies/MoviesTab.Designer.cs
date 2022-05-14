namespace TestMovies
{
    partial class MoviesTab
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.NameLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ImageMovie = new System.Windows.Forms.PictureBox();
            this.RatingLabel = new System.Windows.Forms.Label();
            this.YearLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageMovie)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.ForeColor = System.Drawing.Color.White;
            this.NameLabel.Location = new System.Drawing.Point(127, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NameLabel.Size = new System.Drawing.Size(185, 63);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Монстры на каникулах: Трансформания";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TestMovies.Properties.Resources.ic_star_outline_128_28865__1_;
            this.pictureBox2.Location = new System.Drawing.Point(131, 66);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // ImageMovie
            // 
            this.ImageMovie.Enabled = false;
            this.ImageMovie.Image = global::TestMovies.Properties.Resources._400x600_1_7baa27896748958c70599ee7a6914973_733x1100_0xac120003_9930679121562899278;
            this.ImageMovie.Location = new System.Drawing.Point(0, 0);
            this.ImageMovie.Name = "ImageMovie";
            this.ImageMovie.Size = new System.Drawing.Size(127, 187);
            this.ImageMovie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageMovie.TabIndex = 0;
            this.ImageMovie.TabStop = false;
            // 
            // RatingLabel
            // 
            this.RatingLabel.AutoSize = true;
            this.RatingLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RatingLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(192)))), ((int)(((byte)(45)))));
            this.RatingLabel.Location = new System.Drawing.Point(175, 72);
            this.RatingLabel.Name = "RatingLabel";
            this.RatingLabel.Size = new System.Drawing.Size(39, 25);
            this.RatingLabel.TabIndex = 4;
            this.RatingLabel.Text = "0.0";
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YearLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(132)))), ((int)(((byte)(145)))));
            this.YearLabel.Location = new System.Drawing.Point(133, 117);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(46, 25);
            this.YearLabel.TabIndex = 5;
            this.YearLabel.Text = "Год:";
            // 
            // MoviesTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.Controls.Add(this.YearLabel);
            this.Controls.Add(this.RatingLabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.ImageMovie);
            this.Name = "MoviesTab";
            this.Size = new System.Drawing.Size(312, 205);
            this.Leave += new System.EventHandler(this.MoviesTab_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageMovie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ImageMovie;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label RatingLabel;
        private System.Windows.Forms.Label YearLabel;
    }
}
