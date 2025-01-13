namespace OOP.View
{
    partial class AddressControl
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            PostIndexTextBox = new TextBox();
            CountryTextBox = new TextBox();
            label3 = new Label();
            CityTextBox = new TextBox();
            label4 = new Label();
            StreetTextBox = new TextBox();
            label5 = new Label();
            BuildingTextBox = new TextBox();
            label6 = new Label();
            ApartmentTextBox = new TextBox();
            label7 = new Label();
            PostIndexToolTip = new ToolTip(components);
            CityToolTip = new ToolTip(components);
            CountryToolTip = new ToolTip(components);
            StreetToolTip = new ToolTip(components);
            BuildingToolTip = new ToolTip(components);
            ApartmentToolTip = new ToolTip(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(193, 31);
            label1.TabIndex = 0;
            label1.Text = "Delivery Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(0, 54);
            label2.Name = "label2";
            label2.Size = new Size(105, 28);
            label2.TabIndex = 1;
            label2.Text = "Post Index:";
            // 
            // PostIndexTextBox
            // 
            PostIndexTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PostIndexTextBox.Location = new Point(114, 54);
            PostIndexTextBox.MaxLength = 6;
            PostIndexTextBox.Name = "PostIndexTextBox";
            PostIndexTextBox.Size = new Size(180, 34);
            PostIndexTextBox.TabIndex = 2;
            PostIndexTextBox.TextChanged += PostIndexTextBox_TextChanged;
            // 
            // CountryTextBox
            // 
            CountryTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CountryTextBox.Location = new Point(114, 115);
            CountryTextBox.MaxLength = 50;
            CountryTextBox.Name = "CountryTextBox";
            CountryTextBox.Size = new Size(278, 34);
            CountryTextBox.TabIndex = 4;
            CountryTextBox.TextChanged += CountryTextBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(0, 115);
            label3.Name = "label3";
            label3.Size = new Size(86, 28);
            label3.TabIndex = 3;
            label3.Text = "Country:";
            // 
            // CityTextBox
            // 
            CityTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CityTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CityTextBox.Location = new Point(445, 115);
            CityTextBox.MaxLength = 50;
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(189, 34);
            CityTextBox.TabIndex = 6;
            CityTextBox.TextChanged += CityTextBox_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(398, 115);
            label4.Name = "label4";
            label4.Size = new Size(50, 28);
            label4.TabIndex = 5;
            label4.Text = "City:";
            // 
            // StreetTextBox
            // 
            StreetTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            StreetTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            StreetTextBox.Location = new Point(114, 173);
            StreetTextBox.MaxLength = 100;
            StreetTextBox.Name = "StreetTextBox";
            StreetTextBox.Size = new Size(520, 34);
            StreetTextBox.TabIndex = 8;
            StreetTextBox.TextChanged += StreetTextBox_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(3, 173);
            label5.Name = "label5";
            label5.Size = new Size(67, 28);
            label5.TabIndex = 7;
            label5.Text = "Street:";
            // 
            // BuildingTextBox
            // 
            BuildingTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BuildingTextBox.Location = new Point(117, 237);
            BuildingTextBox.MaxLength = 10;
            BuildingTextBox.Name = "BuildingTextBox";
            BuildingTextBox.Size = new Size(122, 34);
            BuildingTextBox.TabIndex = 10;
            BuildingTextBox.TextChanged += BuildingTextBox_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(3, 237);
            label6.Name = "label6";
            label6.Size = new Size(88, 28);
            label6.TabIndex = 9;
            label6.Text = "Building:";
            // 
            // ApartmentTextBox
            // 
            ApartmentTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ApartmentTextBox.Location = new Point(396, 237);
            ApartmentTextBox.MaxLength = 10;
            ApartmentTextBox.Name = "ApartmentTextBox";
            ApartmentTextBox.Size = new Size(122, 34);
            ApartmentTextBox.TabIndex = 12;
            ApartmentTextBox.TextChanged += ApartmentTextBox_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.Location = new Point(280, 237);
            label7.Name = "label7";
            label7.Size = new Size(110, 28);
            label7.TabIndex = 11;
            label7.Text = "Apartment:";
            // 
            // PostIndexToolTip
            // 
            PostIndexToolTip.BackColor = SystemColors.ButtonHighlight;
            PostIndexToolTip.ForeColor = SystemColors.ActiveCaptionText;
            // 
            // CityToolTip
            // 
            CityToolTip.BackColor = SystemColors.ButtonHighlight;
            CityToolTip.ForeColor = SystemColors.ActiveCaptionText;
            // 
            // AddressControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ApartmentTextBox);
            Controls.Add(label7);
            Controls.Add(BuildingTextBox);
            Controls.Add(label6);
            Controls.Add(StreetTextBox);
            Controls.Add(label5);
            Controls.Add(CityTextBox);
            Controls.Add(label4);
            Controls.Add(CountryTextBox);
            Controls.Add(label3);
            Controls.Add(PostIndexTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddressControl";
            Size = new Size(637, 283);
          
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox PostIndexTextBox;
        private TextBox CountryTextBox;
        private Label label3;
        private TextBox CityTextBox;
        private Label label4;
        private TextBox StreetTextBox;
        private Label label5;
        private TextBox BuildingTextBox;
        private Label label6;
        private TextBox ApartmentTextBox;
        private Label label7;
        private ToolTip PostIndexToolTip;
        private ToolTip CityToolTip;
        private ToolTip CountryToolTip;
        private ToolTip StreetToolTip;
        private ToolTip BuildingToolTip;
        private ToolTip ApartmentToolTip;
    }
}
