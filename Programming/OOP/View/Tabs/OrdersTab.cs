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
        public List<Customer> Customers { get; set; }
        public void UpdateOrders()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Id", typeof(string));
            dataTable.Columns.Add("Created", typeof(string));
            dataTable.Columns.Add("Status", typeof(string));
            dataTable.Columns.Add("Full Name", typeof(string));
            dataTable.Columns.Add("Address", typeof(string));
            dataTable.Columns.Add("Amount", typeof(string));
            foreach (DataGridViewColumn column in OrdersDataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            for (int i = 0;i<Customers.Count;i++)
            {
                _currentCustomer = Customers[i];
                for(int j = 0; j <_currentCustomer.Orders.Count; j++)
                {
                    dataTable.Rows.Add(_currentCustomer.Id, _currentCustomer.Orders[j].DateOfCreation, _currentCustomer.Orders[j].Status, _currentCustomer.FullName, _currentCustomer.Address.AddressToString(), _currentCustomer.Orders[j].TotalCost.ToString());
                }
            }
            OrdersDataGridView.DataSource = dataTable;
        }
        public OrdersTab()
        {
            InitializeComponent();
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

    }
}
