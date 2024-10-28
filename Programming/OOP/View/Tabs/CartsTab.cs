using OOP.Model;
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
        /// <summary>
        /// Очищает все товары в корзине текущего клиента и CartItemsListBox.
        /// </summary>
        private void ClearCart()
        {
            if (_currentCustomer != null)
            {
                _currentCustomer.Cart.Items.Clear();
                CartListBox.Items.Clear();
            }
        }
        /// <summary>
        /// Обновляет информацию о сумме товаров в корзине и отображает ее в AmountLabel.
        /// </summary>
        private void UpdateAmount()
        {

            if (_currentCustomer == null)
            {
                AmountLabel.Text = "0";
                return;
            };
            AmountLabel.Text = _currentCustomer.Cart.Amount.ToString();
        }
        public CartsTab()
        {
            InitializeComponent();
            AddToCartButton.Enabled = false;

        }


        private void CustomersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersComboBox.SelectedIndex != -1 && CustomersComboBox.SelectedIndex != null)
            {
                AddToCartButton.Enabled = true;
                CartListBox.Items.Clear();
                _currentCustomer = Customers[CustomersComboBox.SelectedIndex];
/*                if (_currentCustomer.Cart.Items != null)
                {*/
                    CartListBox.Items.AddRange(_currentCustomer.Cart.Items.ToArray());
/*                }*/
                UpdateAmount();
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
                UpdateAmount();
            }
        }
        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (CartListBox.SelectedIndex != -1)
            {
                _currentCustomer.Cart.Items.RemoveAt(CartListBox.SelectedIndex);
                CartListBox.Items.RemoveAt(CartListBox.SelectedIndex);
                UpdateAmount();
            }
        }
        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            ClearCart();
            UpdateAmount();
            
        }

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            if (CartListBox.Items.Count != 0)
            {
                string year = DateTime.Now.Year.ToString();
                string month = DateTime.Now.Month.ToString();
                string day = DateTime.Now.Day.ToString();
                string hour = DateTime.Now.Hour.ToString();
                string minute = DateTime.Now.Minute.ToString();
                string Date = day +"."+ month + "." + year + ". " + hour + ":" +minute;
                List<Item> items = _currentCustomer.Cart.Items;
                Order newOrder = new Order(OrderStatus.New, Date, items,_currentCustomer.Address);
                _currentCustomer.Orders.Add(newOrder);


                items.Clear();
                ClearCart();
                UpdateAmount();
            }
        }
    }
}

