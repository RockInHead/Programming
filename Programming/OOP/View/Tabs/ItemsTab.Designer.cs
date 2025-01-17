namespace OOP.View.Tabs
{
    partial class ItemsTab
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
            tableLayoutPanel1 = new TableLayoutPanel();
            ItemsGroupBox = new GroupBox();
            SortByComboBox = new ComboBox();
            label7 = new Label();
            FindSubstringTextBox = new TextBox();
            label13 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            AddButton = new Button();
            RemoveButton = new Button();
            ItemsListBox = new ListBox();
            SelectedItemGroupBox = new GroupBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            CancelButton = new Button();
            OkButton = new Button();
            ErrorLabel = new Label();
            CategoryComboBox = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label5 = new Label();
            label1 = new Label();
            DescriptionRichTextBox = new RichTextBox();
            NameRichTextBox = new RichTextBox();
            CostTextBox = new TextBox();
            IdTextBox = new TextBox();
            NameToolTip = new ToolTip(components);
            DesriptionToolTip = new ToolTip(components);
            tableLayoutPanel3 = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            button3 = new Button();
            button4 = new Button();
            tableLayoutPanel1.SuspendLayout();
            ItemsGroupBox.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SelectedItemGroupBox.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.9556046F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60.0443954F));
            tableLayoutPanel1.Controls.Add(ItemsGroupBox, 0, 0);
            tableLayoutPanel1.Controls.Add(SelectedItemGroupBox, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(945, 678);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // ItemsGroupBox
            // 
            ItemsGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemsGroupBox.Controls.Add(SortByComboBox);
            ItemsGroupBox.Controls.Add(label7);
            ItemsGroupBox.Controls.Add(FindSubstringTextBox);
            ItemsGroupBox.Controls.Add(label13);
            ItemsGroupBox.Controls.Add(tableLayoutPanel2);
            ItemsGroupBox.Controls.Add(ItemsListBox);
            ItemsGroupBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ItemsGroupBox.Location = new Point(3, 3);
            ItemsGroupBox.Name = "ItemsGroupBox";
            ItemsGroupBox.Size = new Size(371, 672);
            ItemsGroupBox.TabIndex = 0;
            ItemsGroupBox.TabStop = false;
            ItemsGroupBox.Text = "Items";
            // 
            // SortByComboBox
            // 
            SortByComboBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SortByComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SortByComboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SortByComboBox.FormattingEnabled = true;
            SortByComboBox.Items.AddRange(new object[] { "Name (A-Z/A-Я)", "Name (Z-A/Я-А)", "Cost (Ascending)", "Cost (Descending)" });
            SortByComboBox.Location = new Point(107, 541);
            SortByComboBox.Name = "SortByComboBox";
            SortByComboBox.Size = new Size(241, 36);
            SortByComboBox.TabIndex = 15;
            SortByComboBox.SelectedIndexChanged += SortByComboBox_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.Location = new Point(6, 549);
            label7.Name = "label7";
            label7.Size = new Size(95, 28);
            label7.TabIndex = 15;
            label7.Text = "OrderBy:";
            // 
            // FindSubstringTextBox
            // 
            FindSubstringTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FindSubstringTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FindSubstringTextBox.Location = new Point(73, 23);
            FindSubstringTextBox.Name = "FindSubstringTextBox";
            FindSubstringTextBox.Size = new Size(275, 34);
            FindSubstringTextBox.TabIndex = 15;
            FindSubstringTextBox.TextChanged += FindSubstringTextBox_TextChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label13.Location = new Point(9, 30);
            label13.Name = "label13";
            label13.Size = new Size(57, 28);
            label13.TabIndex = 15;
            label13.Text = "Find:";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(AddButton, 0, 0);
            tableLayoutPanel2.Controls.Add(RemoveButton, 1, 0);
            tableLayoutPanel2.Location = new Point(6, 608);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(342, 47);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AddButton.Location = new Point(3, 3);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(165, 41);
            AddButton.TabIndex = 1;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RemoveButton.Location = new Point(174, 3);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(165, 41);
            RemoveButton.TabIndex = 2;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // ItemsListBox
            // 
            ItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.ItemHeight = 28;
            ItemsListBox.Location = new Point(6, 66);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(342, 452);
            ItemsListBox.TabIndex = 0;
            ItemsListBox.SelectedIndexChanged += ItemsListBox_SelectedIndexChanged;
            // 
            // SelectedItemGroupBox
            // 
            SelectedItemGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SelectedItemGroupBox.Controls.Add(tableLayoutPanel5);
            SelectedItemGroupBox.Controls.Add(ErrorLabel);
            SelectedItemGroupBox.Controls.Add(CategoryComboBox);
            SelectedItemGroupBox.Controls.Add(label4);
            SelectedItemGroupBox.Controls.Add(label3);
            SelectedItemGroupBox.Controls.Add(label2);
            SelectedItemGroupBox.Controls.Add(label5);
            SelectedItemGroupBox.Controls.Add(label1);
            SelectedItemGroupBox.Controls.Add(DescriptionRichTextBox);
            SelectedItemGroupBox.Controls.Add(NameRichTextBox);
            SelectedItemGroupBox.Controls.Add(CostTextBox);
            SelectedItemGroupBox.Controls.Add(IdTextBox);
            SelectedItemGroupBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SelectedItemGroupBox.Location = new Point(380, 3);
            SelectedItemGroupBox.Name = "SelectedItemGroupBox";
            SelectedItemGroupBox.Size = new Size(562, 672);
            SelectedItemGroupBox.TabIndex = 1;
            SelectedItemGroupBox.TabStop = false;
            SelectedItemGroupBox.Text = "Selected Item";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(CancelButton, 1, 0);
            tableLayoutPanel5.Controls.Add(OkButton, 0, 0);
            tableLayoutPanel5.Location = new Point(6, 608);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(329, 47);
            tableLayoutPanel5.TabIndex = 15;
            // 
            // CancelButton
            // 
            CancelButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CancelButton.Location = new Point(167, 3);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(159, 41);
            CancelButton.TabIndex = 2;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // OkButton
            // 
            OkButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OkButton.Location = new Point(3, 3);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(158, 41);
            OkButton.TabIndex = 1;
            OkButton.Text = "Ok";
            OkButton.UseVisualStyleBackColor = true;
            OkButton.Click += OkButton_Click;
            // 
            // ErrorLabel
            // 
            ErrorLabel.AutoSize = true;
            ErrorLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ErrorLabel.ForeColor = Color.Red;
            ErrorLabel.Location = new Point(310, 152);
            ErrorLabel.Name = "ErrorLabel";
            ErrorLabel.Size = new Size(168, 28);
            ErrorLabel.TabIndex = 14;
            ErrorLabel.Text = "Сhoose Category!";
            ErrorLabel.Visible = false;
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CategoryComboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(118, 144);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(151, 36);
            CategoryComboBox.TabIndex = 13;
            CategoryComboBox.SelectedIndexChanged += CategoryComboBox_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(6, 152);
            label4.Name = "label4";
            label4.Size = new Size(103, 28);
            label4.TabIndex = 12;
            label4.Text = "Category:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(6, 350);
            label3.Name = "label3";
            label3.Size = new Size(126, 28);
            label3.TabIndex = 10;
            label3.Text = "Description:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(6, 196);
            label2.Name = "label2";
            label2.Size = new Size(73, 28);
            label2.TabIndex = 9;
            label2.Text = "Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(9, 94);
            label5.Name = "label5";
            label5.Size = new Size(58, 28);
            label5.TabIndex = 8;
            label5.Text = "Cost:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(6, 54);
            label1.Name = "label1";
            label1.Size = new Size(38, 28);
            label1.TabIndex = 4;
            label1.Text = "ID:";
            // 
            // DescriptionRichTextBox
            // 
            DescriptionRichTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DescriptionRichTextBox.Location = new Point(6, 381);
            DescriptionRichTextBox.MaxLength = 1000;
            DescriptionRichTextBox.Name = "DescriptionRichTextBox";
            DescriptionRichTextBox.Size = new Size(525, 221);
            DescriptionRichTextBox.TabIndex = 3;
            DescriptionRichTextBox.Text = "";
            DescriptionRichTextBox.TextChanged += DescriptionRichTextBox_TextChanged;
            DescriptionRichTextBox.MouseMove += DescriptionRichTextBox_MouseMove;
            // 
            // NameRichTextBox
            // 
            NameRichTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NameRichTextBox.Location = new Point(6, 227);
            NameRichTextBox.MaxLength = 200;
            NameRichTextBox.MinimumSize = new Size(525, 120);
            NameRichTextBox.Name = "NameRichTextBox";
            NameRichTextBox.Size = new Size(525, 120);
            NameRichTextBox.TabIndex = 2;
            NameRichTextBox.Text = "";
            NameRichTextBox.TextChanged += NameRichTextBox_TextChanged;
            NameRichTextBox.MouseMove += NameRichTextBox_MouseMove;
            // 
            // CostTextBox
            // 
            CostTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CostTextBox.Location = new Point(73, 88);
            CostTextBox.Name = "CostTextBox";
            CostTextBox.Size = new Size(191, 34);
            CostTextBox.TabIndex = 1;
            CostTextBox.TextChanged += CostTextBox_TextChanged;
            // 
            // IdTextBox
            // 
            IdTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            IdTextBox.Location = new Point(73, 48);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(191, 34);
            IdTextBox.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(button1, 0, 0);
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.Size = new Size(200, 100);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(94, 94);
            button1.TabIndex = 1;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button2.Location = new Point(103, 3);
            button2.Name = "button2";
            button2.Size = new Size(94, 94);
            button2.TabIndex = 2;
            button2.Text = "Remove";
            button2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(button3, 0, 0);
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.Size = new Size(200, 100);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button3.Location = new Point(3, 3);
            button3.Name = "button3";
            button3.Size = new Size(94, 94);
            button3.TabIndex = 1;
            button3.Text = "Add";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button4.Location = new Point(103, 3);
            button4.Name = "button4";
            button4.Size = new Size(94, 94);
            button4.TabIndex = 2;
            button4.Text = "Remove";
            button4.UseVisualStyleBackColor = true;
            // 
            // ItemsTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "ItemsTab";
            Size = new Size(945, 678);
            Load += ItemsTab_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ItemsGroupBox.ResumeLayout(false);
            ItemsGroupBox.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            SelectedItemGroupBox.ResumeLayout(false);
            SelectedItemGroupBox.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox ItemsGroupBox;
        private Button RemoveButton;
        private Button AddButton;
        private ListBox ItemsListBox;
        private GroupBox SelectedItemGroupBox;
        private TextBox CostTextBox;
        private TextBox IdTextBox;
        private Label label1;
        private RichTextBox DescriptionRichTextBox;
        private RichTextBox NameRichTextBox;
        private Label label5;
        private Label label3;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel2;
        private ToolTip NameToolTip;
        private ToolTip DesriptionToolTip;
        private Label label4;
        private ComboBox CategoryComboBox;
        private Label ErrorLabel;
        private TextBox FindSubstringTextBox;
        private Label label13;
        private ComboBox SortByComboBox;
        private Label label7;
        private TableLayoutPanel tableLayoutPanel5;
        private Button CancelButton;
        private Button OkButton;
        private TableLayoutPanel tableLayoutPanel3;
        private Button button1;
        private Button button2;
        private TableLayoutPanel tableLayoutPanel4;
        private Button button3;
        private Button button4;
    }
}
