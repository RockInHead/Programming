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
            tabPage1.SuspendLayout();
            GroupBoxSeasonHandle.SuspendLayout();
            WeekdayParsingGroupBox.SuspendLayout();
            EnumerationsGroupBox.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(865, 567);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
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
    }
}
