using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP.View.Tabs
{
    public partial class CartsTab : UserControl
    {
        private Item _items;
        private Customer _customer;
        public List<Item> Items { get; set; }
        public List<Customer> Customers { get; set; }
        public void RefreshData()
        {
            if(Items != null)
            {
                ItemsListBox.Items.Clear();
                ItemsListBox.Items.AddRange(Items.ToArray());

            }
            if (Customers != null)
            {
                CustomerComboBox.Items.Clear();
                CustomerComboBox.Items.AddRange(Customers.ToArray());

            }
        }

        public CartsTab()
        {
            InitializeComponent();

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
