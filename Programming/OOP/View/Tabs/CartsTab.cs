using OOP.Model;
using OOP.Model.Orders;

namespace OOP.View.Tabs
{
    public partial class CartsTab : UserControl
    {
        /// <summary>
        /// Список товаров текущей корзины.
        /// </summary>
        private Item _items;

        /// <summary>
        /// Текущий покупатель, владеющий корзиной.
        /// </summary>
        private Customer _currentCustomer;

        /// <summary>
        /// Получает или устанавливает список товаров.
        /// </summary>
        public List<Item> Items { get; set; }

        /// <summary>
        /// Получает или устанавливает список клиентов.
        /// </summary>
        public List<Customer> Customers { get; set; }

        /// <summary>
        /// Конструктор по умолчанию класса CartsTab.
        /// Инициализирует компоненты и отключает кнопку "Добавить в корзину".
        /// </summary>
        public CartsTab()
        {
            InitializeComponent();
            AddToCartButton.Enabled = false;
        }

        /// <summary>
        /// Обновляет данные в элементах управления списка товаров и клиентов.
        /// </summary>
        public void RefreshData()
        {
            if (Items != null)
            {
                ItemsListBox.Items.Clear();
                ItemsListBox.Items.AddRange(Items.ToArray());

            }
            if (Customers != null)
            {
                int selectedIndex=CustomersComboBox.SelectedIndex;
                CustomersComboBox.Items.Clear();
                CustomersComboBox.Items.AddRange(Customers.ToArray());
                CustomersComboBox.SelectedIndex=selectedIndex;

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
        /// Очищает метки суммы скидки и общей суммы.
        /// </summary>
        private void ClearDiscountAndTotalLabels()
        {
            DiscountAmountLabel.Text = "0";
            TotalLabel.Text = "0";
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
                IDiscount currentDiscount = _currentCustomer.Discounts[indexOfDiscount];
                discountAmount += (int)currentDiscount.Calculate(_currentCustomer.Cart.Items);
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

        /// <summary>
        /// Создает новый заказ и применяет скидки к текущему клиенту.
        /// </summary>
        /// <returns>Сумма скидки.</returns>
        private int CreateOrder()
        {
            int discountAmount = 0;
            ClearDiscountAndTotalLabels();
            if (_currentCustomer == null) return 0;
            foreach (int indexOfDiscount in DiscountCheckedListBox.CheckedIndices)
            {
                IDiscount currentDiscount = _currentCustomer.Discounts[indexOfDiscount];
                discountAmount += (int)currentDiscount.Apply(_currentCustomer.Cart.Items);
            }

            for (int indexOfDiscount = 0; indexOfDiscount < DiscountCheckedListBox.Items.Count; indexOfDiscount++)
            {
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

        /// <summary>
        /// Обновляет информацию о сумме товаров в корзине и отображает ее в AmountLabel.
        /// </summary>
        private void UpdateAmount()
        {
            if (_currentCustomer == null)
            {
                AmountLabel.Text = "0";
                return;
            }
            AmountLabel.Text = _currentCustomer.Cart.Amount.ToString();
        }

        /// <summary>
        /// Обработчик изменения выбранного клиента в комбобоксе.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void CustomersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersComboBox.SelectedIndex == -1)
            {
                AddToCartButton.Enabled = false;
                DiscountCheckedListBox.Items.Clear();
            }
            else
            {
                AddToCartButton.Enabled = true;
                CartListBox.Items.Clear();
                DiscountCheckedListBox.Items.Clear();

                _currentCustomer = Customers[CustomersComboBox.SelectedIndex];
                CartListBox.Items.AddRange(_currentCustomer.Cart.Items.ToArray());

                for (int i = 0; i < _currentCustomer.Discounts.Count; i++)
                {
                    DiscountCheckedListBox.Items.Add(_currentCustomer.Discounts[i].Info);
                    DiscountCheckedListBox.SetItemChecked(i, true);
                }

                UpdateAmount();
                UpdateDiscountAndTotalAmount();
            }
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Добавить в корзину".
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1)
            {
                return;
            }
            else
            {
                _currentCustomer.Cart.Items.Add((Item)ItemsListBox.SelectedItem);
                CartListBox.Items.Add(ItemsListBox.SelectedItem);
                ItemsListBox.SelectedIndex = -1;

                UpdateAmount();
                UpdateDiscountAndTotalAmount();
            }
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Удалить элемент".
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (CartListBox.SelectedIndex == -1)
            {
                return;
            }
            else
            {
                _currentCustomer.Cart.Items.RemoveAt(CartListBox.SelectedIndex);
                CartListBox.Items.RemoveAt(CartListBox.SelectedIndex);

                UpdateAmount();
                UpdateDiscountAndTotalAmount();
            }
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Очистить корзину".
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            ClearCart();
            UpdateAmount();
            UpdateDiscountAndTotalAmount();
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Создать заказ".
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            if (CartListBox.Items.Count == 0)
            {
                return; 
            }
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
                newOrder = new PriorityOrder(
                    OrderStatus.New,
                    Date,
                    items,
                    _currentCustomer.Address,
                    Convert.ToDouble(DiscountAmountLabel.Text),
                    DateTime.Now,
                    DeliveryTime.Range9To11);
            }
            else
            {
                newOrder = new Order(
                    OrderStatus.New,
                    Date,
                    items,
                    _currentCustomer.Address,
                    Convert.ToDouble(DiscountAmountLabel.Text));
            }

            _currentCustomer.Orders.Add(newOrder);

            CreateOrder();
            ClearDiscountAndTotalLabels();

            items.Clear();
            ClearCart();
            UpdateAmount();
        }

        /// <summary>
        /// Обработчик изменения выбранных скидок.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void DiscountCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDiscountAndTotalAmount();
        }

        /// <summary>
        /// Обработчик изменения выбранного значения в списке скидок.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void DiscountCheckedListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            UpdateDiscountAndTotalAmount();
        }
    }
}

