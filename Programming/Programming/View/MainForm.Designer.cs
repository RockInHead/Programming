namespace Programming
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabPage2 = new TabPage();
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
            RectanglesGroupBox = new GroupBox();
            ColorTextBox = new TextBox();
            WidthTextBox = new TextBox();
            LengthTextBox = new TextBox();
            FindMaxWidthButton = new Button();
            label8 = new Label();
            label7 = new Label();
            RectanglesListBox = new ListBox();
            label6 = new Label();
            tabPage1 = new TabPage();
            GroupBoxSeasonHandle = new GroupBox();
            SeasonComboBox = new ComboBox();
            SeasonButton = new Button();
            label5 = new Label();
            WeekdayParsingGroupBox = new GroupBox();
            ParsingTextBox = new TextBox();
            ParsedValueLabel = new Label();
            label1 = new Label();
            ParseButton = new Button();
            EnumerationsGroupBox = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            EnumsListBox = new ListBox();
            IntTextBox = new TextBox();
            ValuesListBox = new ListBox();
            tabControl1 = new TabControl();
            tabPage2.SuspendLayout();
            FilmGgroupBox.SuspendLayout();
            RectanglesGroupBox.SuspendLayout();
            tabPage1.SuspendLayout();
            GroupBoxSeasonHandle.SuspendLayout();
            WeekdayParsingGroupBox.SuspendLayout();
            EnumerationsGroupBox.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(FilmGgroupBox);
            tabPage2.Controls.Add(RectanglesGroupBox);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(865, 567);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Сlasses";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
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
            FilmGgroupBox.Location = new Point(402, 6);
            FilmGgroupBox.Name = "FilmGgroupBox";
            FilmGgroupBox.Size = new Size(381, 409);
            FilmGgroupBox.TabIndex = 2;
            FilmGgroupBox.TabStop = false;
            FilmGgroupBox.Text = "Films";
            // 
            // RatingTextBox
            // 
            RatingTextBox.Location = new Point(191, 306);
            RatingTextBox.Name = "RatingTextBox";
            RatingTextBox.Size = new Size(125, 27);
            RatingTextBox.TabIndex = 10;
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
            YearTextBox.Location = new Point(189, 183);
            YearTextBox.Name = "YearTextBox";
            YearTextBox.Size = new Size(125, 27);
            YearTextBox.TabIndex = 6;
            // 
            // DurationTextBox
            // 
            DurationTextBox.Location = new Point(189, 115);
            DurationTextBox.Name = "DurationTextBox";
            DurationTextBox.Size = new Size(125, 27);
            DurationTextBox.TabIndex = 5;
            // 
            // NameTextBox
            // 
            NameTextBox.BackColor = System.Drawing.Color.White;
            NameTextBox.Location = new Point(189, 49);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(125, 27);
            NameTextBox.TabIndex = 4;
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
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(189, 158);
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
            // RectanglesGroupBox
            // 
            RectanglesGroupBox.Controls.Add(ColorTextBox);
            RectanglesGroupBox.Controls.Add(WidthTextBox);
            RectanglesGroupBox.Controls.Add(LengthTextBox);
            RectanglesGroupBox.Controls.Add(FindMaxWidthButton);
            RectanglesGroupBox.Controls.Add(label8);
            RectanglesGroupBox.Controls.Add(label7);
            RectanglesGroupBox.Controls.Add(RectanglesListBox);
            RectanglesGroupBox.Controls.Add(label6);
            RectanglesGroupBox.Location = new Point(8, 6);
            RectanglesGroupBox.Name = "RectanglesGroupBox";
            RectanglesGroupBox.Size = new Size(367, 296);
            RectanglesGroupBox.TabIndex = 1;
            RectanglesGroupBox.TabStop = false;
            RectanglesGroupBox.Text = "Rectangles";
            RectanglesGroupBox.Enter += RectanglesGroupBox_Enter;
            // 
            // ColorTextBox
            // 
            ColorTextBox.Location = new Point(189, 183);
            ColorTextBox.Name = "ColorTextBox";
            ColorTextBox.Size = new Size(125, 27);
            ColorTextBox.TabIndex = 6;
            ColorTextBox.TextChanged += ColorTextBox_TextChanged;
            // 
            // WidthTextBox
            // 
            WidthTextBox.Location = new Point(189, 115);
            WidthTextBox.Name = "WidthTextBox";
            WidthTextBox.Size = new Size(125, 27);
            WidthTextBox.TabIndex = 5;
            WidthTextBox.TextChanged += WidthTextBox_TextChanged;
            // 
            // LengthTextBox
            // 
            LengthTextBox.BackColor = System.Drawing.Color.White;
            LengthTextBox.Location = new Point(189, 49);
            LengthTextBox.Name = "LengthTextBox";
            LengthTextBox.Size = new Size(125, 27);
            LengthTextBox.TabIndex = 4;
            LengthTextBox.TextChanged += LengthTextBox_TextChanged;
            // 
            // FindMaxWidthButton
            // 
            FindMaxWidthButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            FindMaxWidthButton.Location = new Point(189, 241);
            FindMaxWidthButton.Name = "FindMaxWidthButton";
            FindMaxWidthButton.Size = new Size(132, 29);
            FindMaxWidthButton.TabIndex = 3;
            FindMaxWidthButton.Text = "Find";
            FindMaxWidthButton.UseVisualStyleBackColor = true;
            FindMaxWidthButton.Click += button1_Click_1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(189, 158);
            label8.Name = "label8";
            label8.Size = new Size(48, 20);
            label8.TabIndex = 2;
            label8.Text = "Color:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(189, 92);
            label7.Name = "label7";
            label7.Size = new Size(52, 20);
            label7.TabIndex = 1;
            label7.Text = "Width:";
            // 
            // RectanglesListBox
            // 
            RectanglesListBox.FormattingEnabled = true;
            RectanglesListBox.Location = new Point(6, 26);
            RectanglesListBox.Name = "RectanglesListBox";
            RectanglesListBox.Size = new Size(172, 244);
            RectanglesListBox.TabIndex = 0;
            RectanglesListBox.SelectedIndexChanged += RectanglesListBox_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(184, 26);
            label6.Name = "label6";
            label6.Size = new Size(57, 20);
            label6.TabIndex = 0;
            label6.Text = "Lenght:";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(GroupBoxSeasonHandle);
            tabPage1.Controls.Add(WeekdayParsingGroupBox);
            tabPage1.Controls.Add(EnumerationsGroupBox);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(865, 567);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Enums";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // GroupBoxSeasonHandle
            // 
            GroupBoxSeasonHandle.Controls.Add(SeasonComboBox);
            GroupBoxSeasonHandle.Controls.Add(SeasonButton);
            GroupBoxSeasonHandle.Controls.Add(label5);
            GroupBoxSeasonHandle.Location = new Point(487, 348);
            GroupBoxSeasonHandle.Name = "GroupBoxSeasonHandle";
            GroupBoxSeasonHandle.Size = new Size(362, 180);
            GroupBoxSeasonHandle.TabIndex = 5;
            GroupBoxSeasonHandle.TabStop = false;
            GroupBoxSeasonHandle.Text = "Season Handle";
            GroupBoxSeasonHandle.Enter += groupBox1_Enter;
            // 
            // SeasonComboBox
            // 
            SeasonComboBox.FormattingEnabled = true;
            SeasonComboBox.Location = new Point(6, 57);
            SeasonComboBox.Name = "SeasonComboBox";
            SeasonComboBox.Size = new Size(222, 28);
            SeasonComboBox.TabIndex = 2;
            SeasonComboBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // SeasonButton
            // 
            SeasonButton.Location = new Point(240, 55);
            SeasonButton.Name = "SeasonButton";
            SeasonButton.Size = new Size(107, 29);
            SeasonButton.TabIndex = 1;
            SeasonButton.Text = "Go!";
            SeasonButton.UseVisualStyleBackColor = true;
            SeasonButton.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 34);
            label5.Name = "label5";
            label5.Size = new Size(114, 20);
            label5.TabIndex = 0;
            label5.Text = "Choose season: ";
            label5.Click += label5_Click;
            // 
            // WeekdayParsingGroupBox
            // 
            WeekdayParsingGroupBox.Controls.Add(ParsingTextBox);
            WeekdayParsingGroupBox.Controls.Add(ParsedValueLabel);
            WeekdayParsingGroupBox.Controls.Add(label1);
            WeekdayParsingGroupBox.Controls.Add(ParseButton);
            WeekdayParsingGroupBox.Location = new Point(8, 348);
            WeekdayParsingGroupBox.Name = "WeekdayParsingGroupBox";
            WeekdayParsingGroupBox.Size = new Size(473, 183);
            WeekdayParsingGroupBox.TabIndex = 4;
            WeekdayParsingGroupBox.TabStop = false;
            WeekdayParsingGroupBox.Text = "Weekday Parsing";
            // 
            // ParsingTextBox
            // 
            ParsingTextBox.Location = new Point(6, 57);
            ParsingTextBox.Name = "ParsingTextBox";
            ParsingTextBox.Size = new Size(275, 27);
            ParsingTextBox.TabIndex = 3;
            // 
            // ParsedValueLabel
            // 
            ParsedValueLabel.AutoSize = true;
            ParsedValueLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ParsedValueLabel.Location = new Point(6, 101);
            ParsedValueLabel.Name = "ParsedValueLabel";
            ParsedValueLabel.Size = new Size(0, 28);
            ParsedValueLabel.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 34);
            label1.Name = "label1";
            label1.Size = new Size(158, 20);
            label1.TabIndex = 1;
            label1.Text = "Type value for parsing:";
            // 
            // ParseButton
            // 
            ParseButton.Location = new Point(305, 55);
            ParseButton.Name = "ParseButton";
            ParseButton.Size = new Size(118, 29);
            ParseButton.TabIndex = 0;
            ParseButton.Text = "Parse";
            ParseButton.UseVisualStyleBackColor = true;
            ParseButton.Click += ParseButton_Click;
            // 
            // EnumerationsGroupBox
            // 
            EnumerationsGroupBox.Controls.Add(label4);
            EnumerationsGroupBox.Controls.Add(label3);
            EnumerationsGroupBox.Controls.Add(label2);
            EnumerationsGroupBox.Controls.Add(EnumsListBox);
            EnumerationsGroupBox.Controls.Add(IntTextBox);
            EnumerationsGroupBox.Controls.Add(ValuesListBox);
            EnumerationsGroupBox.Location = new Point(8, 6);
            EnumerationsGroupBox.Name = "EnumerationsGroupBox";
            EnumerationsGroupBox.Size = new Size(841, 336);
            EnumerationsGroupBox.TabIndex = 3;
            EnumerationsGroupBox.TabStop = false;
            EnumerationsGroupBox.Text = "Enumerations";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(507, 20);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 5;
            label4.Text = "Int value:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(265, 20);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 4;
            label3.Text = "Choose value:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 20);
            label2.Name = "label2";
            label2.Size = new Size(136, 20);
            label2.TabIndex = 3;
            label2.Text = "Choose enumation:";
            // 
            // EnumsListBox
            // 
            EnumsListBox.FormattingEnabled = true;
            EnumsListBox.Items.AddRange(new object[] { "Color", "EducationForm", "Genre", "Manufactures", "Season", "Weekday" });
            EnumsListBox.Location = new Point(16, 46);
            EnumsListBox.Name = "EnumsListBox";
            EnumsListBox.Size = new Size(185, 284);
            EnumsListBox.TabIndex = 0;
            EnumsListBox.SelectedIndexChanged += EnumsListBox_SelectedIndexChanged;
            // 
            // IntTextBox
            // 
            IntTextBox.Location = new Point(507, 46);
            IntTextBox.Name = "IntTextBox";
            IntTextBox.ReadOnly = true;
            IntTextBox.Size = new Size(163, 27);
            IntTextBox.TabIndex = 2;
            IntTextBox.TextChanged += textBox1_TextChanged;
            // 
            // ValuesListBox
            // 
            ValuesListBox.FormattingEnabled = true;
            ValuesListBox.Location = new Point(265, 46);
            ValuesListBox.Name = "ValuesListBox";
            ValuesListBox.Size = new Size(208, 284);
            ValuesListBox.TabIndex = 1;
            ValuesListBox.SelectedIndexChanged += ValuesListBox_SelectedIndexChanged;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(873, 600);
            tabControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 600);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "Programming Demo";
            tabPage2.ResumeLayout(false);
            FilmGgroupBox.ResumeLayout(false);
            FilmGgroupBox.PerformLayout();
            RectanglesGroupBox.ResumeLayout(false);
            RectanglesGroupBox.PerformLayout();
            tabPage1.ResumeLayout(false);
            GroupBoxSeasonHandle.ResumeLayout(false);
            GroupBoxSeasonHandle.PerformLayout();
            WeekdayParsingGroupBox.ResumeLayout(false);
            WeekdayParsingGroupBox.PerformLayout();
            EnumerationsGroupBox.ResumeLayout(false);
            EnumerationsGroupBox.PerformLayout();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPage2;
        private TabPage tabPage1;
        private GroupBox GroupBoxSeasonHandle;
        private ComboBox SeasonComboBox;
        private Button SeasonButton;
        private Label label5;
        private GroupBox WeekdayParsingGroupBox;
        private TextBox ParsingTextBox;
        private Label ParsedValueLabel;
        private Label label1;
        private Button ParseButton;
        private GroupBox EnumerationsGroupBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private ListBox EnumsListBox;
        private TextBox IntTextBox;
        private ListBox ValuesListBox;
        private TabControl tabControl1;
        private Label label6;
        private GroupBox RectanglesGroupBox;
        private Label label8;
        private Label label7;
        private ListBox RectanglesListBox;
        private TextBox WidthTextBox;
        private TextBox LengthTextBox;
        private Button FindMaxWidthButton;
        private TextBox ColorTextBox;
        private GroupBox FilmGgroupBox;
        private TextBox YearTextBox;
        private TextBox DurationTextBox;
        private TextBox NameTextBox;
        private Button FindMaxRatingButton;
        private Label label9;
        private Label label10;
        private ListBox FilmsListBox;
        private Label label11;
        private TextBox RatingTextBox;
        private Label label13;
        private TextBox GenreTextBox;
        private Label label12;
    }
}
