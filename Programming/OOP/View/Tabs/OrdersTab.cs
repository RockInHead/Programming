using OOP.Model.Orders;
using System.Data;
using OOP.Model;

namespace OOP.View.Tabs
{
    public partial class OrdersTab : UserControl
    {
        /// <summary>
        /// Текущий покупатель.
        /// </summary>
        private Customer _currentCustomer;

        /// <summary>
        /// Текущий заказ.
        /// </summary>
        private Order _currentOrder;

        /// <summary>
        /// Текущий приоритетный заказ.
        /// </summary>
        private PriorityOrder _currentPriorityOrder;

        /// <summary>
        /// Заказы текущего покупателя.
        /// </summary>
        private List<Order> _ordersCurrentCustomer = new List<Order>();

        /// <summary>
        /// Текущая таблица, которую будем запонять значениями.
        /// </summary>
        private DataTable _dataTable = new DataTable();

        /// <summary>
        /// Получает или задает список покупателей.
        /// </summary>
        public List<Customer> Customers { get; set; }

        /// <summary>
        /// Конструктор класса OrdersTab.
        /// Инициализирует компоненты интерфейса.
        /// </summary>
        public OrdersTab()
        {
            InitializeComponent();
            OrderStatusComboBox.Items.AddRange(Enum.GetValues(typeof(OrderStatus))
                                                        .Cast<object>().ToArray());

            _dataTable.Columns.Add("Id", typeof(string));
            _dataTable.Columns.Add("Created", typeof(string));
            _dataTable.Columns.Add("Status", typeof(string));
            _dataTable.Columns.Add("Full Name", typeof(string));
            _dataTable.Columns.Add("Address", typeof(string));
            _dataTable.Columns.Add("Amount", typeof(string));
            _dataTable.Columns.Add("Total", typeof(string));
            OrderStatusComboBox.Enabled = false;
            DeliveryTimeRangeComboBox.DataSource = Enum.GetValues(typeof(DeliveryTime))
                                                                  .Cast<DeliveryTime>()
                                                                  .Select(range => new { Value = range, Display = GetDisplayName(range) })
                                                                  .ToList();

            DeliveryTimeRangeComboBox.DisplayMember = "Display";
            DeliveryTimeRangeComboBox.ValueMember = "Value";

            PriorityOrdersPanel.Enabled = false;
            PriorityOrdersPanel.Visible = false;
        }

        /// <summary>
        /// Обновляет список заказов в интерфейсе.
        /// </summary>
        public void UpdateOrders()
        {
            _dataTable.Clear();
            foreach (DataGridViewColumn column in OrdersDataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            _ordersCurrentCustomer.Clear();
            for (int i = 0; i < Customers.Count; i++)
            {
                _currentCustomer = Customers[i];

                for (int j = 0; j < _currentCustomer.Orders.Count; j++)
                {
                    _ordersCurrentCustomer.Add(_currentCustomer.Orders[j]);
                    _dataTable.Rows.Add(_currentCustomer.Orders[j].Id.ToString(),
                                        _currentCustomer.Orders[j].DateOfCreation,
                                        _currentCustomer.Orders[j].Status,
                                        _currentCustomer.FullName,
                                        _currentCustomer.Address.AddressToString(),
                                        _currentCustomer.Orders[j].Amount.ToString(),
                                        _currentCustomer.Orders[j].Total.ToString());
                }
            }

            OrdersDataGridView.DataSource = _dataTable;
            OrdersDataGridView.Columns[0].Width = 30;
        }

        /// <summary>
        /// Получить выбранный диапазон в удобном формате.
        /// </summary>
        /// <param name="range">Выбранный диапазон.</param>
        /// <returns>Строка в которой написаны диапазоны в удобном формате.</returns>
        private string GetDisplayName(DeliveryTime range)
        {
            switch (range)
            {
                case DeliveryTime.Range9To11:
                    return "9:00 – 11:00";
                case DeliveryTime.Range11To13:
                    return "11:00 – 13:00";
                case DeliveryTime.Range13To15:
                    return "13:00 – 15:00";
                case DeliveryTime.Range15To17:
                    return "15:00 – 17:00";
                case DeliveryTime.Range17To19:
                    return "17:00 – 19:00";
                case DeliveryTime.Range19To21:
                    return "19:00 – 21:00";
                default:
                    return string.Empty;
            }
        }

        /// <summary>
        /// Обработчик изменения текущей ячейки в OrdersDataGridView.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void OrdersDataGridView_CurrentCellChanged(object sender, EventArgs e)
        {
            if (OrdersDataGridView.CurrentCell == null ||
                OrdersDataGridView.CurrentCell.RowIndex == -1 ||
                _dataTable.Rows.Count == 0)
            {
                return; 
            }

            OrderItemsListBox.Items.Clear();

            _currentOrder = _ordersCurrentCustomer[OrdersDataGridView.CurrentCell.RowIndex];
            OrderIdTextBox.Text = _currentOrder.Id.ToString();
            OrderCreatedTextBox.Text = _currentOrder.DateOfCreation.ToString();
            OrderStatusComboBox.Text = _currentOrder.Status.ToString();

            OrdersAddressControl.Address = new Address(_currentOrder.DeliveryAddress.Index,
                                                       _currentOrder.DeliveryAddress.Country,
                                                       _currentOrder.DeliveryAddress.City,
                                                       _currentOrder.DeliveryAddress.Street,
                                                       _currentOrder.DeliveryAddress.Apartment,
                                                       _currentOrder.DeliveryAddress.Building);

            OrderItemsListBox.Items.AddRange(_currentOrder.Items.ToArray());
            AmountLabel.Text = _currentOrder.Amount.ToString();
            TotalLabel.Text = _currentOrder.Total.ToString();

            if (_currentOrder.GetType() == typeof(PriorityOrder))
            {
                PriorityOrdersPanel.Enabled = true;
                PriorityOrdersPanel.Visible = true;
                _currentPriorityOrder = (PriorityOrder)_currentOrder;
                DeliveryTimeRangeComboBox.Text = GetDisplayName(_currentPriorityOrder.DeliveryTimeRange);
            }
            else
            {
                PriorityOrdersPanel.Enabled = false;
                PriorityOrdersPanel.Visible = false;
            }
        }

        /// <summary>
        /// Обработчик изменения выбранного статуса заказа из комбобокса.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void OrderStatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OrdersDataGridView.CurrentCell.RowIndex == -1 ||
                OrdersDataGridView.CurrentCell == null ||
                OrdersDataGridView.Rows.Count == 0)
            {
                return; 
            }

            OrderStatusComboBox.Enabled = true;
            _currentOrder.Status = (OrderStatus)OrderStatusComboBox.SelectedItem;

            int dataGridRowIndex = OrdersDataGridView.CurrentCell.RowIndex;
            _dataTable.Rows[dataGridRowIndex][2] = _currentOrder.Status.ToString();
        }

        /// <summary>
        /// Обработчик изменения выбранного диапазона доставки из комбобокса.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void DeliveryTimeRangeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_currentPriorityOrder == null)
            {
                return;
            }
            _currentPriorityOrder.DeliveryTimeRange = (DeliveryTime)DeliveryTimeRangeComboBox.SelectedValue;
        }
    }
}
