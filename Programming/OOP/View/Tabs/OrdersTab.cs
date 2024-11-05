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
        public List<Customer> Customers { get; set; }
        DataTable dataTable = new DataTable();

        public void UpdateOrders()
        {
            /*                if (dataTable.Rows.Count <= 0)
                            {

                            }*/
            /*            dataTable.Rows.Clear();*/
            dataTable.Clear();
            foreach (DataGridViewColumn column in OrdersDataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            /*            _orders.Clear();*/
            _ordersCurrentCustomer.Clear();
            for (int i = 0; i < Customers.Count; i++)
            {
                _currentCustomer = Customers[i];

                for (int j = 0; j < _currentCustomer.Orders.Count; j++)
                {
                    _ordersCurrentCustomer.Add(_currentCustomer.Orders[j]);
                    dataTable.Rows.Add(_currentCustomer.Orders[j].Id.ToString(), _currentCustomer.Orders[j].DateOfCreation, _currentCustomer.Orders[j].Status, _currentCustomer.FullName, _currentCustomer.Address.AddressToString(), _currentCustomer.Orders[j].Amount.ToString());
                }
/*                _orders.AddRange(_ordersCurrentCustomer);*/
/*                _ordersCurrentCustomer.Clear()*/;
            }
            OrdersDataGridView.DataSource = dataTable;
            OrdersDataGridView.Columns[0].Width = 30;
        }
        /// <summary>
        /// Получить выбранный диапазон в удобном формате.
        /// </summary>
        /// <param name="range">Выбранный диапазон.</param>
        /// <returns>Строка в которой написаны диапазоны в удобном формате.</returns>
        private string GetDisplayName(DeliveryTimeRange range)
        {
            switch (range)
            {
                case DeliveryTimeRange.Range9To11:
                    return "9:00 – 11:00";
                case DeliveryTimeRange.Range11To13:
                    return "11:00 – 13:00";
                case DeliveryTimeRange.Range13To15:
                    return "13:00 – 15:00";
                case DeliveryTimeRange.Range15To17:
                    return "15:00 – 17:00";
                case DeliveryTimeRange.Range17To19:
                    return "17:00 – 19:00";
                case DeliveryTimeRange.Range19To21:
                    return "19:00 – 21:00";
                default:
                    return string.Empty;
            }
        }
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
            OrderStatusComboBox.Enabled = false;
            DeliveryTimeRangeComboBox.DataSource = Enum.GetValues(typeof(DeliveryTimeRange)).Cast<DeliveryTimeRange>().Select(range => new { Value = range, Display = GetDisplayName(range) }).ToList();
            DeliveryTimeRangeComboBox.DisplayMember = "Display";
            DeliveryTimeRangeComboBox.ValueMember = "Value";


            PriorityOrdersPanel.Enabled = false;
            PriorityOrdersPanel.Visible = false;

            /*            addressControl1 = new AddressControl();*/

            /*DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Id", typeof(string));
            dataTable.Columns.Add("Created", typeof(string));
            dataTable.Columns.Add("Status", typeof(string));
            dataTable.Columns.Add("Full Name", typeof(string));
            dataTable.Columns.Add("Address", typeof(string));
            dataTable.Columns.Add("Amount", typeof(string));

            OrdersDataGridView.DataSource = dataTable;*/

            /*            for (int i = 1; i <= 10; i++)
                        {
                            dataTable.Columns.Add($"A{i}");


                        }

                        for (int i = 1; i <= 5; i++)
                        {
                            dataTable.Rows.Add($"Эксперт{i}");
                        }
                        dataTable.Rows.Add("Сумма рангов");
                        dataTable.Rows.Add($"Обобщенный ранг");
                        dataTable.Rows[1][1] = "1234";
                        *//*dataTable.Rows.InsertAt(dataTable.Rows[2], 3);*//*

                        ExpertsDataGridView.DataSource = dataTable;
                        ExpertsDataGridView.Columns[0].Width = 160;
                        for (int i = 1; i <= 10; i++)
                        {
                            ExpertsDataGridView.Columns[i].Width = 36;
                        }*/
        }

        private void OrdersDataGridView_CurrentCellChanged(object sender, EventArgs e)
        {
            if (OrdersDataGridView.CurrentCell != null && OrdersDataGridView.CurrentCell.RowIndex != -1 && dataTable.Rows.Count != 0)
            {
                OrderItemsListBox.Items.Clear();
                /*                _currentOrder = _orders[OrdersDataGridView.CurrentCell.RowIndex];*/
                _currentOrder = _ordersCurrentCustomer[OrdersDataGridView.CurrentCell.RowIndex];
                /*                PriorityOrder _currentPriorityOrder = (PriorityOrder)_currentOrder;*/
                OrderIdTextBox.Text = _currentOrder.Id.ToString();
                OrderCreatedTextBox.Text = _currentOrder.DateOfCreation.ToString();
                OrderStatusComboBox.Text = _currentOrder.Status.ToString();
                addressControl1.ShowValues(_currentOrder.DeliveryAddress);

                OrderItemsListBox.Items.AddRange(_currentOrder.Items.ToArray());
                AmountLabel.Text = _currentOrder.Amount.ToString();

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

        private void OrderStatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OrdersDataGridView.CurrentCell.RowIndex != -1 && OrdersDataGridView.CurrentCell.RowIndex != null && OrdersDataGridView.Rows.Count != 0)
            {
                OrderStatusComboBox.Enabled = true;
                _currentOrder.Status = (OrderStatus)OrderStatusComboBox.SelectedItem;

                dataTable.Rows[OrdersDataGridView.CurrentCell.RowIndex][2] = _currentOrder.Status.ToString();
                /*UpdateOrders();*/
                /*OrdersDataGridView.Rows[1].Cells[1].Value = "12";*/
                /*             CartListBox.Items.Clear();
                             _currentCustomer = Customers[CustomersComboBox.SelectedIndex];
                             *//*                if (_currentCustomer.Cart.Items != null)
                                             {*//*
                             CartListBox.Items.AddRange(_currentCustomer.Cart.Items.ToArray());
                             *//*                }*//*
                             UpdateAmount();*/
            }
        }

        private void DeliveryTimeRangeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_currentPriorityOrder == null) return;
            _currentPriorityOrder.DeliveryTimeRange = (DeliveryTimeRange)DeliveryTimeRangeComboBox.SelectedValue;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
