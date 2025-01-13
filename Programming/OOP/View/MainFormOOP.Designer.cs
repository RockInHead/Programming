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
            OrdersTabPage = new TabPage();
            OrdersTab = new View.Tabs.OrdersTab();
            CartsTabPage = new TabPage();
            СartsTab = new View.Tabs.CartsTab();
            CustomersTabPage = new TabPage();
            CustomersTab = new View.Tabs.СustomersTab();
            ItemsTabPage = new TabPage();
            ItemsTab = new View.Tabs.ItemsTab();
            TabControl = new TabControl();
            OrdersTabPage.SuspendLayout();
            CartsTabPage.SuspendLayout();
            CustomersTabPage.SuspendLayout();
            ItemsTabPage.SuspendLayout();
            TabControl.SuspendLayout();
            SuspendLayout();
            // 
            // OrdersTabPage
            // 
            OrdersTabPage.Controls.Add(OrdersTab);
            OrdersTabPage.Location = new Point(4, 29);
            OrdersTabPage.Name = "OrdersTabPage";
            OrdersTabPage.Padding = new Padding(3);
            OrdersTabPage.Size = new Size(1169, 672);
            OrdersTabPage.TabIndex = 3;
            OrdersTabPage.Text = "Orders";
            OrdersTabPage.UseVisualStyleBackColor = true;
            // 
            // OrdersTab
            // 
            OrdersTab.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OrdersTab.Customers = null;
            OrdersTab.Location = new Point(-4, 3);
            OrdersTab.Name = "OrdersTab";
            OrdersTab.Size = new Size(1170, 666);
            OrdersTab.TabIndex = 0;
            // 
            // CartsTabPage
            // 
            CartsTabPage.Controls.Add(СartsTab);
            CartsTabPage.Location = new Point(4, 29);
            CartsTabPage.Name = "CartsTabPage";
            CartsTabPage.Padding = new Padding(3);
            CartsTabPage.Size = new Size(1169, 672);
            CartsTabPage.TabIndex = 2;
            CartsTabPage.Text = "Carts";
            CartsTabPage.UseVisualStyleBackColor = true;
            // 
            // СartsTab
            // 
            СartsTab.Customers = null;
            СartsTab.Dock = DockStyle.Fill;
            СartsTab.Items = null;
            СartsTab.Location = new Point(3, 3);
            СartsTab.Name = "СartsTab";
            СartsTab.Size = new Size(1163, 666);
            СartsTab.TabIndex = 0;
            // 
            // CustomersTabPage
            // 
            CustomersTabPage.Controls.Add(CustomersTab);
            CustomersTabPage.Location = new Point(4, 29);
            CustomersTabPage.Name = "CustomersTabPage";
            CustomersTabPage.Padding = new Padding(3);
            CustomersTabPage.Size = new Size(1169, 672);
            CustomersTabPage.TabIndex = 1;
            CustomersTabPage.Text = "Customers";
            CustomersTabPage.UseVisualStyleBackColor = true;
            // 
            // CustomersTab
            // 
            CustomersTab.Customers = null;
            CustomersTab.Dock = DockStyle.Fill;
            CustomersTab.Location = new Point(3, 3);
            CustomersTab.Name = "CustomersTab";
            CustomersTab.Size = new Size(1163, 666);
            CustomersTab.TabIndex = 0;
            // 
            // ItemsTabPage
            // 
            ItemsTabPage.Controls.Add(ItemsTab);
            ItemsTabPage.Location = new Point(4, 29);
            ItemsTabPage.Name = "ItemsTabPage";
            ItemsTabPage.Padding = new Padding(3);
            ItemsTabPage.Size = new Size(1169, 672);
            ItemsTabPage.TabIndex = 0;
            ItemsTabPage.Text = "Items";
            ItemsTabPage.UseVisualStyleBackColor = true;
            // 
            // ItemsTab
            // 
            ItemsTab.Dock = DockStyle.Fill;
            ItemsTab.Items = null;
            ItemsTab.Location = new Point(3, 3);
            ItemsTab.Name = "ItemsTab";
            ItemsTab.Size = new Size(1163, 666);
            ItemsTab.TabIndex = 0;
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
            OrdersTabPage.ResumeLayout(false);
            CartsTabPage.ResumeLayout(false);
            CustomersTabPage.ResumeLayout(false);
            ItemsTabPage.ResumeLayout(false);
            TabControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        /*private View.Tabs.DiscountsTab discountsTab1;*/
        private TabPage OrdersTabPage;
        private View.Tabs.OrdersTab OrdersTab;
        private TabPage CartsTabPage;
        private View.Tabs.CartsTab СartsTab;
        private TabPage CustomersTabPage;
        private View.Tabs.СustomersTab CustomersTab;
        private TabPage ItemsTabPage;
        private View.Tabs.ItemsTab ItemsTab;
        private TabControl TabControl;
    }
}
