namespace OOP.View.Tabs
{
    partial class СustomersTab
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
            Model.Address address1 = new Model.Address();
            CustomersListBox = new ListBox();
            AddCustomerButton = new Button();
            RemoveCustomerButton = new Button();
            CustomersGroupBox = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            SelectedCustomerGroupBox = new GroupBox();
            RemovePercentDiscountButton = new Button();
            AddPercentDiscountButton = new Button();
            CancelButton = new Button();
            OkButton = new Button();
            DiscountsListBox = new ListBox();
            label3 = new Label();
            IsPriorityCheckBox = new CheckBox();
            AddressControl = new AddressControl();
            FullNameTextBox = new TextBox();
            IdTextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            button3 = new Button();
            button4 = new Button();
            CustomersGroupBox.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SelectedCustomerGroupBox.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // CustomersListBox
            // 
            CustomersListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CustomersListBox.FormattingEnabled = true;
            CustomersListBox.ItemHeight = 28;
            CustomersListBox.Location = new Point(0, 36);
            CustomersListBox.MinimumSize = new Size(290, 470);
            CustomersListBox.Name = "CustomersListBox";
            CustomersListBox.Size = new Size(412, 480);
            CustomersListBox.TabIndex = 0;
            CustomersListBox.SelectedIndexChanged += CustomersListBox_SelectedIndexChanged;
            // 
            // AddCustomerButton
            // 
            AddCustomerButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AddCustomerButton.Location = new Point(3, 3);
            AddCustomerButton.Name = "AddCustomerButton";
            AddCustomerButton.Size = new Size(195, 39);
            AddCustomerButton.TabIndex = 1;
            AddCustomerButton.Text = "Add";
            AddCustomerButton.UseVisualStyleBackColor = true;
            AddCustomerButton.Click += AddCustomerButton_Click;
            // 
            // RemoveCustomerButton
            // 
            RemoveCustomerButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RemoveCustomerButton.Location = new Point(204, 3);
            RemoveCustomerButton.Name = "RemoveCustomerButton";
            RemoveCustomerButton.Size = new Size(199, 39);
            RemoveCustomerButton.TabIndex = 2;
            RemoveCustomerButton.Text = "Remove";
            RemoveCustomerButton.UseVisualStyleBackColor = true;
            RemoveCustomerButton.Click += RemoveCustomerButton_Click;
            // 
            // CustomersGroupBox
            // 
            CustomersGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CustomersGroupBox.Controls.Add(tableLayoutPanel2);
            CustomersGroupBox.Controls.Add(panel1);
            CustomersGroupBox.Controls.Add(CustomersListBox);
            CustomersGroupBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CustomersGroupBox.Location = new Point(3, 3);
            CustomersGroupBox.MaximumSize = new Size(1000, 0);
            CustomersGroupBox.MinimumSize = new Size(0, 550);
            CustomersGroupBox.Name = "CustomersGroupBox";
            CustomersGroupBox.Size = new Size(418, 597);
            CustomersGroupBox.TabIndex = 3;
            CustomersGroupBox.TabStop = false;
            CustomersGroupBox.Text = "Customers";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.5774651F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.4225349F));
            tableLayoutPanel2.Controls.Add(RemoveCustomerButton, 1, 0);
            tableLayoutPanel2.Controls.Add(AddCustomerButton, 0, 0);
            tableLayoutPanel2.Location = new Point(6, 549);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(406, 45);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Location = new Point(642, 447);
            panel1.Name = "panel1";
            panel1.Size = new Size(14, 144);
            panel1.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.99611F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67.00389F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(CustomersGroupBox, 0, 0);
            tableLayoutPanel1.Controls.Add(SelectedCustomerGroupBox, 1, 0);
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.MinimumSize = new Size(0, 575);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1285, 603);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // SelectedCustomerGroupBox
            // 
            SelectedCustomerGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SelectedCustomerGroupBox.Controls.Add(RemovePercentDiscountButton);
            SelectedCustomerGroupBox.Controls.Add(AddPercentDiscountButton);
            SelectedCustomerGroupBox.Controls.Add(CancelButton);
            SelectedCustomerGroupBox.Controls.Add(OkButton);
            SelectedCustomerGroupBox.Controls.Add(DiscountsListBox);
            SelectedCustomerGroupBox.Controls.Add(label3);
            SelectedCustomerGroupBox.Controls.Add(IsPriorityCheckBox);
            SelectedCustomerGroupBox.Controls.Add(AddressControl);
            SelectedCustomerGroupBox.Controls.Add(FullNameTextBox);
            SelectedCustomerGroupBox.Controls.Add(IdTextBox);
            SelectedCustomerGroupBox.Controls.Add(label2);
            SelectedCustomerGroupBox.Controls.Add(label1);
            SelectedCustomerGroupBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SelectedCustomerGroupBox.Location = new Point(427, 3);
            SelectedCustomerGroupBox.MinimumSize = new Size(0, 570);
            SelectedCustomerGroupBox.Name = "SelectedCustomerGroupBox";
            SelectedCustomerGroupBox.Size = new Size(855, 597);
            SelectedCustomerGroupBox.TabIndex = 4;
            SelectedCustomerGroupBox.TabStop = false;
            SelectedCustomerGroupBox.Text = "Selected Customer";
            // 
            // RemovePercentDiscountButton
            // 
            RemovePercentDiscountButton.Location = new Point(367, 528);
            RemovePercentDiscountButton.Name = "RemovePercentDiscountButton";
            RemovePercentDiscountButton.Size = new Size(107, 39);
            RemovePercentDiscountButton.TabIndex = 11;
            RemovePercentDiscountButton.Text = "Remove";
            RemovePercentDiscountButton.UseVisualStyleBackColor = true;
            RemovePercentDiscountButton.Click += RemovePercentDiscountButton_Click;
            // 
            // AddPercentDiscountButton
            // 
            AddPercentDiscountButton.Location = new Point(367, 479);
            AddPercentDiscountButton.Name = "AddPercentDiscountButton";
            AddPercentDiscountButton.Size = new Size(107, 45);
            AddPercentDiscountButton.TabIndex = 10;
            AddPercentDiscountButton.Text = "Add";
            AddPercentDiscountButton.UseVisualStyleBackColor = true;
            AddPercentDiscountButton.Click += AddPercentDiscountButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(152, 406);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(140, 39);
            CancelButton.TabIndex = 13;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // OkButton
            // 
            OkButton.Location = new Point(6, 406);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(140, 39);
            OkButton.TabIndex = 12;
            OkButton.Text = "Ok";
            OkButton.UseVisualStyleBackColor = true;
            OkButton.Click += OkButton_Click;
            // 
            // DiscountsListBox
            // 
            DiscountsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            DiscountsListBox.FormattingEnabled = true;
            DiscountsListBox.ItemHeight = 28;
            DiscountsListBox.Location = new Point(6, 479);
            DiscountsListBox.Name = "DiscountsListBox";
            DiscountsListBox.Size = new Size(355, 88);
            DiscountsListBox.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(6, 448);
            label3.Name = "label3";
            label3.Size = new Size(110, 28);
            label3.TabIndex = 9;
            label3.Text = "Discounts:";
            // 
            // IsPriorityCheckBox
            // 
            IsPriorityCheckBox.AutoSize = true;
            IsPriorityCheckBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            IsPriorityCheckBox.Location = new Point(218, 121);
            IsPriorityCheckBox.Name = "IsPriorityCheckBox";
            IsPriorityCheckBox.Size = new Size(126, 32);
            IsPriorityCheckBox.TabIndex = 8;
            IsPriorityCheckBox.Text = "is Priority";
            IsPriorityCheckBox.UseVisualStyleBackColor = true;
            IsPriorityCheckBox.CheckedChanged += IsPriorityCheckBox_CheckedChanged;
            // 
            // AddressControl
            // 
            address1.Apartment = "";
            address1.Building = "";
            address1.City = "";
            address1.Country = "";
            address1.Index = 111111;
            address1.Street = "";
            AddressControl.Address = address1;
            AddressControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AddressControl.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AddressControl.Location = new Point(6, 129);
            AddressControl.Margin = new Padding(3, 4, 3, 4);
            AddressControl.MinimumSize = new Size(731, 282);
            AddressControl.Name = "AddressControl";
            AddressControl.Size = new Size(731, 310);
            AddressControl.TabIndex = 6;
            // 
            // FullNameTextBox
            // 
            FullNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FullNameTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FullNameTextBox.Location = new Point(133, 81);
            FullNameTextBox.MaxLength = 200;
            FullNameTextBox.Name = "FullNameTextBox";
            FullNameTextBox.Size = new Size(599, 34);
            FullNameTextBox.TabIndex = 4;
            FullNameTextBox.TextChanged += FullNameTextBox_TextChanged;
            // 
            // IdTextBox
            // 
            IdTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            IdTextBox.Location = new Point(133, 41);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(99, 34);
            IdTextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(3, 87);
            label2.Name = "label2";
            label2.Size = new Size(113, 28);
            label2.TabIndex = 1;
            label2.Text = "Full Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(6, 47);
            label1.Name = "label1";
            label1.Size = new Size(38, 28);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.5774651F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.4225349F));
            tableLayoutPanel3.Controls.Add(button1, 1, 0);
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(200, 100);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.Location = new Point(102, 58);
            button1.Name = "button1";
            button1.Size = new Size(95, 39);
            button1.TabIndex = 2;
            button1.Text = "Remove";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button2.Location = new Point(3, 3);
            button2.Name = "button2";
            button2.Size = new Size(93, 94);
            button2.TabIndex = 1;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.5774651F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.4225349F));
            tableLayoutPanel4.Controls.Add(button3, 1, 0);
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(200, 100);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button3.Location = new Point(102, 89);
            button3.Name = "button3";
            button3.Size = new Size(95, 8);
            button3.TabIndex = 2;
            button3.Text = "Remove";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button4.Location = new Point(3, 3);
            button4.Name = "button4";
            button4.Size = new Size(93, 94);
            button4.TabIndex = 1;
            button4.Text = "Add";
            button4.UseVisualStyleBackColor = true;
            // 
            // СustomersTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "СustomersTab";
            Size = new Size(1291, 609);
            CustomersGroupBox.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            SelectedCustomerGroupBox.ResumeLayout(false);
            SelectedCustomerGroupBox.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListBox CustomersListBox;
        private Button AddCustomerButton;
        private Button RemoveCustomerButton;
        private GroupBox CustomersGroupBox;
        private GroupBox SelectedCustomerGroupBox;
        private TextBox FullNameTextBox;
        private TextBox IdTextBox;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private AddressControl AddressControl;
        private CheckBox IsPriorityCheckBox;
        private Button RemovePercentDiscountButton;
        private Button AddPercentDiscountButton;
        private ListBox DiscountsListBox;
        private Label label3;
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
