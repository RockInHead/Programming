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
            CustomersListBox = new ListBox();
            AddCustomerButton = new Button();
            RemoveCustomerButton = new Button();
            CustomersGroupBox = new GroupBox();
            SelectedCustomerGroupBox = new GroupBox();
            AddressRichTextBox = new RichTextBox();
            FullNameTextBox = new TextBox();
            IdTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            CustomersGroupBox.SuspendLayout();
            SelectedCustomerGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // CustomersListBox
            // 
            CustomersListBox.FormattingEnabled = true;
            CustomersListBox.Location = new Point(6, 26);
            CustomersListBox.Name = "CustomersListBox";
            CustomersListBox.Size = new Size(334, 444);
            CustomersListBox.TabIndex = 0;
            // 
            // AddCustomerButton
            // 
            AddCustomerButton.Location = new Point(6, 476);
            AddCustomerButton.Name = "AddCustomerButton";
            AddCustomerButton.Size = new Size(130, 47);
            AddCustomerButton.TabIndex = 1;
            AddCustomerButton.Text = "Add";
            AddCustomerButton.UseVisualStyleBackColor = true;
            // 
            // RemoveCustomerButton
            // 
            RemoveCustomerButton.Location = new Point(142, 476);
            RemoveCustomerButton.Name = "RemoveCustomerButton";
            RemoveCustomerButton.Size = new Size(139, 47);
            RemoveCustomerButton.TabIndex = 2;
            RemoveCustomerButton.Text = "Remove";
            RemoveCustomerButton.UseVisualStyleBackColor = true;
            RemoveCustomerButton.Click += button2_Click;
            // 
            // CustomersGroupBox
            // 
            CustomersGroupBox.Controls.Add(CustomersListBox);
            CustomersGroupBox.Controls.Add(AddCustomerButton);
            CustomersGroupBox.Controls.Add(RemoveCustomerButton);
            CustomersGroupBox.Font = new Font("Segoe UI", 9F);
            CustomersGroupBox.Location = new Point(3, 3);
            CustomersGroupBox.Name = "CustomersGroupBox";
            CustomersGroupBox.Size = new Size(349, 537);
            CustomersGroupBox.TabIndex = 3;
            CustomersGroupBox.TabStop = false;
            CustomersGroupBox.Text = "Customers";
            // 
            // SelectedCustomerGroupBox
            // 
            SelectedCustomerGroupBox.Controls.Add(AddressRichTextBox);
            SelectedCustomerGroupBox.Controls.Add(FullNameTextBox);
            SelectedCustomerGroupBox.Controls.Add(IdTextBox);
            SelectedCustomerGroupBox.Controls.Add(label3);
            SelectedCustomerGroupBox.Controls.Add(label2);
            SelectedCustomerGroupBox.Controls.Add(label1);
            SelectedCustomerGroupBox.Location = new Point(358, 3);
            SelectedCustomerGroupBox.Name = "SelectedCustomerGroupBox";
            SelectedCustomerGroupBox.Size = new Size(568, 289);
            SelectedCustomerGroupBox.TabIndex = 4;
            SelectedCustomerGroupBox.TabStop = false;
            SelectedCustomerGroupBox.Text = "Selected Customer";
            // 
            // AddressRichTextBox
            // 
            AddressRichTextBox.Location = new Point(138, 135);
            AddressRichTextBox.Name = "AddressRichTextBox";
            AddressRichTextBox.Size = new Size(404, 142);
            AddressRichTextBox.TabIndex = 5;
            AddressRichTextBox.Text = "";
            AddressRichTextBox.TextChanged += richTextBox1_TextChanged;
            // 
            // FullNameTextBox
            // 
            FullNameTextBox.Location = new Point(138, 86);
            FullNameTextBox.Name = "FullNameTextBox";
            FullNameTextBox.Size = new Size(404, 27);
            FullNameTextBox.TabIndex = 4;
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(138, 45);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(99, 27);
            IdTextBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(6, 121);
            label3.Name = "label3";
            label3.Size = new Size(86, 28);
            label3.TabIndex = 2;
            label3.Text = "Address:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(6, 82);
            label2.Name = "label2";
            label2.Size = new Size(104, 28);
            label2.TabIndex = 1;
            label2.Text = "Full Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(6, 41);
            label1.Name = "label1";
            label1.Size = new Size(35, 28);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Location = new Point(364, 298);
            panel1.Name = "panel1";
            panel1.Size = new Size(562, 242);
            panel1.TabIndex = 5;
            // 
            // ItemsTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(SelectedCustomerGroupBox);
            Controls.Add(CustomersGroupBox);
            Name = "ItemsTab";
            Size = new Size(1012, 567);
            CustomersGroupBox.ResumeLayout(false);
            SelectedCustomerGroupBox.ResumeLayout(false);
            SelectedCustomerGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox CustomersListBox;
        private Button AddCustomerButton;
        private Button RemoveCustomerButton;
        private GroupBox CustomersGroupBox;
        private GroupBox SelectedCustomerGroupBox;
        private RichTextBox AddressRichTextBox;
        private TextBox FullNameTextBox;
        private TextBox IdTextBox;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel1;
    }
}
