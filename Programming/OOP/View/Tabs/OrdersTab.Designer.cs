namespace OOP.View.Tabs
{
    partial class OrdersTab
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
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            PriorityOrdersPanel = new Panel();
            label7 = new Label();
            DeliveryTimeRangeComboBox = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            AmountLabel = new Label();
            label4 = new Label();
            OrderItemsListBox = new ListBox();
            addressControl1 = new AddressControl();
            OrderStatusComboBox = new ComboBox();
            label3 = new Label();
            OrderCreatedTextBox = new TextBox();
            label2 = new Label();
            OrderIdTextBox = new TextBox();
            label1 = new Label();
            OrdersDataGridView = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            PriorityOrdersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OrdersDataGridView).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.37168F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58.62832F));
            tableLayoutPanel1.Controls.Add(groupBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(OrdersDataGridView, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1170, 688);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(PriorityOrdersPanel);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(AmountLabel);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(OrderItemsListBox);
            groupBox1.Controls.Add(addressControl1);
            groupBox1.Controls.Add(OrderStatusComboBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(OrderCreatedTextBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(OrderIdTextBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBox1.Location = new Point(487, 3);
            groupBox1.MinimumSize = new Size(680, 680);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(680, 682);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Selected Order";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // PriorityOrdersPanel
            // 
            PriorityOrdersPanel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PriorityOrdersPanel.Controls.Add(label7);
            PriorityOrdersPanel.Controls.Add(DeliveryTimeRangeComboBox);
            PriorityOrdersPanel.Controls.Add(label6);
            PriorityOrdersPanel.Location = new Point(366, 33);
            PriorityOrdersPanel.MinimumSize = new Size(308, 104);
            PriorityOrdersPanel.Name = "PriorityOrdersPanel";
            PriorityOrdersPanel.Size = new Size(308, 104);
            PriorityOrdersPanel.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label7.Location = new Point(3, 52);
            label7.Name = "label7";
            label7.Size = new Size(127, 25);
            label7.TabIndex = 13;
            label7.Text = "Delivery Time:";
            // 
            // DeliveryTimeRangeComboBox
            // 
            DeliveryTimeRangeComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DeliveryTimeRangeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DeliveryTimeRangeComboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DeliveryTimeRangeComboBox.FormattingEnabled = true;
            DeliveryTimeRangeComboBox.Location = new Point(131, 48);
            DeliveryTimeRangeComboBox.Name = "DeliveryTimeRangeComboBox";
            DeliveryTimeRangeComboBox.Size = new Size(174, 36);
            DeliveryTimeRangeComboBox.TabIndex = 12;
            DeliveryTimeRangeComboBox.SelectedIndexChanged += DeliveryTimeRangeComboBox_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label6.Location = new Point(3, 6);
            label6.Name = "label6";
            label6.Size = new Size(144, 25);
            label6.TabIndex = 12;
            label6.Text = "Priority Options:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(0, 453);
            label5.Name = "label5";
            label5.Size = new Size(129, 28);
            label5.TabIndex = 10;
            label5.Text = "Order Items:";
            // 
            // AmountLabel
            // 
            AmountLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AmountLabel.AutoSize = true;
            AmountLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AmountLabel.Location = new Point(4, 635);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(46, 31);
            AmountLabel.TabIndex = 9;
            AmountLabel.Text = "0,0";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(0, 597);
            label4.Name = "label4";
            label4.Size = new Size(133, 38);
            label4.TabIndex = 8;
            label4.Text = "Amount:";
            // 
            // OrderItemsListBox
            // 
            OrderItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OrderItemsListBox.FormattingEnabled = true;
            OrderItemsListBox.ItemHeight = 28;
            OrderItemsListBox.Location = new Point(0, 484);
            OrderItemsListBox.Name = "OrderItemsListBox";
            OrderItemsListBox.Size = new Size(519, 116);
            OrderItemsListBox.TabIndex = 7;
            // 
            // addressControl1
            // 
            address1.Apartment = "";
            address1.Building = "";
            address1.City = "";
            address1.Country = "";
            address1.Index = 111111;
            address1.Street = "";
            addressControl1.Address = address1;
            addressControl1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            addressControl1.Enabled = false;
            addressControl1.Location = new Point(0, 174);
            addressControl1.Margin = new Padding(4);
            addressControl1.Name = "addressControl1";
            addressControl1.Size = new Size(634, 303);
            addressControl1.TabIndex = 6;
            // 
            // OrderStatusComboBox
            // 
            OrderStatusComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            OrderStatusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            OrderStatusComboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            OrderStatusComboBox.FormattingEnabled = true;
            OrderStatusComboBox.Location = new Point(100, 131);
            OrderStatusComboBox.MinimumSize = new Size(260, 0);
            OrderStatusComboBox.Name = "OrderStatusComboBox";
            OrderStatusComboBox.Size = new Size(260, 36);
            OrderStatusComboBox.TabIndex = 5;
            OrderStatusComboBox.SelectedIndexChanged += OrderStatusComboBox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label3.Location = new Point(16, 142);
            label3.Name = "label3";
            label3.Size = new Size(65, 25);
            label3.TabIndex = 4;
            label3.Text = "Status:";
            // 
            // OrderCreatedTextBox
            // 
            OrderCreatedTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            OrderCreatedTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            OrderCreatedTextBox.Location = new Point(100, 81);
            OrderCreatedTextBox.MinimumSize = new Size(260, 34);
            OrderCreatedTextBox.Name = "OrderCreatedTextBox";
            OrderCreatedTextBox.ReadOnly = true;
            OrderCreatedTextBox.Size = new Size(260, 34);
            OrderCreatedTextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.Location = new Point(16, 90);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 2;
            label2.Text = "Created:";
            // 
            // OrderIdTextBox
            // 
            OrderIdTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            OrderIdTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            OrderIdTextBox.Location = new Point(100, 33);
            OrderIdTextBox.MinimumSize = new Size(260, 34);
            OrderIdTextBox.Name = "OrderIdTextBox";
            OrderIdTextBox.ReadOnly = true;
            OrderIdTextBox.Size = new Size(260, 34);
            OrderIdTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(16, 39);
            label1.Name = "label1";
            label1.Size = new Size(34, 25);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // OrdersDataGridView
            // 
            OrdersDataGridView.AllowUserToAddRows = false;
            OrdersDataGridView.AllowUserToDeleteRows = false;
            OrdersDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OrdersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrdersDataGridView.Location = new Point(3, 3);
            OrdersDataGridView.MultiSelect = false;
            OrdersDataGridView.Name = "OrdersDataGridView";
            OrdersDataGridView.ReadOnly = true;
            OrdersDataGridView.RowHeadersVisible = false;
            OrdersDataGridView.RowHeadersWidth = 51;
            OrdersDataGridView.Size = new Size(478, 682);
            OrdersDataGridView.TabIndex = 1;
            OrdersDataGridView.CurrentCellChanged += OrdersDataGridView_CurrentCellChanged;
            // 
            // OrdersTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "OrdersTab";
            Size = new Size(1170, 688);
            tableLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            PriorityOrdersPanel.ResumeLayout(false);
            PriorityOrdersPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)OrdersDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox1;
        private TextBox OrderIdTextBox;
        private Label label1;
        private AddressControl addressControl1;
        private ComboBox OrderStatusComboBox;
        private Label label3;
        private TextBox OrderCreatedTextBox;
        private Label label2;
        private DataGridView OrdersDataGridView;
        private Label AmountLabel;
        private Label label4;
        private ListBox OrderItemsListBox;
        private Label label5;
        private Panel PriorityOrdersPanel;
        private ComboBox DeliveryTimeRangeComboBox;
        private Label label6;
        private Label label7;
    }
}
