using OOP.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP.View
{

    public partial class AddressControl : UserControl
    {
        /// <summary>
        /// Поле текущего адресса.
        /// </summary>
        private Address _address;

        /// <summary>
        /// Состояние списка адрессов.
        /// Если пустой - то true.
        /// </summary>
        public bool ListBoxNull=false;

        /// <summary>
        /// Получает или устанавливает адрес.
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
        /// Конструктор класса AddressControl, инициализирует новый экземпляр с заданным адресом.
        /// </summary>
        /// <param name="address">Адрес для инициализации.</param>
        public AddressControl(Address address)
        {
            Address = address;

        }

        /// <summary>
        /// Очищает все поля формы.
        /// </summary>
        public void ClearForm()
        {
            PostIndexTextBox.Text = "111111";
            CountryTextBox.Text = "";
            CityTextBox.Text = "";
            StreetTextBox.Text = "";
            BuildingTextBox.Text = "";
            ApartmentTextBox.Text = "";
        }

        /// <summary>
        /// Возвращает новый экземпляр AddressControl.
        /// </summary>
        public AddressControl NewAddress;

        /// <summary>
        /// Создает экземпляр класса Address с данными из текстовых полей.
        /// </summary>
        /// <returns>Созданный объект Address.</returns>
        public Address GiveValues()
        {
            return new Address(
                Convert.ToInt32(PostIndexTextBox.Text),
                CountryTextBox.Text, 
                CityTextBox.Text, 
                StreetTextBox.Text, 
                BuildingTextBox.Text, 
                ApartmentTextBox.Text);
        }

        /// <summary>
        /// Конструктор класса AddressControl, инициализирует новый экземпляр.
        /// </summary>
        public AddressControl()
        {
            InitializeComponent();
            Address = new Address();
        }

        /// <summary>
        /// Обработчик события загрузки элемента управления AddressControl.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void AddressControl_Load(object sender, EventArgs e)
        {
            NewAddress = new AddressControl();
            PostIndexTextBox.Text = NewAddress.Address.Index.ToString();

        }

        /// <summary>
        /// Отображает значения заданного адреса в полях формы.
        /// </summary>
        /// <param name="SomeAddress">Адрес, который будет отображен.</param>
        public void ShowValues(Address SomeAddress)
        {
            NewAddress.Address = SomeAddress;

            PostIndexTextBox.Text = NewAddress.Address.Index.ToString();
            CountryTextBox.Text = NewAddress.Address.Country.ToString();
            CityTextBox.Text = NewAddress.Address.City.ToString();
            StreetTextBox.Text = NewAddress.Address.Street.ToString();
            BuildingTextBox.Text = NewAddress.Address.Building.ToString();
            ApartmentTextBox.Text = NewAddress.Address.Apartment.ToString();
        }

        /*int value;*/
        public void ListBoxfromCustomersTabState(int SelectedIndex)
        {
            int value = SelectedIndex;
        }

        /// <summary>
        /// Обработчик изменения текста в поле индекса.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void PostIndexTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ListBoxNull == false)
            {
                try
            {
                    PostIndexTextBox.BackColor = Color.White;

                    NewAddress.Address.Index = int.Parse(PostIndexTextBox.Text);
                
            }
            catch (Exception)
            {
                PostIndexToolTip.SetToolTip(PostIndexTextBox, "Индекс должен состоять из 6 цифр");
                PostIndexTextBox.BackColor = Color.LightPink;
            }
            }
        }

        /// <summary>
        /// Обработчик изменения текста в поле страны.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ListBoxNull == false)
            {
                try
                {
                    CountryTextBox.BackColor = Color.White;
                    CountryToolTip.SetToolTip(CountryTextBox, "Не более 50 символов");

                    NewAddress.Address.Country = CountryTextBox.Text;
                }
                catch (Exception)
                {
                    CountryTextBox.BackColor = Color.LightPink;
                }
            }
}

        /// <summary>
        /// Обработчик изменения текста в поле города.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ListBoxNull == false)
            {
                try
                {
                    CityTextBox.BackColor = Color.White;
                    CityToolTip.SetToolTip(CityTextBox, "Не более 50 символов");

                    NewAddress.Address.City = CityTextBox.Text;
                }
                catch (Exception)
                {
                    CityTextBox.BackColor = Color.LightPink;
                }
            }
        }

        /// <summary>
        /// Обработчик изменения текста в поле улицы.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ListBoxNull == false)
            {
                try
                {
                    StreetTextBox.BackColor = Color.White;
                    StreetToolTip.SetToolTip(StreetTextBox, "Не более 100 символов");

                    NewAddress.Address.Street = StreetTextBox.Text;
                }
                catch (Exception)
                {
                    StreetTextBox.BackColor = Color.LightPink;
                }
            }
        }

        /// <summary>
        /// Обработчик изменения текста в поле здания.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ListBoxNull == false)
            {
                try
                {
                    BuildingTextBox.BackColor = Color.White;
                    BuildingToolTip.SetToolTip(BuildingTextBox, "Не более 10 символов");

                    string i = Convert.ToString(BuildingTextBox.Text);

                    NewAddress.Address.Building = i;

                }
                catch (Exception)
                {
                    BuildingTextBox.BackColor = Color.LightPink;

                }
            }
        }

        /// <summary>
        /// Обработчик изменения текста в поле квартиры.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ListBoxNull == false)
            {
                try
                {
                    ApartmentTextBox.BackColor = Color.White;
                    ApartmentToolTip.SetToolTip(ApartmentTextBox, "Не более 10 символов");

                    NewAddress.Address.Apartment = ApartmentTextBox.Text;
                }
                catch (Exception)
                {
                    ApartmentTextBox.BackColor = Color.LightPink;
                }
            }
        }
    }
}
