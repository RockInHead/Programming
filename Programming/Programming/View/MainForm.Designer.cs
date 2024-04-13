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
            tabPage3 = new TabPage();
            rectanglesCollisionControl1 = new View.Panels.RectanglesCollisionControl();
            rectanglesPropertiesControl1 = new View.Panels.RectanglesPropertiesControl();
            tabPage2.SuspendLayout();
            FilmGgroupBox.SuspendLayout();
            tabPage1.SuspendLayout();
            GroupBoxSeasonHandle.SuspendLayout();
            WeekdayParsingGroupBox.SuspendLayout();
            EnumerationsGroupBox.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(rectanglesPropertiesControl1);
            tabPage2.Controls.Add(FilmGgroupBox);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1024, 582);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Сlasses";
            tabPage2.UseVisualStyleBackColor = true;
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
            FilmGgroupBox.Location = new Point(566, 6);
            FilmGgroupBox.Name = "FilmGgroupBox";
            FilmGgroupBox.Size = new Size(381, 402);
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
            YearTextBox.Location = new Point(189, 183);
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
            // tabPage1
            // 
            tabPage1.Controls.Add(GroupBoxSeasonHandle);
            tabPage1.Controls.Add(WeekdayParsingGroupBox);
            tabPage1.Controls.Add(EnumerationsGroupBox);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1024, 582);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Enums";
            tabPage1.UseVisualStyleBackColor = true;
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
            // 
            // SeasonComboBox
            // 
            SeasonComboBox.FormattingEnabled = true;
            SeasonComboBox.Location = new Point(6, 57);
            SeasonComboBox.Name = "SeasonComboBox";
            SeasonComboBox.Size = new Size(222, 28);
            SeasonComboBox.TabIndex = 2;
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
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1032, 615);
            tabControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(rectanglesCollisionControl1);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1024, 582);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Rectangles";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // rectanglesCollisionControl1
            // 
            rectanglesCollisionControl1.Dock = DockStyle.Fill;
            rectanglesCollisionControl1.Location = new Point(3, 3);
            rectanglesCollisionControl1.Name = "rectanglesCollisionControl1";
            rectanglesCollisionControl1.Size = new Size(1018, 576);
            rectanglesCollisionControl1.TabIndex = 0;
            // 
            // rectanglesPropertiesControl1
            // 
            rectanglesPropertiesControl1.Location = new Point(0, 6);
            rectanglesPropertiesControl1.Name = "rectanglesPropertiesControl1";
            rectanglesPropertiesControl1.Size = new Size(560, 402);
            rectanglesPropertiesControl1.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 615);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "Programming Demo";
            tabPage2.ResumeLayout(false);
            FilmGgroupBox.ResumeLayout(false);
            FilmGgroupBox.PerformLayout();
            tabPage1.ResumeLayout(false);
            GroupBoxSeasonHandle.ResumeLayout(false);
            GroupBoxSeasonHandle.PerformLayout();
            WeekdayParsingGroupBox.ResumeLayout(false);
            WeekdayParsingGroupBox.PerformLayout();
            EnumerationsGroupBox.ResumeLayout(false);
            EnumerationsGroupBox.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
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
        private TabPage tabPage3;
        private View.Panels.RectanglesCollisionControl rectanglesCollisionControl1;
        private View.Panels.RectanglesPropertiesControl rectanglesPropertiesControl1;
    }
}
