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
            tabControl1 = new TabControl();
            CartsTabPage = new TabPage();
            cartsTab1 = new View.Tabs.CartsTab();
            CustomersTabPage.SuspendLayout();
            ItemsTabPage.SuspendLayout();
            tabControl1.SuspendLayout();
            CartsTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // CustomersTabPage
            // 
            CustomersTabPage.Controls.Add(сustomersTab);
            CustomersTabPage.Location = new Point(4, 29);
            CustomersTabPage.Name = "CustomersTabPage";
            CustomersTabPage.Padding = new Padding(3);
            CustomersTabPage.Size = new Size(949, 631);
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
            сustomersTab.Size = new Size(943, 625);
            сustomersTab.TabIndex = 0;
            // 
            // ItemsTabPage
            // 
            ItemsTabPage.Controls.Add(itemsTab1);
            ItemsTabPage.Location = new Point(4, 29);
            ItemsTabPage.Name = "ItemsTabPage";
            ItemsTabPage.Padding = new Padding(3);
            ItemsTabPage.Size = new Size(949, 631);
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
            itemsTab1.Size = new Size(943, 625);
            itemsTab1.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(ItemsTabPage);
            tabControl1.Controls.Add(CustomersTabPage);
            tabControl1.Controls.Add(CartsTabPage);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(957, 664);
            tabControl1.TabIndex = 0;
            // 
            // CartsTabPage
            // 
            CartsTabPage.Controls.Add(cartsTab1);
            CartsTabPage.Location = new Point(4, 29);
            CartsTabPage.Name = "CartsTabPage";
            CartsTabPage.Padding = new Padding(3);
            CartsTabPage.Size = new Size(949, 631);
            CartsTabPage.TabIndex = 2;
            CartsTabPage.Text = "Carts";
            CartsTabPage.UseVisualStyleBackColor = true;
            // 
            // cartsTab1
            // 
            cartsTab1.Dock = DockStyle.Fill;
            cartsTab1.Location = new Point(3, 3);
            cartsTab1.Name = "cartsTab1";
            cartsTab1.Size = new Size(943, 625);
            cartsTab1.TabIndex = 0;
            // 
            // MainFormOOP
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 664);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(975, 635);
            Name = "MainFormOOP";
            Text = "Object Oriented Practics";
            Load += Form1_Load;
            CustomersTabPage.ResumeLayout(false);
            ItemsTabPage.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            CartsTabPage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage CustomersTabPage;
        private TabPage ItemsTabPage;
        private TabControl tabControl1;
        private View.Tabs.СustomersTab сustomersTab;
        private View.Tabs.ItemsTab itemsTab1;
        private TabPage CartsTabPage;
        private View.Tabs.CartsTab cartsTab1;
    }
}
