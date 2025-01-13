using OOP.Model.Orders;
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
    public partial class OrdersTab : UserControl
    {
        private List<Customer> _customers;
        private Customer _currentCustomer;
        private Order _currentOrder;
        private PriorityOrder _currentPriorityOrder;
        private List<Order> _orders = new List<Order>();
        private List<Order> _ordersCurrentCustomer = new List<Order>();

        /// <summary>
        /// Получает или задает список клиентов.
        /// </summary>
        public List<Customer> Customers { get; set; }

        DataTable dataTable = new DataTable();

        /// <summary>
        /// Обновляет список заказов в интерфейсе.
        /// </summary>
        public void UpdateOrders()
        {
            dataTable.Clear();
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
                    dataTable.Rows.Add(_currentCustomer.Orders[j].Id.ToString(), _currentCustomer.Orders[j].DateOfCreation, _currentCustomer.Orders[j].Status, _currentCustomer.FullName, _currentCustomer.Address.AddressToString(), _currentCustomer.Orders[j].Amount.ToString(), _currentCustomer.Orders[j].Total.ToString());
                }
            }
            OrdersDataGridView.DataSource = dataTable;
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
        /// Конструктор класса OrdersTab. Инициализирует компоненты интерфейса.
        /// </summary>
        public OrdersTab()
        {
            InitializeComponent();
            OrderStatusComboBox.Items.AddRange(Enum.GetValues(typeof(OrderStatus)).Cast<object>().ToArray());
            dataTable.Columns.Add("Id", typeof(string));
            dataTable.Columns.Add("Created", typeof(string));
            dataTable.Columns.Add("Status", typeof(string));
            dataTable.Columns.Add("Full Name", typeof(string));
            dataTable.Columns.Add("Address", typeof(string));
            dataTable.Columns.Add("Amount", typeof(string));
            dataTable.Columns.Add("Total", typeof(string));
            OrderStatusComboBox.Enabled = false;
            DeliveryTimeRangeComboBox.DataSource = Enum.GetValues(typeof(DeliveryTime)).Cast<DeliveryTime>().Select(range => new { Value = range, Display = GetDisplayName(range) }).ToList();
            DeliveryTimeRangeComboBox.DisplayMember = "Display";
            DeliveryTimeRangeComboBox.ValueMember = "Value";

            PriorityOrdersPanel.Enabled = false;
            PriorityOrdersPanel.Visible = false;
        }

        /// <summary>
        /// Обработчик изменения текущей ячейки в OrdersDataGridView.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void OrdersDataGridView_CurrentCellChanged(object sender, EventArgs e)
        {
            if (OrdersDataGridView.CurrentCell != null && OrdersDataGridView.CurrentCell.RowIndex != -1 && dataTable.Rows.Count != 0)
            {
                OrderItemsListBox.Items.Clear();

                _currentOrder = _ordersCurrentCustomer[OrdersDataGridView.CurrentCell.RowIndex];
                OrderIdTextBox.Text = _currentOrder.Id.ToString();
                OrderCreatedTextBox.Text = _currentOrder.DateOfCreation.ToString();
                OrderStatusComboBox.Text = _currentOrder.Status.ToString();

                //Закоментил это, когда правил AddressControl и CustomersTab. Поправить!
                /*addressControl1.ShowValues(_currentOrder.DeliveryAddress);*/

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
        }

        /// <summary>
        /// Обработчик изменения выбранного статуса заказа из комбобокса.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void OrderStatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OrdersDataGridView.CurrentCell.RowIndex != -1 && OrdersDataGridView.CurrentCell.RowIndex != null && OrdersDataGridView.Rows.Count != 0)
            {
                OrderStatusComboBox.Enabled = true;
                _currentOrder.Status = (OrderStatus)OrderStatusComboBox.SelectedItem;

                dataTable.Rows[OrdersDataGridView.CurrentCell.RowIndex][2] = _currentOrder.Status.ToString();
            }
        }

        /// <summary>
        /// Обработчик изменения выбранного диапазона доставки из комбобокса.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void DeliveryTimeRangeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_currentPriorityOrder == null) return;
            _currentPriorityOrder.DeliveryTimeRange = (DeliveryTime)DeliveryTimeRangeComboBox.SelectedValue;
        }
    }
}
