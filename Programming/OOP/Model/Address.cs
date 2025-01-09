using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Model
{
    /// <summary>
    /// Хранит данные о адресе: почтовый индекс, старну, город, улицу, дом и квартиру.
    /// </summary>
    public class Address:ICloneable
    {
        
        private int _index;
        private string _country;
        private string _city;
        private string _street;
        private string _building;
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
            get { return _index; }

            set
            {
                if (value.ToString().Length != 6)
                {
                    throw new Exception("Полная хуйня!");
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
            get { return _country; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 50, "Country");
                _country = value;
                AddressChanged?.Invoke(this, EventArgs.Empty);
            }
        }
        /// <summary>
        /// Город.
        /// </summary>
        public string City
        {
            get { return _city; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 50, "City");
                _city = value;
                AddressChanged?.Invoke(this, EventArgs.Empty);
            }
        }
        /// <summary>
        /// Улица.
        /// </summary>
        public string Street
        {
            get { return _street; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 100, "Street");

                _street = value;
                AddressChanged?.Invoke(this, EventArgs.Empty);
            }
        }
        /// <summary>
        /// Номер дома.
        /// </summary>
        public string Building
        {
            get { return _building; }
            set
            {
                try
                {
                    ValueValidator.AssertStringOnLength(value, 10, "Building");

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
                ValueValidator.AssertStringOnLength(value, 10, "Apartment");
                _apartment = value;
                AddressChanged?.Invoke(this, EventArgs.Empty);
            }
        }
        /// <summary>
        /// Создает пустой экземляр класса.
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
        /// Создает новый экземпляр класса.
        /// </summary>
        /// <param name="index">Почтовый индекс. 6 символов.</param>
        /// <param name="country">Страна. Не более 50 символов.</param>
        /// <param name="city">Город. Не более 50 символов.</param>
        /// <param name="street">Улица. Не более 100 символов.</param>
        /// <param name="building">Номер дома. Не более 10 символов.</param>
        /// <param name="apartment">Номер квартиры/помещения. Не более 10 символов</param>
        public Address(int index, string country, string city, string street, string building, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
            
        }
        public string AddressToString()
        {
            return Index.ToString()+" "+Country+" "+City+" "+Street+" "+Building+" "+Apartment;
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
                return false;
            if (other is not Address)
                return false;
            if (object.ReferenceEquals(this, other))
                return true;
            Address address = (Address)other;
            return (this.Index == address.Index && this.Country == address.Country && this.City == address.City && this.Street == address.Street && this.Building== address.Building && this.Apartment== address.Apartment);
        }

    }
}

