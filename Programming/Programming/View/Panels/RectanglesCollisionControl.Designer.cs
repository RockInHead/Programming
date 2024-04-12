namespace Programming.View.Panels
{
    partial class RectanglesCollisionControl
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
            SuspendLayout();
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(36, 394);
            label20.Name = "label20";
            label20.Size = new Size(27, 20);
            label20.TabIndex = 39;
            label20.Text = "ID:";
            // 
            // CanvaIdTextBox
            // 
            CanvaIdTextBox.BackColor = System.Drawing.Color.White;
            CanvaIdTextBox.Location = new Point(36, 417);
            CanvaIdTextBox.Name = "CanvaIdTextBox";
            CanvaIdTextBox.ReadOnly = true;
            CanvaIdTextBox.Size = new Size(52, 27);
            CanvaIdTextBox.TabIndex = 38;
            // 
            // CanvaYCoordinateTextBox
            // 
            CanvaYCoordinateTextBox.BackColor = System.Drawing.Color.White;
            CanvaYCoordinateTextBox.Location = new Point(196, 521);
            CanvaYCoordinateTextBox.Name = "CanvaYCoordinateTextBox";
            CanvaYCoordinateTextBox.ReadOnly = true;
            CanvaYCoordinateTextBox.Size = new Size(125, 27);
            CanvaYCoordinateTextBox.TabIndex = 37;
            // 
            // CanvaXCoordinateTextBox
            // 
            CanvaXCoordinateTextBox.BackColor = System.Drawing.Color.White;
            CanvaXCoordinateTextBox.Location = new Point(196, 468);
            CanvaXCoordinateTextBox.Name = "CanvaXCoordinateTextBox";
            CanvaXCoordinateTextBox.ReadOnly = true;
            CanvaXCoordinateTextBox.Size = new Size(125, 27);
            CanvaXCoordinateTextBox.TabIndex = 36;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(197, 498);
            label21.Name = "label21";
            label21.Size = new Size(98, 20);
            label21.TabIndex = 35;
            label21.Text = "Coordinate Y:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(196, 445);
            label22.Name = "label22";
            label22.Size = new Size(99, 20);
            label22.TabIndex = 32;
            label22.Text = "Coordinate X:";
            // 
            // CanvaWidthTextBox
            // 
            CanvaWidthTextBox.Location = new Point(36, 521);
            CanvaWidthTextBox.Name = "CanvaWidthTextBox";
            CanvaWidthTextBox.Size = new Size(125, 27);
            CanvaWidthTextBox.TabIndex = 34;
            // 
            // CanvaLengthTextBox
            // 
            CanvaLengthTextBox.BackColor = System.Drawing.Color.White;
            CanvaLengthTextBox.Location = new Point(36, 468);
            CanvaLengthTextBox.Name = "CanvaLengthTextBox";
            CanvaLengthTextBox.Size = new Size(125, 27);
            CanvaLengthTextBox.TabIndex = 33;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(36, 498);
            label23.Name = "label23";
            label23.Size = new Size(52, 20);
            label23.TabIndex = 31;
            label23.Text = "Width:";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(36, 447);
            label24.Name = "label24";
            label24.Size = new Size(57, 20);
            label24.TabIndex = 30;
            label24.Text = "Lenght:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label19.Location = new Point(79, 368);
            label19.Name = "label19";
            label19.Size = new Size(197, 28);
            label19.TabIndex = 29;
            label19.Text = "Selected Rectangle:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label18.Location = new Point(24, 31);
            label18.Name = "label18";
            label18.Size = new Size(101, 23);
            label18.TabIndex = 28;
            label18.Text = "Rectangles:";
            // 
            // CanvaRectanglesListBox
            // 
            CanvaRectanglesListBox.FormattingEnabled = true;
            CanvaRectanglesListBox.Location = new Point(22, 57);
            CanvaRectanglesListBox.Name = "CanvaRectanglesListBox";
            CanvaRectanglesListBox.Size = new Size(302, 244);
            CanvaRectanglesListBox.TabIndex = 27;
            // 
            // RemoveRectangleButton
            // 
            RemoveRectangleButton.BackgroundImage = Properties.Resources._8664938_trash_can_delete_remove_icon;
            RemoveRectangleButton.BackgroundImageLayout = ImageLayout.Zoom;
            RemoveRectangleButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            RemoveRectangleButton.FlatStyle = FlatStyle.Flat;
            RemoveRectangleButton.Location = new Point(171, 306);
            RemoveRectangleButton.Name = "RemoveRectangleButton";
            RemoveRectangleButton.Size = new Size(66, 58);
            RemoveRectangleButton.TabIndex = 26;
            RemoveRectangleButton.UseVisualStyleBackColor = true;
            // 
            // AddRectangleButton
            // 
            AddRectangleButton.BackgroundImage = Properties.Resources._4781840___add_circle_create_expand_icon;
            AddRectangleButton.BackgroundImageLayout = ImageLayout.Zoom;
            AddRectangleButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            AddRectangleButton.FlatStyle = FlatStyle.Flat;
            AddRectangleButton.Location = new Point(68, 305);
            AddRectangleButton.Name = "AddRectangleButton";
            AddRectangleButton.Size = new Size(70, 60);
            AddRectangleButton.TabIndex = 25;
            AddRectangleButton.UseVisualStyleBackColor = true;
            // 
            // RectanglesPanel
            // 
            RectanglesPanel.BorderStyle = BorderStyle.FixedSingle;
            RectanglesPanel.Location = new Point(398, 31);
            RectanglesPanel.Name = "RectanglesPanel";
            RectanglesPanel.Size = new Size(606, 537);
            RectanglesPanel.TabIndex = 24;
            // 
            // RectanglesCollisionControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label20);
            Controls.Add(CanvaIdTextBox);
            Controls.Add(CanvaYCoordinateTextBox);
            Controls.Add(CanvaXCoordinateTextBox);
            Controls.Add(label21);
            Controls.Add(label22);
            Controls.Add(CanvaWidthTextBox);
            Controls.Add(CanvaLengthTextBox);
            Controls.Add(label23);
            Controls.Add(label24);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(CanvaRectanglesListBox);
            Controls.Add(RemoveRectangleButton);
            Controls.Add(AddRectangleButton);
            Controls.Add(RectanglesPanel);
            Name = "RectanglesCollisionControl";
            Size = new Size(1087, 627);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private Label label19;
        private Label label18;
        private ListBox CanvaRectanglesListBox;
        private Button RemoveRectangleButton;
        private Button AddRectangleButton;
        private Panel RectanglesPanel;
    }
}
