namespace Programming.View.Panels
{
    partial class EnumerationsControl
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
            EnumerationsGroupBox = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            EnumsListBox = new ListBox();
            IntTextBox = new TextBox();
            ValuesListBox = new ListBox();
            EnumerationsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // EnumerationsGroupBox
            // 
            EnumerationsGroupBox.Controls.Add(label4);
            EnumerationsGroupBox.Controls.Add(label3);
            EnumerationsGroupBox.Controls.Add(label2);
            EnumerationsGroupBox.Controls.Add(EnumsListBox);
            EnumerationsGroupBox.Controls.Add(IntTextBox);
            EnumerationsGroupBox.Controls.Add(ValuesListBox);
            EnumerationsGroupBox.Location = new Point(3, 3);
            EnumerationsGroupBox.Name = "EnumerationsGroupBox";
            EnumerationsGroupBox.Size = new Size(841, 336);
            EnumerationsGroupBox.TabIndex = 4;
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
            // EnumerationsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(EnumerationsGroupBox);
            Name = "EnumerationsControl";
            Size = new Size(852, 345);
            EnumerationsGroupBox.ResumeLayout(false);
            EnumerationsGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox EnumerationsGroupBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private ListBox EnumsListBox;
        private TextBox IntTextBox;
        private ListBox ValuesListBox;
    }
}
