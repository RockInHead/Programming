using OOP.Model;
using OOP.View.Tabs;

namespace OOP
{
    public partial class MainFormOOP : Form
    {
        /// <summary>
        /// Конструктор класса MainFormOOP. 
        /// Инициализирует компоненты формы и связывает табы с данными из магазина.
        /// </summary>
        public MainFormOOP()
        {
            InitializeComponent();
            Store _store = new Store();
            ItemsTab.Items = _store.Items;
            CustomersTab.Customers = _store.Customers;

            СartsTab.Items = _store.Items;
            СartsTab.Customers = _store.Customers;

            OrdersTab.Customers= _store.Customers;
            ItemsTab.ItemsChanged += ItemsChanged;

            CustomersTab.CustomersChanged += CustomersChanged;
        }

        /// <summary>
        /// Обработчик события изменения элементов. Обновляет данные в корзине.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void ItemsChanged(object? sender, EventArgs e)
        {
            СartsTab.RefreshData();
        }

        /// <summary>
        /// Обработчик события изменения заказчиков. Обновляет данные в корзине.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void CustomersChanged(object? sender, EventArgs e)
        {
            СartsTab.RefreshData(); 
        }

        /// <summary>
        /// Обработчик изменения выбранного таба в контроле TabControl.
        /// Обновляет заказы при выборе соответствующего таба.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabControl.SelectedIndex == 3)
            {
                OrdersTab.UpdateOrders();
            }
        }

    }
}
