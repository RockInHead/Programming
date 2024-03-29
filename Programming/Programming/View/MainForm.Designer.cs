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
            label17 = new Label();
            RectangleIdTextBox = new TextBox();
            label16 = new Label();
            YCoordinateTextBox = new TextBox();
            XCoordinateTextBox = new TextBox();
            label15 = new Label();
            label14 = new Label();
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
            tabPage3 = new TabPage();
            label20 = new Label();
            CanvaIdTextBox = new TextBox();
            CanvaYCoordinateTextBox = new TextBox();
            CanvaXCoordinateTextBox = new TextBox();
            label21 = new Label();
            label22 = new Label();
            CanvaWidthTextBox = new TextBox();
            CanvaLengthTextBox = new TextBox();
            label23 = new Label();
            label24 = new Label();
            label19 = new Label();
            label18 = new Label();
            CanvaRectanglesListBox = new ListBox();
            RemoveRectangleButton = new Button();
            AddRectangleButton = new Button();
            RectanglesPanel = new Panel();
            tabPage2.SuspendLayout();
            FilmGgroupBox.SuspendLayout();
            RectanglesGroupBox.SuspendLayout();
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
            tabPage2.Controls.Add(FilmGgroupBox);
            tabPage2.Controls.Add(RectanglesGroupBox);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(996, 567);
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
            FilmGgroupBox.Location = new Point(566, 6);
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
            // RectanglesGroupBox
            // 
            RectanglesGroupBox.Controls.Add(label17);
            RectanglesGroupBox.Controls.Add(RectangleIdTextBox);
            RectanglesGroupBox.Controls.Add(label16);
            RectanglesGroupBox.Controls.Add(YCoordinateTextBox);
            RectanglesGroupBox.Controls.Add(XCoordinateTextBox);
            RectanglesGroupBox.Controls.Add(label15);
            RectanglesGroupBox.Controls.Add(label14);
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
            RectanglesGroupBox.Size = new Size(530, 375);
            RectanglesGroupBox.TabIndex = 1;
            RectanglesGroupBox.TabStop = false;
            RectanglesGroupBox.Text = "Rectangles";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(198, 23);
            label17.Name = "label17";
            label17.Size = new Size(27, 20);
            label17.TabIndex = 13;
            label17.Text = "ID:";
            // 
            // RectangleIdTextBox
            // 
            RectangleIdTextBox.BackColor = System.Drawing.Color.White;
            RectangleIdTextBox.Location = new Point(198, 52);
            RectangleIdTextBox.Name = "RectangleIdTextBox";
            RectangleIdTextBox.ReadOnly = true;
            RectangleIdTextBox.Size = new Size(52, 27);
            RectangleIdTextBox.TabIndex = 11;
            // 
            // label16
            // 
            label16.Location = new Point(0, 0);
            label16.Name = "label16";
            label16.Size = new Size(100, 23);
            label16.TabIndex = 12;
            // 
            // YCoordinateTextBox
            // 
            YCoordinateTextBox.BackColor = System.Drawing.Color.White;
            YCoordinateTextBox.Location = new Point(342, 158);
            YCoordinateTextBox.Name = "YCoordinateTextBox";
            YCoordinateTextBox.ReadOnly = true;
            YCoordinateTextBox.Size = new Size(125, 27);
            YCoordinateTextBox.TabIndex = 9;
            // 
            // XCoordinateTextBox
            // 
            XCoordinateTextBox.BackColor = System.Drawing.Color.White;
            XCoordinateTextBox.Location = new Point(342, 105);
            XCoordinateTextBox.Name = "XCoordinateTextBox";
            XCoordinateTextBox.ReadOnly = true;
            XCoordinateTextBox.Size = new Size(125, 27);
            XCoordinateTextBox.TabIndex = 8;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(342, 135);
            label15.Name = "label15";
            label15.Size = new Size(98, 20);
            label15.TabIndex = 7;
            label15.Text = "Coordinate Y:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(341, 82);
            label14.Name = "label14";
            label14.Size = new Size(99, 20);
            label14.TabIndex = 3;
            label14.Text = "Coordinate X:";
            // 
            // ColorTextBox
            // 
            ColorTextBox.Location = new Point(198, 219);
            ColorTextBox.Name = "ColorTextBox";
            ColorTextBox.Size = new Size(125, 27);
            ColorTextBox.TabIndex = 6;
            ColorTextBox.TextChanged += ColorTextBox_TextChanged;
            // 
            // WidthTextBox
            // 
            WidthTextBox.Location = new Point(198, 158);
            WidthTextBox.Name = "WidthTextBox";
            WidthTextBox.Size = new Size(125, 27);
            WidthTextBox.TabIndex = 5;
            WidthTextBox.TextChanged += WidthTextBox_TextChanged;
            // 
            // LengthTextBox
            // 
            LengthTextBox.BackColor = System.Drawing.Color.White;
            LengthTextBox.Location = new Point(198, 105);
            LengthTextBox.Name = "LengthTextBox";
            LengthTextBox.Size = new Size(125, 27);
            LengthTextBox.TabIndex = 4;
            LengthTextBox.TextChanged += LengthTextBox_TextChanged;
            // 
            // FindMaxWidthButton
            // 
            FindMaxWidthButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            FindMaxWidthButton.Location = new Point(198, 277);
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
            label8.Location = new Point(198, 194);
            label8.Name = "label8";
            label8.Size = new Size(48, 20);
            label8.TabIndex = 2;
            label8.Text = "Color:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(198, 135);
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
            RectanglesListBox.Size = new Size(172, 284);
            RectanglesListBox.TabIndex = 0;
            RectanglesListBox.SelectedIndexChanged += RectanglesListBox_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(198, 82);
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
            tabPage1.Size = new Size(996, 567);
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
            tabControl1.Size = new Size(1004, 600);
            tabControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label20);
            tabPage3.Controls.Add(CanvaIdTextBox);
            tabPage3.Controls.Add(CanvaYCoordinateTextBox);
            tabPage3.Controls.Add(CanvaXCoordinateTextBox);
            tabPage3.Controls.Add(label21);
            tabPage3.Controls.Add(label22);
            tabPage3.Controls.Add(CanvaWidthTextBox);
            tabPage3.Controls.Add(CanvaLengthTextBox);
            tabPage3.Controls.Add(label23);
            tabPage3.Controls.Add(label24);
            tabPage3.Controls.Add(label19);
            tabPage3.Controls.Add(label18);
            tabPage3.Controls.Add(CanvaRectanglesListBox);
            tabPage3.Controls.Add(RemoveRectangleButton);
            tabPage3.Controls.Add(AddRectangleButton);
            tabPage3.Controls.Add(RectanglesPanel);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(996, 567);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Rectangles";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(20, 369);
            label20.Name = "label20";
            label20.Size = new Size(27, 20);
            label20.TabIndex = 23;
            label20.Text = "ID:";
            // 
            // CanvaIdTextBox
            // 
            CanvaIdTextBox.BackColor = System.Drawing.Color.White;
            CanvaIdTextBox.Location = new Point(20, 392);
            CanvaIdTextBox.Name = "CanvaIdTextBox";
            CanvaIdTextBox.ReadOnly = true;
            CanvaIdTextBox.Size = new Size(52, 27);
            CanvaIdTextBox.TabIndex = 22;
            // 
            // CanvaYCoordinateTextBox
            // 
            CanvaYCoordinateTextBox.BackColor = System.Drawing.Color.White;
            CanvaYCoordinateTextBox.Location = new Point(180, 496);
            CanvaYCoordinateTextBox.Name = "CanvaYCoordinateTextBox";
            CanvaYCoordinateTextBox.ReadOnly = true;
            CanvaYCoordinateTextBox.Size = new Size(125, 27);
            CanvaYCoordinateTextBox.TabIndex = 21;
            // 
            // CanvaXCoordinateTextBox
            // 
            CanvaXCoordinateTextBox.BackColor = System.Drawing.Color.White;
            CanvaXCoordinateTextBox.Location = new Point(180, 443);
            CanvaXCoordinateTextBox.Name = "CanvaXCoordinateTextBox";
            CanvaXCoordinateTextBox.ReadOnly = true;
            CanvaXCoordinateTextBox.Size = new Size(125, 27);
            CanvaXCoordinateTextBox.TabIndex = 20;
            CanvaXCoordinateTextBox.TextChanged += CanvaCoordinateXTextBox_TextChanged;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(181, 473);
            label21.Name = "label21";
            label21.Size = new Size(98, 20);
            label21.TabIndex = 19;
            label21.Text = "Coordinate Y:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(180, 420);
            label22.Name = "label22";
            label22.Size = new Size(99, 20);
            label22.TabIndex = 16;
            label22.Text = "Coordinate X:";
            // 
            // CanvaWidthTextBox
            // 
            CanvaWidthTextBox.Location = new Point(20, 496);
            CanvaWidthTextBox.Name = "CanvaWidthTextBox";
            CanvaWidthTextBox.Size = new Size(125, 27);
            CanvaWidthTextBox.TabIndex = 18;
            CanvaWidthTextBox.TextChanged += CanvaWidthTextBox_TextChanged;
            // 
            // CanvaLengthTextBox
            // 
            CanvaLengthTextBox.BackColor = System.Drawing.Color.White;
            CanvaLengthTextBox.Location = new Point(20, 443);
            CanvaLengthTextBox.Name = "CanvaLengthTextBox";
            CanvaLengthTextBox.Size = new Size(125, 27);
            CanvaLengthTextBox.TabIndex = 17;
            CanvaLengthTextBox.TextChanged += CanvaLengthTextBox_TextChanged;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(20, 473);
            label23.Name = "label23";
            label23.Size = new Size(52, 20);
            label23.TabIndex = 15;
            label23.Text = "Width:";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(20, 422);
            label24.Name = "label24";
            label24.Size = new Size(57, 20);
            label24.TabIndex = 14;
            label24.Text = "Lenght:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label19.Location = new Point(63, 343);
            label19.Name = "label19";
            label19.Size = new Size(197, 28);
            label19.TabIndex = 5;
            label19.Text = "Selected Rectangle:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label18.Location = new Point(8, 6);
            label18.Name = "label18";
            label18.Size = new Size(101, 23);
            label18.TabIndex = 4;
            label18.Text = "Rectangles:";
            // 
            // CanvaRectanglesListBox
            // 
            CanvaRectanglesListBox.FormattingEnabled = true;
            CanvaRectanglesListBox.Location = new Point(6, 32);
            CanvaRectanglesListBox.Name = "CanvaRectanglesListBox";
            CanvaRectanglesListBox.Size = new Size(302, 244);
            CanvaRectanglesListBox.TabIndex = 3;
            CanvaRectanglesListBox.SelectedIndexChanged += CanvaRectanglesListBox_SelectedIndexChanged;
            // 
            // RemoveRectangleButton
            // 
            RemoveRectangleButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            RemoveRectangleButton.FlatStyle = FlatStyle.Flat;
            RemoveRectangleButton.Location = new Point(194, 288);
            RemoveRectangleButton.Name = "RemoveRectangleButton";
            RemoveRectangleButton.Size = new Size(116, 42);
            RemoveRectangleButton.TabIndex = 2;
            RemoveRectangleButton.Text = "Убрать ▯";
            RemoveRectangleButton.UseVisualStyleBackColor = true;
            RemoveRectangleButton.Click += RemoveRectangleButton_Click;
            // 
            // AddRectangleButton
            // 
            AddRectangleButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            AddRectangleButton.FlatStyle = FlatStyle.Flat;
            AddRectangleButton.Location = new Point(3, 288);
            AddRectangleButton.Name = "AddRectangleButton";
            AddRectangleButton.Size = new Size(116, 42);
            AddRectangleButton.TabIndex = 1;
            AddRectangleButton.Text = "Добавить ▯";
            AddRectangleButton.UseVisualStyleBackColor = true;
            AddRectangleButton.Click += AddRectangleButton_Click;
            // 
            // RectanglesPanel
            // 
            RectanglesPanel.BorderStyle = BorderStyle.FixedSingle;
            RectanglesPanel.Location = new Point(382, 6);
            RectanglesPanel.Name = "RectanglesPanel";
            RectanglesPanel.Size = new Size(606, 537);
            RectanglesPanel.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1004, 600);
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
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
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
        private Label label14;
        private TextBox YCoordinateTextBox;
        private TextBox XCoordinateTextBox;
        private Label label15;
        private TextBox RectangleIdTextBox;
        private Label label16;
        private Label label17;
        private TabPage tabPage3;
        private Button AddRectangleButton;
        private Panel RectanglesPanel;
        private Label label19;
        private Label label18;
        private ListBox CanvaRectanglesListBox;
        private Button RemoveRectangleButton;
        private Label label20;
        private TextBox CanvaIdTextBox;
        private TextBox CanvaYCoordinateTextBox;
        private TextBox CanvaXCoordinateTextBox;
        private Label label21;
        private Label label22;
        private TextBox CanvaWidthTextBox;
        private TextBox CanvaLengthTextBox;
        private Label label23;
        private Label label24;
    }
}
