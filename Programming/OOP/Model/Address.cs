using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Model
{
    public class Address:ICloneable
    {
        
        private int _index;
        private string _country;
        private string _city;
        private string _street;
        private string _building;
        private string _apartment;

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
                }catch (Exception ex)
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
    }
  }

