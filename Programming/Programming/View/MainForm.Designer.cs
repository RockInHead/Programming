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
            filmsPropertiesControl1 = new View.Panels.FilmsPropertiesControl();
            rectanglesPropertiesControl1 = new View.Panels.RectanglesPropertiesControl();
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
            tabControl1 = new TabControl();
            tabPage3 = new TabPage();
            rectanglesCollisionControl1 = new View.Panels.RectanglesCollisionControl();
            enumerationsControl1 = new View.Panels.EnumerationsControl();
            tabPage2.SuspendLayout();
            tabPage1.SuspendLayout();
            GroupBoxSeasonHandle.SuspendLayout();
            WeekdayParsingGroupBox.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(filmsPropertiesControl1);
            tabPage2.Controls.Add(rectanglesPropertiesControl1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1024, 582);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Сlasses";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // filmsPropertiesControl1
            // 
            filmsPropertiesControl1.Location = new Point(562, 3);
            filmsPropertiesControl1.Name = "filmsPropertiesControl1";
            filmsPropertiesControl1.Size = new Size(368, 416);
            filmsPropertiesControl1.TabIndex = 4;
            // 
            // rectanglesPropertiesControl1
            // 
            rectanglesPropertiesControl1.Location = new Point(0, 6);
            rectanglesPropertiesControl1.Name = "rectanglesPropertiesControl1";
            rectanglesPropertiesControl1.Size = new Size(560, 402);
            rectanglesPropertiesControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(enumerationsControl1);
            tabPage1.Controls.Add(GroupBoxSeasonHandle);
            tabPage1.Controls.Add(WeekdayParsingGroupBox);
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
            // enumerationsControl1
            // 
            enumerationsControl1.Location = new Point(-4, 0);
            enumerationsControl1.Name = "enumerationsControl1";
            enumerationsControl1.Size = new Size(853, 342);
            enumerationsControl1.TabIndex = 6;
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
            tabPage1.ResumeLayout(false);
            GroupBoxSeasonHandle.ResumeLayout(false);
            GroupBoxSeasonHandle.PerformLayout();
            WeekdayParsingGroupBox.ResumeLayout(false);
            WeekdayParsingGroupBox.PerformLayout();
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
        private TabControl tabControl1;
        private TabPage tabPage3;
        private View.Panels.RectanglesCollisionControl rectanglesCollisionControl1;
        private View.Panels.RectanglesPropertiesControl rectanglesPropertiesControl1;
        private View.Panels.FilmsPropertiesControl filmsPropertiesControl1;
        private View.Panels.EnumerationsControl enumerationsControl1;
    }
}
