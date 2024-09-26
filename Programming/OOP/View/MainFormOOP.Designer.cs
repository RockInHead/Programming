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
            сustomers1 = new View.Tabs.Сustomers();
            ItemsTabPage = new TabPage();
            itemsTab1 = new View.Tabs.ItemsTab();
            tabControl1 = new TabControl();
            CustomersTabPage.SuspendLayout();
            ItemsTabPage.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // CustomersTabPage
            // 
            CustomersTabPage.Controls.Add(сustomers1);
            CustomersTabPage.Location = new Point(4, 29);
            CustomersTabPage.Name = "CustomersTabPage";
            CustomersTabPage.Padding = new Padding(3);
            CustomersTabPage.Size = new Size(949, 689);
            CustomersTabPage.TabIndex = 1;
            CustomersTabPage.Text = "Customers";
            CustomersTabPage.UseVisualStyleBackColor = true;
            // 
            // сustomers1
            // 
            сustomers1.Dock = DockStyle.Fill;
            сustomers1.Location = new Point(3, 3);
            сustomers1.Name = "сustomers1";
            сustomers1.Size = new Size(943, 683);
            сustomers1.TabIndex = 0;
            // 
            // ItemsTabPage
            // 
            ItemsTabPage.Controls.Add(itemsTab1);
            ItemsTabPage.Location = new Point(4, 29);
            ItemsTabPage.Name = "ItemsTabPage";
            ItemsTabPage.Padding = new Padding(3);
            ItemsTabPage.Size = new Size(949, 689);
            ItemsTabPage.TabIndex = 0;
            ItemsTabPage.Text = "Items";
            ItemsTabPage.UseVisualStyleBackColor = true;
            // 
            // itemsTab1
            // 
            itemsTab1.Dock = DockStyle.Fill;
            itemsTab1.Location = new Point(3, 3);
            itemsTab1.Name = "itemsTab1";
            itemsTab1.Size = new Size(943, 683);
            itemsTab1.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(ItemsTabPage);
            tabControl1.Controls.Add(CustomersTabPage);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(957, 722);
            tabControl1.TabIndex = 0;
            // 
            // MainFormOOP
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 722);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(975, 635);
            Name = "MainFormOOP";
            Text = "Object Oriented Practics";
            Load += Form1_Load;
            CustomersTabPage.ResumeLayout(false);
            ItemsTabPage.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage CustomersTabPage;
        private TabPage ItemsTabPage;
        private TabControl tabControl1;
        private View.Tabs.Сustomers сustomers1;
        private View.Tabs.ItemsTab itemsTab1;
    }
}
