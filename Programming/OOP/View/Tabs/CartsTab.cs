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
        private Customer _currentCustomer;
        public List<Item> Items { get; set; }
        public List<Customer> Customers { get; set; }
        public void RefreshData()
        {
            if (Items != null)
            {
                ItemsListBox.Items.Clear();
                ItemsListBox.Items.AddRange(Items.ToArray());

            }
            if (Customers != null)
            {
                CustomersComboBox.Items.Clear();
                CustomersComboBox.Items.AddRange(Customers.ToArray());

            }
        }

        public CartsTab()
        {
            InitializeComponent();
            AddToCartButton.Enabled = false;

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CustomersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersComboBox.SelectedIndex != -1 && CustomersComboBox.SelectedIndex != null)
            {
                AddToCartButton.Enabled = true;
                CartListBox.Items.Clear();
                _currentCustomer = Customers[CustomersComboBox.SelectedIndex];
                CartListBox.Items.AddRange(_currentCustomer.Cart.Items.ToArray());
            }
            else
            {
                AddToCartButton.Enabled = false;
            }


        }


        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1)
            {
                _currentCustomer.Cart.Items.Add((Item)ItemsListBox.SelectedItem);
                CartListBox.Items.Add(ItemsListBox.SelectedItem);
                ItemsListBox.SelectedIndex = -1;
            }

        }
    }
}

