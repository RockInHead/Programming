namespace OOP
{
    partial class MainFormOOP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFormOOP));
            CustomersTabPage = new TabPage();
            сustomersTab = new View.Tabs.СustomersTab();
            ItemsTabPage = new TabPage();
            itemsTab1 = new View.Tabs.ItemsTab();
            TabControl = new TabControl();
            CartsTabPage = new TabPage();
            cartsTab1 = new View.Tabs.CartsTab();
            OrdersTabPage = new TabPage();
            ordersTab1 = new View.Tabs.OrdersTab();
            CustomersTabPage.SuspendLayout();
            ItemsTabPage.SuspendLayout();
            TabControl.SuspendLayout();
            CartsTabPage.SuspendLayout();
            OrdersTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // CustomersTabPage
            // 
            CustomersTabPage.Controls.Add(сustomersTab);
            CustomersTabPage.Location = new Point(4, 29);
            CustomersTabPage.Name = "CustomersTabPage";
            CustomersTabPage.Padding = new Padding(3);
            CustomersTabPage.Size = new Size(1169, 672);
            CustomersTabPage.TabIndex = 1;
            CustomersTabPage.Text = "Customers";
            CustomersTabPage.UseVisualStyleBackColor = true;
            // 
            // сustomersTab
            // 
            сustomersTab.Customers = null;
            сustomersTab.Dock = DockStyle.Fill;
            сustomersTab.Location = new Point(3, 3);
            сustomersTab.Name = "сustomersTab";
            сustomersTab.Size = new Size(1163, 666);
            сustomersTab.TabIndex = 0;
            // 
            // ItemsTabPage
            // 
            ItemsTabPage.Controls.Add(itemsTab1);
            ItemsTabPage.Location = new Point(4, 29);
            ItemsTabPage.Name = "ItemsTabPage";
            ItemsTabPage.Padding = new Padding(3);
            ItemsTabPage.Size = new Size(1169, 672);
            ItemsTabPage.TabIndex = 0;
            ItemsTabPage.Text = "Items";
            ItemsTabPage.UseVisualStyleBackColor = true;
            // 
            // itemsTab1
            // 
            itemsTab1.Dock = DockStyle.Fill;
            itemsTab1.Items = null;
            itemsTab1.Location = new Point(3, 3);
            itemsTab1.Name = "itemsTab1";
            itemsTab1.Size = new Size(1163, 666);
            itemsTab1.TabIndex = 0;
            // 
            // TabControl
            // 
            TabControl.Controls.Add(ItemsTabPage);
            TabControl.Controls.Add(CustomersTabPage);
            TabControl.Controls.Add(CartsTabPage);
            TabControl.Controls.Add(OrdersTabPage);
            TabControl.Dock = DockStyle.Fill;
            TabControl.Location = new Point(0, 0);
            TabControl.Multiline = true;
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(1177, 705);
            TabControl.TabIndex = 0;
            TabControl.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // CartsTabPage
            // 
            CartsTabPage.Controls.Add(cartsTab1);
            CartsTabPage.Location = new Point(4, 29);
            CartsTabPage.Name = "CartsTabPage";
            CartsTabPage.Padding = new Padding(3);
            CartsTabPage.Size = new Size(1169, 672);
            CartsTabPage.TabIndex = 2;
            CartsTabPage.Text = "Carts";
            CartsTabPage.UseVisualStyleBackColor = true;
            // 
            // cartsTab1
            // 
            cartsTab1.Customers = null;
            cartsTab1.Dock = DockStyle.Fill;
            cartsTab1.Items = null;
            cartsTab1.Location = new Point(3, 3);
            cartsTab1.Name = "cartsTab1";
            cartsTab1.Size = new Size(1163, 666);
            cartsTab1.TabIndex = 0;
            // 
            // OrdersTabPage
            // 
            OrdersTabPage.Controls.Add(ordersTab1);
            OrdersTabPage.Location = new Point(4, 29);
            OrdersTabPage.Name = "OrdersTabPage";
            OrdersTabPage.Padding = new Padding(3);
            OrdersTabPage.Size = new Size(1169, 672);
            OrdersTabPage.TabIndex = 3;
            OrdersTabPage.Text = "Orders";
            OrdersTabPage.UseVisualStyleBackColor = true;
            // 
            // ordersTab1
            // 
            ordersTab1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ordersTab1.Customers = null;
            ordersTab1.Location = new Point(-4, 3);
            ordersTab1.Name = "ordersTab1";
            ordersTab1.Size = new Size(1170, 666);
            ordersTab1.TabIndex = 0;
            // 
            // MainFormOOP
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1177, 705);
            Controls.Add(TabControl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(975, 635);
            Name = "MainFormOOP";
            Text = "Object Oriented Practics";
            Load += Form1_Load;
            CustomersTabPage.ResumeLayout(false);
            ItemsTabPage.ResumeLayout(false);
            TabControl.ResumeLayout(false);
            CartsTabPage.ResumeLayout(false);
            OrdersTabPage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage CustomersTabPage;
        private TabPage ItemsTabPage;
        private TabControl TabControl;
        private View.Tabs.СustomersTab сustomersTab;
        private View.Tabs.ItemsTab itemsTab1;
        private TabPage CartsTabPage;
        private View.Tabs.CartsTab cartsTab1;
        private TabPage OrdersTabPage;
        private View.Tabs.OrdersTab ordersTab1;
    }
}
