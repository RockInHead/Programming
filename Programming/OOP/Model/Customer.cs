using OOP.Model;
using OOP.Model.Discounts;
using OOP.Model.Orders;

namespace OOP
{
    /// <summary>
    /// Хранит данные о покупателе:Уникальный ID, Полное ФИО, Адрес.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Уникальный ID покупателя.
        /// </summary>
        private int _id;

        /// <summary>
        /// Статическое значение количества всех экзепляров покупателей.
        /// </summary>
        private static int _allCustomersCount;

        /// <summary>
        /// Полное ФИО покупателя.
        /// </summary>
        private string _fullname;

        /// <summary>
        /// Адрес покупателя.
        /// </summary>
        private Address _address;

        /// <summary>
        /// Представляет корзину покупок для покупателя.
        /// </summary>
        private Cart _cart;

        /// <summary>
        /// Содержит список заказов, сделанных покупателем.
        /// </summary>
        private List<Order> _orders;

        /// <summary>
        /// Список доступных скидок, которые могут быть применены к заказам.
        /// </summary>
        private List<IDiscount> _discounts;

        /// <summary>
        /// Возвращает значение о количестве всех экземплярах класса.
        /// </summary>
        public int AllCustomersCount
        {
            get
            {
                return _allCustomersCount;
            }
        }

        /// <summary>
        /// Возвращает уникальный ID товара.
        /// </summary>
        public int Id
        {
            get
            {
                return _id;
            }
        }

        /// <summary>
        /// Возвращает и задает полное ФИО покупателя.
        /// </summary>
        public string FullName
        {
            get
            {
                return _fullname;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, nameof(FullName));
                _fullname = value;
            }
        }

        /// <summary>
        /// Возвращает и задает адрес покупателя.
        /// </summary>
        public Address Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }
        }

        /// <summary>
        /// Возвращает и задает текущую корзину покупателя.
        /// </summary>
        public Cart Cart { get; set; }

        /// <summary>
        /// Возвращает и задает список заказов покупателя.
        /// </summary>
        public List<Order> Orders { get; set; }

        /// <summary>
        /// Возвращает или меняет приоритет клиента.
        /// </summary>
        public bool IsPriority { get; set; }

        /// <summary>
        /// Возвращает и задает список доступных скидок.
        /// </summary>
        public List<IDiscount> Discounts { get; set; }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Customer"/>.
        /// </summary>
        /// <remarks>
        /// Устанавливает значения по умолчанию для покупателя:имя, адрес.
        /// Cоздает новую корзину, 
        /// инициализирует пустые списки заказов и скидок, 
        /// а также присваивает уникальный идентификатор покупателю.
        /// </remarks>
        public Customer()
        {
            FullName = "None";
            Address = new Address();
            Cart = new Cart();
            Orders = new List<Order>();
            Discounts = new List<IDiscount>();
            Discounts.Add(new PointsDiscount());
            _allCustomersCount += 1;
            _id = _allCustomersCount;
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Customer"/> с заданным полным именем.
        /// </summary>
        /// <param name="fullname">Полное имя клиента.</param>
        /// <remarks>
        /// Устанавливает полное имя клиента переданным значением.
        /// Инициализирует адрес, корзину, 
        /// пустые списки заказов и скидок,
        /// а также присваивает уникальный идентификатор клиенту.
        /// </remarks>
        public Customer(string fullname)
        {
            FullName = fullname;
            Address = new Address();
            Cart = new Cart();
            Orders = new List<Order>();
            Discounts = new List<IDiscount>();
            Discounts.Add(new PointsDiscount());
            _allCustomersCount += 1;
            _id = _allCustomersCount;
        }

        /// <summary>
        /// Возвращает строковое представление экземпляра покупателя.
        /// </summary>
        /// <returns>Полное имя клиента.</returns>
        public override string ToString()
        {
            return FullName;
        }
    }
}

