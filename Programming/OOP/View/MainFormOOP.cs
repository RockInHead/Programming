using OOP.Model;
using OOP.View.Tabs;

namespace OOP
{
    public partial class MainFormOOP : Form
    {
        /*/// <summary>
        /// Событие изменения товаров.
        /// </summary>
        public event EventHandler<EventArgs> ItemsChanged;*/


        public MainFormOOP()
        {
            InitializeComponent();
            Store _store = new Store();
            itemsTab1.Items = _store.Items;
            сustomersTab.Customers = _store.Customers;

            cartsTab1.Items = _store.Items;
            cartsTab1.Customers = _store.Customers;

            ordersTab1.Customers= _store.Customers;
            itemsTab1.ItemsChanged += ItemsChanged;
        }
        private void ItemsChanged(object? sender, EventArgs e)
        {
            //MessageBox.Show("????????!");
            cartsTab1.RefreshData();
            cartsTab1.RefreshData();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addressControl1_Load(object sender, EventArgs e)
        {

        }



        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabControl.SelectedIndex == 3)
            {

                ordersTab1.UpdateOrders();

            }
/*            else if (TabControl.SelectedIndex == 2)
            {*/

                cartsTab1.RefreshData();
/*            }*/
        }

    }
}
