using OOP.Model;
using OOP.Model.Discounts;

namespace OOP.View.Tabs
{
    public partial class СustomersTab : UserControl
    {
        /// <summary>
        /// Список покупателей.
        /// </summary>
        private List<Customer> _customers;

        /// <summary>
        /// Текущий выбранный покупатель.
        /// </summary>
        private Customer _currentCustomer;

        /// <summary>
        /// Получает или устанавливает список клиентов.
        /// </summary>
        public List<Customer> Customers
        {
            get { return _customers; }
            set { _customers = value; }
        }

        /// <summary>
        /// Событие изменения заказчиков.
        /// </summary>
        public event EventHandler<EventArgs> CustomersChanged;

        /// <summary>
        /// Конструктор класса CustomersTab, инициализирует компоненты.
        /// </summary>
        public СustomersTab()
        {
            InitializeComponent();
            FullNameTextBox.ReadOnly = true;
            AddressControl.Enabled = false;
            IsPriorityCheckBox.Enabled = false;
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Удалить покупателя".
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void RemoveCustomerButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = CustomersListBox.SelectedIndex;
            if (selectedIndex == -1) return;

            Customers.RemoveAt(selectedIndex);
            CustomersListBox.Items.RemoveAt(selectedIndex);
            FullNameTextBox.Text = "";

            CustomersChanged?.Invoke(this, EventArgs.Empty);
        }


        /// <summary>
        /// Обработчик изменения выбранного клиента в списке.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex == -1)
            {
                AddCustomerButton.Enabled = true;
                IdTextBox.Text = "";
                FullNameTextBox.Text = "";
                IsPriorityCheckBox.Checked = false;
                AddressControl.ClearForm();
                DiscountsListBox.Items.Clear();

                CustomersChanged?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                DiscountsListBox.Items.Clear();
                int selectedIndex = CustomersListBox.SelectedIndex;
                _currentCustomer = Customers[selectedIndex];

                IdTextBox.Text = _currentCustomer.Id.ToString();
                IsPriorityCheckBox.Checked = _currentCustomer.IsPriority;
                AddressControl.Address = _currentCustomer.Address;

                foreach (IDiscount discount in _currentCustomer.Discounts)
                {
                    DiscountsListBox.Items.Add(discount.Info);
                }
                FullNameTextBox.Text = _currentCustomer.FullName;

                CustomersChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Добавить покупателя".
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            CustomersListBox.ClearSelected();
            CustomersListBox.SelectedIndex = -1;

            IdTextBox.Text = "";
            FullNameTextBox.Text = "";
            AddressControl.ClearForm();

            AddCustomerButton.Enabled = false;
            RemoveCustomerButton.Enabled = false;

            OkButton.Enabled = true;
            CancelButton.Enabled = true;

            FullNameTextBox.ReadOnly = false;
            AddressControl.Enabled = true;
            IsPriorityCheckBox.Enabled = true;
        }

        /// <summary>
        /// Обработчик изменения текста в текстовом поле полного имени клиента.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            int selectedIndex = CustomersListBox.SelectedIndex;
            if (selectedIndex != -1)
            {
                _currentCustomer.FullName = FullNameTextBox.Text;
                CustomersListBox.Items[selectedIndex] = $"{_currentCustomer.Id.ToString()}){_currentCustomer.FullName}";

                FullNameTextBox.Select(FullNameTextBox.Text.Length, 0);

                CustomersChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Обработчик изменения состояния чекбокса "Приоритет".
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void IsPriorityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                _currentCustomer.IsPriority = IsPriorityCheckBox.Checked;
                CustomersChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Добавить скидку".
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void AddPercentDiscountButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                DiscountCategoryForm discountCategoryForm = new DiscountCategoryForm();
                if (discountCategoryForm.ShowDialog() == DialogResult.OK)
                {
                    if (!_currentCustomer.Discounts.Any(d => d.Info == discountCategoryForm.Discount.Info))
                    {
                        _currentCustomer.Discounts.Add(discountCategoryForm.Discount);
                        DiscountsListBox.Items.Add(discountCategoryForm.Discount.Info);
                    }
                }
            }

            CustomersChanged?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Удалить процентную скидку".
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void RemovePercentDiscountButton_Click(object sender, EventArgs e)
        {
            int customersSelectedIndex = CustomersListBox.SelectedIndex;
            int discountSelectedIndex = DiscountsListBox.SelectedIndex;

            if (customersSelectedIndex != -1)
            {
                if (discountSelectedIndex != -1)
                {

                    if (_currentCustomer.Discounts[discountSelectedIndex] is not PointsDiscount)
                    {
                        _currentCustomer.Discounts.RemoveAt(discountSelectedIndex);
                        DiscountsListBox.Items.RemoveAt(discountSelectedIndex);
                    }
                }
            }

            CustomersChanged?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Обработчик нажатия кнопки "OK"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OkButton_Click(object sender, EventArgs e)
        {
                Customer customer = new Customer();
                customer.FullName = FullNameTextBox.Text;
                customer.IsPriority = IsPriorityCheckBox.Checked;

                customer.Address = new Address(AddressControl.Address.Index,
                                           AddressControl.Address.Country,
                                           AddressControl.Address.City,
                                           AddressControl.Address.Street,
                                           AddressControl.Address.Building,
                                           AddressControl.Address.Apartment);

                Customers.Add(customer);
                CustomersListBox.Items.Add($"{customer.Id.ToString()}){customer.FullName}");

                FullNameTextBox.Text = "";
                IsPriorityCheckBox.Checked = false;
                AddressControl.ClearForm();
                AddCustomerButton.Enabled = true;
                RemoveCustomerButton.Enabled = true;
                OkButton.Enabled = false;
                CancelButton.Enabled = false;

                CustomersChanged?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Cancel"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            CustomersListBox.SelectedIndex = -1;
            IdTextBox.Text = "";
            FullNameTextBox.Text = "";
            AddressControl.ClearForm();

            AddCustomerButton.Enabled = true;
            RemoveCustomerButton.Enabled = true;
            OkButton.Enabled = false;
            CancelButton.Enabled = false;
        }
    }
}
