namespace Programming.View.Panels
{
    partial class RectanglesPropertiesControl
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
            RectanglesGroupBox = new GroupBox();
            label17 = new Label();
            RectangleIdTextBox = new TextBox();
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
            RectanglesGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // RectanglesGroupBox
            // 
            RectanglesGroupBox.Controls.Add(label17);
            RectanglesGroupBox.Controls.Add(RectangleIdTextBox);
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
            RectanglesGroupBox.Location = new Point(3, 3);
            RectanglesGroupBox.Name = "RectanglesGroupBox";
            RectanglesGroupBox.Size = new Size(530, 326);
            RectanglesGroupBox.TabIndex = 2;
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
            // RectanglesPropertiesControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(RectanglesGroupBox);
            Name = "RectanglesPropertiesControl";
            Size = new Size(537, 333);
            RectanglesGroupBox.ResumeLayout(false);
            RectanglesGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox RectanglesGroupBox;
        private Label label17;
        private TextBox RectangleIdTextBox;
        private TextBox YCoordinateTextBox;
        private TextBox XCoordinateTextBox;
        private Label label15;
        private Label label14;
        private TextBox ColorTextBox;
        private TextBox WidthTextBox;
        private TextBox LengthTextBox;
        private Button FindMaxWidthButton;
        private Label label8;
        private Label label7;
        private ListBox RectanglesListBox;
        private Label label6;
    }
}
