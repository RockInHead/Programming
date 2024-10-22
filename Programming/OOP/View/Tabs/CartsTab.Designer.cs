namespace OOP.View.Tabs
{
    partial class CartsTab
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
            ItemsListBox = new ListBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            AddToCartButton = new Button();
            groupBox2 = new GroupBox();
            CartListBox = new ListBox();
            AmountLabel = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ClearCartButton = new Button();
            CreateOrderButton = new Button();
            RemoveItemButton = new Button();
            CustomersComboBox = new ComboBox();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // ItemsListBox
            // 
            ItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.Location = new Point(6, 26);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(295, 524);
            ItemsListBox.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.26883F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.73117F));
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox2, 1, 0);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(863, 623);
            tableLayoutPanel1.TabIndex = 1;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(AddToCartButton);
            groupBox1.Controls.Add(ItemsListBox);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(307, 617);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Items";
            // 
            // AddToCartButton
            // 
            AddToCartButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddToCartButton.Location = new Point(6, 565);
            AddToCartButton.Name = "AddToCartButton";
            AddToCartButton.Size = new Size(140, 46);
            AddToCartButton.TabIndex = 1;
            AddToCartButton.Text = "Add To Cart";
            AddToCartButton.UseVisualStyleBackColor = true;
            AddToCartButton.Click += AddToCartButton_Click;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(CartListBox);
            groupBox2.Controls.Add(AmountLabel);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(ClearCartButton);
            groupBox2.Controls.Add(CreateOrderButton);
            groupBox2.Controls.Add(RemoveItemButton);
            groupBox2.Controls.Add(CustomersComboBox);
            groupBox2.Location = new Point(316, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(544, 617);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            // 
            // CartListBox
            // 
            CartListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CartListBox.FormattingEnabled = true;
            CartListBox.Location = new Point(10, 116);
            CartListBox.MinimumSize = new Size(520, 180);
            CartListBox.Name = "CartListBox";
            CartListBox.Size = new Size(521, 184);
            CartListBox.TabIndex = 10;
            // 
            // AmountLabel
            // 
            AmountLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AmountLabel.AutoSize = true;
            AmountLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AmountLabel.Location = new Point(439, 376);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(98, 31);
            AmountLabel.TabIndex = 9;
            AmountLabel.Text = "1234.59";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(446, 348);
            label3.Name = "label3";
            label3.Size = new Size(91, 28);
            label3.TabIndex = 8;
            label3.Text = "Amount:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(6, 86);
            label2.Name = "label2";
            label2.Size = new Size(54, 28);
            label2.TabIndex = 7;
            label2.Text = "Cart:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(6, 26);
            label1.Name = "label1";
            label1.Size = new Size(108, 28);
            label1.TabIndex = 6;
            label1.Text = "Customer:";
            // 
            // ClearCartButton
            // 
            ClearCartButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ClearCartButton.Location = new Point(397, 445);
            ClearCartButton.Name = "ClearCartButton";
            ClearCartButton.Size = new Size(140, 56);
            ClearCartButton.TabIndex = 4;
            ClearCartButton.Text = "Clear Cart";
            ClearCartButton.UseVisualStyleBackColor = true;
            // 
            // CreateOrderButton
            // 
            CreateOrderButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CreateOrderButton.Location = new Point(0, 446);
            CreateOrderButton.Name = "CreateOrderButton";
            CreateOrderButton.Size = new Size(133, 55);
            CreateOrderButton.TabIndex = 3;
            CreateOrderButton.Text = "Create Order";
            CreateOrderButton.UseVisualStyleBackColor = true;
            // 
            // RemoveItemButton
            // 
            RemoveItemButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            RemoveItemButton.Location = new Point(241, 445);
            RemoveItemButton.Name = "RemoveItemButton";
            RemoveItemButton.Size = new Size(140, 56);
            RemoveItemButton.TabIndex = 2;
            RemoveItemButton.Text = "Remove Item";
            RemoveItemButton.UseVisualStyleBackColor = true;
            // 
            // CustomersComboBox
            // 
            CustomersComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CustomersComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CustomersComboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CustomersComboBox.FormattingEnabled = true;
            CustomersComboBox.Location = new Point(120, 26);
            CustomersComboBox.Name = "CustomersComboBox";
            CustomersComboBox.Size = new Size(418, 36);
            CustomersComboBox.TabIndex = 0;
            CustomersComboBox.SelectedIndexChanged += CustomersComboBox_SelectedIndexChanged;
            // 
            // CartsTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "CartsTab";
            Size = new Size(866, 626);
            tableLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox ItemsListBox;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox1;
        private Button AddToCartButton;
        private GroupBox groupBox2;
        private Button ClearCartButton;
        private Button CreateOrderButton;
        private Button RemoveItemButton;
        private ComboBox CustomersComboBox;
        private Label AmountLabel;
        private Label label3;
        private Label label2;
        private Label label1;
        private ListBox CartListBox;
    }
}
