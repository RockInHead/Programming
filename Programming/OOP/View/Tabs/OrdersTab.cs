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
    public partial class OrdersTab : UserControl
    {
        private List<Customer> _customers;
        private Customer _currentCustomer;
        private Order _currentOrder;
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
                    dataTable.Rows.Add(_currentCustomer.Orders[j].Id.ToString(), _currentCustomer.Orders[j].DateOfCreation, _currentCustomer.Orders[j].Status, _currentCustomer.FullName, _currentCustomer.Address.AddressToString(), _currentCustomer.Orders[j].TotalCost.ToString());
                }
/*                _orders.AddRange(_ordersCurrentCustomer);*/
/*                _ordersCurrentCustomer.Clear()*/;
            }
            OrdersDataGridView.DataSource = dataTable;
            OrdersDataGridView.Columns[0].Width = 30;
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
            if (OrdersDataGridView.CurrentCell != null && OrdersDataGridView.CurrentCell.RowIndex != -1)
            {

                /*                AmountLabel.Text = OrdersDataGridView.CurrentCell.RowIndex;*/
                /*                _currentCustomer = Customers[Customers];*/
                /*                _currentOrder = _currentCustomer.Orders[_currentCustomer.Orders.IndexOf(OrdersDataGridView.CurrentCell.RowIndex)];*/
                /*_currentOrder = Customers.Orders[OrdersDataGridView.CurrentCell.RowIndex.ToString()];*/

                /*                addressControl1.ClearForm();*/

                OrderItemsListBox.Items.Clear();
                /*                _currentOrder = _orders[OrdersDataGridView.CurrentCell.RowIndex];*/
                _currentOrder = _ordersCurrentCustomer[OrdersDataGridView.CurrentCell.RowIndex];
                OrderIdTextBox.Text = _currentOrder.Id.ToString();
                OrderCreatedTextBox.Text = _currentOrder.DateOfCreation.ToString();
                OrderStatusComboBox.Text = _currentOrder.Status.ToString();
                addressControl1.ShowValues(_currentOrder.DeliveryAddress);

                OrderItemsListBox.Items.AddRange(_currentOrder.Items.ToArray());
                AmountLabel.Text = _currentOrder.TotalCost.ToString();
            }
        }

        private void OrderStatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OrdersDataGridView.CurrentCell.RowIndex != -1 && OrdersDataGridView.CurrentCell.RowIndex != null && OrdersDataGridView.Rows.Count != 0)
            {
                _currentOrder.Status= (OrderStatus)OrderStatusComboBox.SelectedItem;

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
    }
}
