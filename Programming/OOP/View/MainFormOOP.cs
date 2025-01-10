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
            itemsTab1.Items = _store.Items;
            сustomersTab.Customers = _store.Customers;

            cartsTab1.Items = _store.Items;
            cartsTab1.Customers = _store.Customers;

            ordersTab1.Customers= _store.Customers;
            itemsTab1.ItemsChanged += ItemsChanged;

            сustomersTab.CustomersChanged += CustomersChanged;
        }

        /// <summary>
        /// Обработчик события изменения элементов. Обновляет данные в корзине.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void ItemsChanged(object? sender, EventArgs e)
        {
            cartsTab1.RefreshData();
          
        }

        /// <summary>
        /// Обработчик события изменения заказчиков. Обновляет данные в корзине.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void CustomersChanged(object? sender, EventArgs e)
        {
            cartsTab1.RefreshData(); 
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
                ordersTab1.UpdateOrders();
            }
        }

    }
}
