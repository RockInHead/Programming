namespace Programming.View.Panels
{
    partial class FilmsPropertiesControl
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
            FilmGgroupBox = new GroupBox();
            RatingTextBox = new TextBox();
            label13 = new Label();
            GenreTextBox = new TextBox();
            label12 = new Label();
            YearTextBox = new TextBox();
            DurationTextBox = new TextBox();
            NameTextBox = new TextBox();
            FindMaxRatingButton = new Button();
            label9 = new Label();
            label10 = new Label();
            FilmsListBox = new ListBox();
            label11 = new Label();
            FilmGgroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // FilmGgroupBox
            // 
            FilmGgroupBox.Controls.Add(RatingTextBox);
            FilmGgroupBox.Controls.Add(label13);
            FilmGgroupBox.Controls.Add(GenreTextBox);
            FilmGgroupBox.Controls.Add(label12);
            FilmGgroupBox.Controls.Add(YearTextBox);
            FilmGgroupBox.Controls.Add(DurationTextBox);
            FilmGgroupBox.Controls.Add(NameTextBox);
            FilmGgroupBox.Controls.Add(FindMaxRatingButton);
            FilmGgroupBox.Controls.Add(label9);
            FilmGgroupBox.Controls.Add(label10);
            FilmGgroupBox.Controls.Add(FilmsListBox);
            FilmGgroupBox.Controls.Add(label11);
            FilmGgroupBox.Location = new Point(3, 3);
            FilmGgroupBox.Name = "FilmGgroupBox";
            FilmGgroupBox.Size = new Size(350, 402);
            FilmGgroupBox.TabIndex = 3;
            FilmGgroupBox.TabStop = false;
            FilmGgroupBox.Text = "Films";
            // 
            // RatingTextBox
            // 
            RatingTextBox.Location = new Point(191, 306);
            RatingTextBox.Name = "RatingTextBox";
            RatingTextBox.Size = new Size(125, 27);
            RatingTextBox.TabIndex = 10;
            RatingTextBox.TextChanged += RatingTextBox_TextChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(191, 281);
            label13.Name = "label13";
            label13.Size = new Size(55, 20);
            label13.TabIndex = 9;
            label13.Text = "Rating:";
            // 
            // GenreTextBox
            // 
            GenreTextBox.Location = new Point(189, 243);
            GenreTextBox.Name = "GenreTextBox";
            GenreTextBox.Size = new Size(125, 27);
            GenreTextBox.TabIndex = 8;
            GenreTextBox.TextChanged += GenreTextBox_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(189, 218);
            label12.Name = "label12";
            label12.Size = new Size(51, 20);
            label12.TabIndex = 7;
            label12.Text = "Genre:";
            // 
            // YearTextBox
            // 
            YearTextBox.Location = new Point(189, 179);
            YearTextBox.Name = "YearTextBox";
            YearTextBox.Size = new Size(125, 27);
            YearTextBox.TabIndex = 6;
            YearTextBox.TextChanged += YearTextBox_TextChanged;
            // 
            // DurationTextBox
            // 
            DurationTextBox.Location = new Point(189, 115);
            DurationTextBox.Name = "DurationTextBox";
            DurationTextBox.Size = new Size(125, 27);
            DurationTextBox.TabIndex = 5;
            DurationTextBox.TextChanged += DurationTextBox_TextChanged;
            // 
            // NameTextBox
            // 
            NameTextBox.BackColor = System.Drawing.Color.White;
            NameTextBox.Location = new Point(189, 49);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(125, 27);
            NameTextBox.TabIndex = 4;
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            // 
            // FindMaxRatingButton
            // 
            FindMaxRatingButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            FindMaxRatingButton.Location = new Point(189, 356);
            FindMaxRatingButton.Name = "FindMaxRatingButton";
            FindMaxRatingButton.Size = new Size(132, 29);
            FindMaxRatingButton.TabIndex = 3;
            FindMaxRatingButton.Text = "Find";
            FindMaxRatingButton.UseVisualStyleBackColor = true;
            FindMaxRatingButton.Click += FindMaxRatingButton_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(189, 154);
            label9.Name = "label9";
            label9.Size = new Size(40, 20);
            label9.TabIndex = 2;
            label9.Text = "Year:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(189, 92);
            label10.Name = "label10";
            label10.Size = new Size(70, 20);
            label10.TabIndex = 1;
            label10.Text = "Duration:";
            // 
            // FilmsListBox
            // 
            FilmsListBox.FormattingEnabled = true;
            FilmsListBox.Location = new Point(6, 26);
            FilmsListBox.Name = "FilmsListBox";
            FilmsListBox.Size = new Size(172, 364);
            FilmsListBox.TabIndex = 0;
            FilmsListBox.SelectedIndexChanged += FilmsListBox_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(184, 26);
            label11.Name = "label11";
            label11.Size = new Size(52, 20);
            label11.TabIndex = 0;
            label11.Text = "Name:";
            // 
            // FilmsPropertiesControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(FilmGgroupBox);
            Name = "FilmsPropertiesControl";
            Size = new Size(363, 410);
            FilmGgroupBox.ResumeLayout(false);
            FilmGgroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox FilmGgroupBox;
        private TextBox RatingTextBox;
        private Label label13;
        private TextBox GenreTextBox;
        private Label label12;
        private TextBox YearTextBox;
        private TextBox DurationTextBox;
        private TextBox NameTextBox;
        private Button FindMaxRatingButton;
        private Label label9;
        private Label label10;
        private ListBox FilmsListBox;
        private Label label11;
    }
}
