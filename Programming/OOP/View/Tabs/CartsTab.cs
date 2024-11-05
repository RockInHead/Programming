using OOP.Model;
using OOP.Model.Orders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
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
                DiscountCheckedListBox.Items.Clear();
                _currentCustomer = Customers[CustomersComboBox.SelectedIndex];
                /*                if (_currentCustomer.Cart.Items != null)
                                {*/
                CartListBox.Items.AddRange(_currentCustomer.Cart.Items.ToArray());
                /*                }*/
                for (int i = 0; i < _currentCustomer.Discounts.Count; i++)
                {
                    DiscountCheckedListBox.Items.Add(_currentCustomer.Discounts[i].Info);
                    DiscountCheckedListBox.SetItemChecked(i, true);
                }
                UpdateAmount();
                UpdateDiscountAndTotalAmount();
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
                UpdateDiscountAndTotalAmount();
            }
        }
        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (CartListBox.SelectedIndex != -1)
            {
                _currentCustomer.Cart.Items.RemoveAt(CartListBox.SelectedIndex);
                CartListBox.Items.RemoveAt(CartListBox.SelectedIndex);
                UpdateAmount();
                UpdateDiscountAndTotalAmount();
            }
        }
        private void ClearCartButton_Click(object sender, EventArgs e)
        {

            ClearCart();
            UpdateAmount();
            UpdateDiscountAndTotalAmount();
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
                string Date = day + "." + month + "." + year + ". " + hour + ":" + minute;
                List<Item> items = _currentCustomer.Cart.Items;
                Order newOrder;

                if (_currentCustomer.IsPriority == true)
                {
                    newOrder = new PriorityOrder(OrderStatus.New, Date, items, _currentCustomer.Address, DateTime.Now, DeliveryTimeRange.Range9To11);
                }
                else
                {
                    newOrder = new Order(OrderStatus.New, Date, items, _currentCustomer.Address);
                }

                _currentCustomer.Orders.Add(newOrder);
                
                DiscountAmountLabel.Text = CreateOrder().ToString();
                ClearDiscountAndTotalLabels();

                items.Clear();
                ClearCart();
                UpdateAmount();
            }
        }
        private void ClearDiscountAndTotalLabels()
        {
            DiscountAmountLabel.Text = "0";
            TotalLabel.Text = "0";
        }
        private void DiscountCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDiscountAndTotalAmount();
        }
        /// <summary>
        /// Обновляет сумму скидки и итоговую сумму заказа.
        /// </summary>
        private void UpdateDiscountAndTotalAmount()
        {
            int discountAmount = 0;
            ClearDiscountAndTotalLabels();
            if (_currentCustomer == null) return;
            foreach (int indexOfDiscount in DiscountCheckedListBox.CheckedIndices)
            {
                discountAmount += (int)_currentCustomer.Discounts[indexOfDiscount].Calculate(_currentCustomer.Cart.Items);
            }
            DiscountAmountLabel.Text = discountAmount.ToString();
            TotalLabel.Text = ((_currentCustomer.Cart.Amount - discountAmount).ToString());
        }
        /// <summary>
        /// Устанавливает флажки для всех элементов в списке скидок.
        /// </summary>
        private void CheckAllItems()
        {
            for (int i = 0; i < DiscountCheckedListBox.Items.Count; i++)
            {
                DiscountCheckedListBox.SetItemChecked(i, true);
            }
        }
        public int CreateOrder()
        {
            int discountAmount = 0;
            ClearDiscountAndTotalLabels();
            if (_currentCustomer == null) return 0;
            foreach (int indexOfDiscount in DiscountCheckedListBox.CheckedIndices)
            {
                discountAmount += (int)_currentCustomer.Discounts[indexOfDiscount].Apply(_currentCustomer.Cart.Items);
            }

            /*foreach (int indexOfDiscount in DiscountCheckedListBox.CheckedIndices)
            {*/
            for(int indexOfDiscount = 0; indexOfDiscount < DiscountCheckedListBox.Items.Count; indexOfDiscount++) { 
                _currentCustomer.Discounts[indexOfDiscount].Update(_currentCustomer.Cart.Items);
            }
            UpdateDiscountsCheckedListBox();
            return discountAmount;
        }
        /// <summary>
        /// Обновляет список доступных скидок в CheckedListBox.
        /// Устанавливает флажки для всех скидок.
        /// </summary>
        private void UpdateDiscountsCheckedListBox()
        {
            DiscountCheckedListBox.Items.Clear();
            if (_currentCustomer == null) return;
            for (int i = 0; i < _currentCustomer.Discounts.Count; i++)
            {
                DiscountCheckedListBox.Items.Add(_currentCustomer.Discounts[i].Info);
            }
            CheckAllItems();
            UpdateDiscountAndTotalAmount();
        }
    }
}

