namespace OOP.Model
{
    /// <summary>
    /// Хранит данные о адресе.
    /// </summary>
    public class Address:ICloneable
    {
        /// <summary>
        /// Индекс адреса.
        /// </summary>
        private int _index;

        /// <summary>
        /// Страна, в которой находится адрес.
        /// </summary>
        private string _country;

        /// <summary>
        /// Город, в котором находится адрес.
        /// </summary>
        private string _city;

        /// <summary>
        /// Улица, на которой расположен адрес.
        /// </summary>
        private string _street;

        /// <summary>
        /// Номер здания, на котором расположен адрес.
        /// </summary>
        private string _building;

        /// <summary>
        /// Номер квартиры или офиса в здании.
        /// </summary>
        private string _apartment;

        /// <summary>
        /// Событие изменения адреса.
        /// </summary>
        public event EventHandler<EventArgs> AddressChanged;

        /// <summary>
        /// Почтовый индекс.
        /// </summary>
        public int Index
        {
            get 
            { 
                return _index; 
            }
            set
            {
                if (value.ToString().Length != 6)
                {
                    throw new Exception("Incorrect index! Maximum of 6 characters");
                }
                
                _index = value;
                AddressChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Страна/Регион.
        /// </summary>
        public string Country
        {
            get
            {
                return _country;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 50, nameof(Country));
                _country = value;
                AddressChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Город.
        /// </summary>
        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 50, nameof(City));
                _city = value;
                AddressChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Улица.
        /// </summary>
        public string Street
        {
            get
            {
                return _street;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 100, nameof(Street));
                _street = value;
                AddressChanged?.Invoke(this, EventArgs.Empty);
            }
        }
        /// <summary>
        /// Номер дома.
        /// </summary>
        public string Building
        {
            get 
            { 
                return _building; 
            }
            set
            {
                try
                {
                    ValueValidator.AssertStringOnLength(value, 10, nameof(Building));

                    _building = value;
                    AddressChanged?.Invoke(this, EventArgs.Empty);
                }
                catch (Exception ex)
                {
                    throw new Exception();
                }
            }
        }

        /// <summary>
        /// Номер квартиры/помещения.
        /// </summary>
        public string Apartment
        {
            get { return _apartment; }

            set
            {
                ValueValidator.AssertStringOnLength(value, 10, nameof(Apartment));
                _apartment = value;
                AddressChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Конструктор класса Address. 
        /// Инициализирует поля значениями по умолчанию.
        /// Index устанавливается в 111111.
        /// Country, City, Street, Building, Apartment в пустую строку "".
        /// </summary>
        public Address()
        {
            Index = 111111;
            Country = "";
            City = "";
            Street = "";
            Building = "";
            Apartment = "";
        }

        /// <summary>
        /// Конструктор Address с параметрами.
        /// Инициализирует новый адрес с указанными значениями.
        /// </summary>
        /// <param name="index">Индекс адреса.</param>
        /// <param name="country">Страна.</param>
        /// <param name="city">Город.</param>
        /// <param name="street">Улица.</param>
        /// <param name="building">Здание.</param>
        /// <param name="apartment">Квартира.</param>
        public Address(int index, string country, string city, string street, string building, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment; 
        }

        /// <summary>
        /// Преобразует объект адреса в строковое представление.
        /// </summary>
        /// <returns>Строка, содержащая индекс, страну, город, улицу, здание и квартиру, разделенные пробелами.</returns>
        public string AddressToString()
        {
            return $"{Index} {Country} {City} {Street} {Building} {Apartment}";
        }

        /// <summary>
        /// Делает копию объекта по всем полям.
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return new Address(this.Index, this.Country, this.City, this.Street,this.Building,this.Apartment);
        }

        /// <summary>
        /// Объекты равны тогда, когда у них равны все поля.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public override bool Equals(object other)
        {
            if (other == null) 
            {
                return false;

            }

            if (other is not Address) 
            { 
                return false;
            }

            if (object.ReferenceEquals(this, other))
            {
                return true;
            }

            Address address = (Address)other;
            return (this.Index == address.Index && 
                this.Country == address.Country && 
                this.City == address.City && 
                this.Street == address.Street && 
                this.Building== address.Building && 
                this.Apartment== address.Apartment);
        }
    }
}

