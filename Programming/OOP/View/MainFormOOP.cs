using OOP.Model;
using OOP.View.Tabs;

namespace OOP
{
    public partial class MainFormOOP : Form
    {
        /// <summary>
        /// ����������� ������ MainFormOOP. 
        /// �������������� ���������� ����� � ��������� ���� � ������� �� ��������.
        /// </summary>
        public MainFormOOP()
        {
            InitializeComponent();
            Store _store = new Store();
            ItemsTab.Items = _store.Items;
            CustomersTab.Customers = _store.Customers;

            �artsTab.Items = _store.Items;
            �artsTab.Customers = _store.Customers;

            OrdersTab.Customers= _store.Customers;
            ItemsTab.ItemsChanged += ItemsChanged;

            CustomersTab.CustomersChanged += CustomersChanged;
        }

        /// <summary>
        /// ���������� ������� ��������� ���������. ��������� ������ � �������.
        /// </summary>
        /// <param name="sender">�������� �������.</param>
        /// <param name="e">��������� �������.</param>
        private void ItemsChanged(object? sender, EventArgs e)
        {
            �artsTab.RefreshData();
        }

        /// <summary>
        /// ���������� ������� ��������� ����������. ��������� ������ � �������.
        /// </summary>
        /// <param name="sender">�������� �������.</param>
        /// <param name="e">��������� �������.</param>
        private void CustomersChanged(object? sender, EventArgs e)
        {
            �artsTab.RefreshData(); 
        }

        /// <summary>
        /// ���������� ��������� ���������� ���� � �������� TabControl.
        /// ��������� ������ ��� ������ ���������������� ����.
        /// </summary>
        /// <param name="sender">�������� �������.</param>
        /// <param name="e">��������� �������.</param>
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabControl.SelectedIndex == 3)
            {
                OrdersTab.UpdateOrders();
            }
        }

    }
}
