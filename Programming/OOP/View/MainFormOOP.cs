using OOP.Model;
using OOP.View.Tabs;

namespace OOP
{
    public partial class MainFormOOP : Form
    {

        public MainFormOOP()
        {
            InitializeComponent();
            Store _store = new Store();
            itemsTab1.Items = _store.Items;
            ñustomersTab.Customers = _store.Customerss;

            cartsTab1.Items = _store.Items;
            cartsTab1.Customers = _store.Customerss;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addressControl1_Load(object sender, EventArgs e)
        {

        }



        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

            cartsTab1.RefreshData();

        }
    }
}
