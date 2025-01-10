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
            itemsTab1.Items = _store.Items;
            �ustomersTab.Customers = _store.Customers;

            cartsTab1.Items = _store.Items;
            cartsTab1.Customers = _store.Customers;

            ordersTab1.Customers= _store.Customers;
            itemsTab1.ItemsChanged += ItemsChanged;

            �ustomersTab.CustomersChanged += CustomersChanged;
        }

        /// <summary>
        /// ���������� ������� ��������� ���������. ��������� ������ � �������.
        /// </summary>
        /// <param name="sender">�������� �������.</param>
        /// <param name="e">��������� �������.</param>
        private void ItemsChanged(object? sender, EventArgs e)
        {
            cartsTab1.RefreshData();
          
        }

        /// <summary>
        /// ���������� ������� ��������� ����������. ��������� ������ � �������.
        /// </summary>
        /// <param name="sender">�������� �������.</param>
        /// <param name="e">��������� �������.</param>
        private void CustomersChanged(object? sender, EventArgs e)
        {
            cartsTab1.RefreshData(); 
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
                ordersTab1.UpdateOrders();
            }
        }

    }
}
