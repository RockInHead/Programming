using OOP.Model;
using OOP.Model.Discounts;
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
    public partial class СustomersTab : UserControl
    {
        private List<Customer> _customers;
        private Customer _currentCustomer;
        private List<string> CustomersListBoxItems = new List<string>();

        /// <summary>
        /// Получает или устанавливает список клиентов.
        /// </summary>
        public List<Customer> Customers
        {
            get { return _customers; }
            set { _customers = value; }
        }

        /// <summary>
        /// Конструктор класса CustomersTab, инициализирует компоненты.
        /// </summary>
        public СustomersTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Удалить клиента".
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void RemoveCustomerButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = CustomersListBox.SelectedIndex;

            if (selectedIndex == -1) return;

            Customers.RemoveAt(selectedIndex);
            CustomersListBoxItems.RemoveAt(selectedIndex);
            CustomersListBox.Items.RemoveAt(selectedIndex);

            FullNameTextBox.Text = "";
        }



        /// <summary>
        /// Обработчик изменения выбранного клиента в списке.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.Items.Count == 0 || CustomersListBox.SelectedIndex == -1)
            {
                addressControl1.ListBoxNull = true;
                AddCustomerButton.Enabled = true;
                IdTextBox.Text = "";

                FullNameTextBox.Text = "";
                IsPriorityCheckBox.Checked = false;
                addressControl1.ClearForm();
                DiscountsListBox.Items.Clear();
            }
            else
            {
                DiscountsListBox.Items.Clear();

                addressControl1.ListBoxNull = false;

                AddCustomerButton.Enabled = false;


                int selectedIndex = CustomersListBox.SelectedIndex;
                if (selectedIndex == -1) return;

                _currentCustomer = Customers[selectedIndex];

                IdTextBox.Text = _currentCustomer.Id.ToString();
                FullNameTextBox.Text = _currentCustomer.FullName;
                IsPriorityCheckBox.Checked = _currentCustomer.IsPriority;

                addressControl1.ShowValues(_currentCustomer.Address);

                foreach (IDiscount discount in _currentCustomer.Discounts)
                {
                    DiscountsListBox.Items.Add(discount.Info);
                }
            }
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Добавить клиента".
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            Customer NewCustomer = new Customer();
            NewCustomer.FullName = FullNameTextBox.Text;
            NewCustomer.IsPriority = IsPriorityCheckBox.Checked;
            NewCustomer.Address = addressControl1.GiveValues();

            Customers.Add(NewCustomer);
            CustomersListBoxItems.Add($"{NewCustomer.Id.ToString()})");
            CustomersListBox.Items.Add(CustomersListBoxItems[CustomersListBoxItems.Count - 1]);

            FullNameTextBox.Text = "";
            IsPriorityCheckBox.Checked = false;
            addressControl1.ClearForm();
        }

        /// <summary>
        /// Обработчик изменения текста в текстовом поле полного имени клиента.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if ((CustomersListBox.SelectedIndex != -1))
            {
                _currentCustomer.FullName = FullNameTextBox.Text;
            }
        }

        /// <summary>
        /// Обработчик события нажатия мыши на CustomersListBox.
        /// Сбрасывает выбор, если кликнули на пустое место.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void CustomersListBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (CustomersListBox.IndexFromPoint(e.Location) == -1)
            {
                // Если кликнули на пустое место, сбрасываем выбор
                addressControl1.ListBoxNull = true;
                CustomersListBox.ClearSelected();
                CustomersListBox.SelectedIndex = -1;

            }
        }

        /// <summary>
        /// Обработчик изменения состояния чекбокса "Приоритет".
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void IsPriorityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if ((CustomersListBox.SelectedIndex != -1))
            {
                _currentCustomer.IsPriority = IsPriorityCheckBox.Checked;
            }
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Добавить скидку".
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void AddPercentDiscountButton_Click(object sender, EventArgs e)
        {

            if ((CustomersListBox.SelectedIndex != -1))
            {
                DiscountCategoryForm discountCategoryForm = new DiscountCategoryForm();
                if (discountCategoryForm.ShowDialog() == DialogResult.OK)
                {
                    _currentCustomer.Discounts.Add(discountCategoryForm.Discount);
                    DiscountsListBox.Items.Add(discountCategoryForm.Discount.Info);
                }
            }

        }

        /// <summary>
        /// Обработчик нажатия кнопки "Удалить процентную скидку".
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void RemovePercentDiscountButton_Click(object sender, EventArgs e)
        {
            if((CustomersListBox.SelectedIndex != -1)) 
            { 
            if(DiscountsListBox.SelectedIndex != -1)
                {
                    if (_currentCustomer.Discounts[DiscountsListBox.SelectedIndex] is not PointsDiscount)
                    {
                        _currentCustomer.Discounts.RemoveAt(DiscountsListBox.SelectedIndex);
                        DiscountsListBox.Items.RemoveAt(DiscountsListBox.SelectedIndex);
                    }
                }
            }
        }
    }
}
