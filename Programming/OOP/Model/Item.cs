namespace OOP
{
    /// <summary>
    /// Хранит данные о товаре:Уникальный ID, имя товара, описание товара, стоимость товара, категорию товара.
    /// </summary>
    public class Item : ICloneable, IComparable<Item>
    {
        /// <summary>
        /// Уникальный ID товара.
        /// </summary>
        private int _id;

        /// <summary>
        /// Статическое значение количества всех экзепляров товаров.
        /// </summary>
        private static int _allItemsCount;

        /// <summary>
        /// Имя товара.
        /// </summary>
        private string _name;

        /// <summary>
        /// Описание товара.
        /// </summary>
        private string _info;

        /// <summary>
        /// Стоимость товара.
        /// </summary>
        private double _cost;

        /// <summary>
        /// Категория товара.
        /// </summary>
        private Category _category;

        /// <summary>
        /// Возвращает значение о количестве всех экземпляров класса.
        /// </summary>
        public int AllItemsCount
        {
            get
            {
                return _allItemsCount;
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
        /// Событие изменения названия товара.
        /// </summary>
        public event EventHandler<EventArgs> NameChanged;

        /// <summary>
        /// Событие изменения описания товара.
        /// </summary>
        public event EventHandler<EventArgs> InfoChanged;

        /// <summary>
        /// Событие изменения стоимости товара.
        /// </summary>
        public event EventHandler<EventArgs> CostChanged;

        /// <summary>
        /// Возвращает и задает имя товара.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, nameof(Name));
                _name = value;
                NameChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Возвращает и задает описание товара.
        /// </summary>
        public string Info
        {
            get
            {
                return _info;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 1000, nameof(Info));
                _info = value;
                InfoChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Возвращает и задает стоимость товара.
        /// </summary>
        public double Cost
        {
            get
            {
                return _cost;
            }
            set
            {
                if (value < 100000 && value >= 0)
                {
                    _cost = value;
                    CostChanged?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    throw new Exception("Cost должно быть от 0 до 100000");
                }
            }
        }

        /// <summary>
        /// Возвращает и задает категорию товара.
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Item"/>.
        /// Устанавливает значения по умолчанию для свойств.
        /// </summary>
        public Item()
        {
            Name = "None";
            Info = "None";
            Cost = 0;

            _allItemsCount += 1;
            _id = _allItemsCount;
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Item"/> с заданными значениями.
        /// </summary>
        /// <param name="name">Имя предмета.</param>
        /// <param name="info">Информация о предмете.</param>
        /// <param name="cost">Стоимость предмета.</param>
        /// <param name="category">Категория предмета.</param>
        public Item(string name, string info, double cost, Category category)
        {
            Name = name;
            Info = info;
            Cost = cost;
            Category = category;

            _allItemsCount += 1;
            _id = _allItemsCount;
        }

        /// <summary>
        /// Возвращает строковое представление данного экземпляра, представляя его наименование.
        /// </summary>
        /// <returns>Наименование товара.</returns>
        public override string ToString()
        {
            return Name;
        }

        /// <summary>
        /// Делает копию объекта по всем полям, кроме ID.
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return new Item(this.Name, this.Info, this.Cost, this.Category);
        }

        /// <summary>
        /// Объекты равны тогда, когда у них равны все поля кроме ID.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public override bool Equals(object other)
        {
            if (other == null) 
            { 
                return false;
            }

            if (other is not Item)
            {
                return false;
            }

            if (object.ReferenceEquals(this, other))
            {
                return true;
            }

            Item item = (Item)other;
            return (this.Name == item.Name &&
                this.Info == item.Info &&
                this.Cost == item.Cost &&
                this.Category == item.Category);
        }

        /// <summary>
        /// Сравнивает стоимость текущего товара с другим.
        /// </summary>
        /// <param name="other">Товар, с которым производится сравнение.</param>
        /// <returns>
        /// Возвращает 0, если стоимость текущего товара равна other; 
        /// 1, если стоимость текущего товара больше other; 
        /// -1, если стоимость текущего товара меньше other.
        /// </returns>
        public int CompareTo(Item? other)
        {
            if (object.ReferenceEquals(this, other))
            {
                return 0;
            }

            return Cost.CompareTo(other.Cost);
        }
    }
}

