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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            IntTextBox = new TextBox();
            ValuesListBox = new ListBox();
            EnumsListBox = new ListBox();
            tabPage2 = new TabPage();
            EnumerationsGroupBox = new GroupBox();
            WeekdayParsingGroupBox = new GroupBox();
            ParseButton = new Button();
            label1 = new Label();
            ParsedValueLabel = new Label();
            textBox1 = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            WeekdayParsingGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(860, 600);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(WeekdayParsingGroupBox);
            tabPage1.Controls.Add(IntTextBox);
            tabPage1.Controls.Add(ValuesListBox);
            tabPage1.Controls.Add(EnumsListBox);
            tabPage1.Controls.Add(EnumerationsGroupBox);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(852, 567);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Enums";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // IntTextBox
            // 
            IntTextBox.Location = new Point(548, 29);
            IntTextBox.Name = "IntTextBox";
            IntTextBox.Size = new Size(163, 27);
            IntTextBox.TabIndex = 2;
            IntTextBox.TextChanged += textBox1_TextChanged;
            // 
            // ValuesListBox
            // 
            ValuesListBox.FormattingEnabled = true;
            ValuesListBox.Location = new Point(283, 29);
            ValuesListBox.Name = "ValuesListBox";
            ValuesListBox.Size = new Size(208, 284);
            ValuesListBox.TabIndex = 1;
            ValuesListBox.SelectedIndexChanged += ValuesListBox_SelectedIndexChanged;
            // 
            // EnumsListBox
            // 
            EnumsListBox.FormattingEnabled = true;
            EnumsListBox.Items.AddRange(new object[] { "Color", "EducationForm", "Genre", "Manufactures", "Season", "Weekday" });
            EnumsListBox.Location = new Point(45, 29);
            EnumsListBox.Name = "EnumsListBox";
            EnumsListBox.Size = new Size(185, 284);
            EnumsListBox.TabIndex = 0;
            EnumsListBox.SelectedIndexChanged += EnumsListBox_SelectedIndexChanged;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 417);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // EnumerationsGroupBox
            // 
            EnumerationsGroupBox.Location = new Point(8, 6);
            EnumerationsGroupBox.Name = "EnumerationsGroupBox";
            EnumerationsGroupBox.Size = new Size(781, 336);
            EnumerationsGroupBox.TabIndex = 3;
            EnumerationsGroupBox.TabStop = false;
            EnumerationsGroupBox.Text = "Enumerations";
            // 
            // WeekdayParsingGroupBox
            // 
            WeekdayParsingGroupBox.Controls.Add(textBox1);
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
            // ParseButton
            // 
            ParseButton.Location = new Point(305, 55);
            ParseButton.Name = "ParseButton";
            ParseButton.Size = new Size(118, 29);
            ParseButton.TabIndex = 0;
            ParseButton.Text = "Parse";
            ParseButton.UseVisualStyleBackColor = true;
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
            // ParsedValueLabel
            // 
            ParsedValueLabel.AutoSize = true;
            ParsedValueLabel.Location = new Point(16, 104);
            ParsedValueLabel.Name = "ParsedValueLabel";
            ParsedValueLabel.Size = new Size(50, 20);
            ParsedValueLabel.TabIndex = 2;
            ParsedValueLabel.Text = "label2";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 57);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(275, 27);
            textBox1.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 600);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "Programming Demo";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            WeekdayParsingGroupBox.ResumeLayout(false);
            WeekdayParsingGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private ListBox ValuesListBox;
        private ListBox EnumsListBox;
        private TabPage tabPage2;
        private TextBox IntTextBox;
        private GroupBox EnumerationsGroupBox;
        private GroupBox WeekdayParsingGroupBox;
        private TextBox textBox1;
        private Label ParsedValueLabel;
        private Label label1;
        private Button ParseButton;
    }
}
