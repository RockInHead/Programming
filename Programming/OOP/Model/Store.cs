using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Model
{
    /// <summary>
    /// Хранит данные о списке товаров и списке покупателей.
    /// </summary>
    internal class Store
    {
        /// <summary>
        /// Список товаров.
        /// </summary>
        private List<Item> _items;
        /// <summary>
        /// Список покупателей.
        /// </summary>
        private List<Customer> _customers;

        /// <summary>
        /// Возвращает и задает список товаров.
        /// </summary>
        public List<Item> Items { get; set; }
        /// <summary>
        /// Возвращает и задает список покупателей.
        /// </summary>
        public List<Customer> Customers { get; set; }
        /// <summary>
        /// Создает пустой/начальный экземпляр класса.Всем полям присваивается значение по умолчанию.
        /// </summary>
        public Store()
        {
            Items = new List<Item>();
            Customers = new List<Customer>();
            
        }


    }
}
