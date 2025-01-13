using OOP.Model;
namespace OOP.View
{
    public partial class AddressControl : UserControl
    {
        /// <summary>
        /// Поле текущего адресса.
        /// </summary>
        private Address _address;

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
                UpdateData();
            }
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
        /// Обновляет данные в пользовательском элементе управления
        /// на основе текущих значений свойства <see cref="Address"/>.
        /// </summary>
        private void UpdateData()
        {
            PostIndexTextBox.Text = Address.Index.ToString();
            CountryTextBox.Text = Address.Country;
            CityTextBox.Text = Address.City;
            StreetTextBox.Text = Address.Street;
            BuildingTextBox.Text = Address.Building;
            ApartmentTextBox.Text = Address.Apartment;
        }

        /// <summary>
        /// Очищает форму от всех значений.
        /// </summary>
        public void ClearForm()
        {
            PostIndexTextBox.Text = "111111";
            CountryTextBox.Clear();
            CityTextBox.Clear();
            StreetTextBox.Clear();
            BuildingTextBox.Clear();
            ApartmentTextBox.Clear();
        }

        /// <summary>
        /// Обработчик изменения текста в поле индекса.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void PostIndexTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                PostIndexTextBox.BackColor = ColorsTool.GetWhite();
                PostIndexToolTip.SetToolTip(PostIndexTextBox, "Индекс должен состоять из 6 цифр");

                Address.Index = int.Parse(PostIndexTextBox.Text);
            }
            catch (Exception)
            {
                PostIndexTextBox.BackColor = ColorsTool.GetRed();
            }
        }

        /// <summary>
        /// Обработчик изменения текста в поле страны.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CountryTextBox.BackColor = ColorsTool.GetWhite();
                CountryToolTip.SetToolTip(CountryTextBox, "Не более 50 символов");
                    
                Address.Country = CountryTextBox.Text;
            }
            catch (Exception)
            {
                CountryTextBox.BackColor = ColorsTool.GetRed();
            }
        }

        /// <summary>
        /// Обработчик изменения текста в поле города.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CityTextBox.BackColor = ColorsTool.GetWhite();
                CityToolTip.SetToolTip(CityTextBox, "Не более 50 символов");

                Address.City = CityTextBox.Text;
            }
            catch (Exception)
            {
                CityTextBox.BackColor = ColorsTool.GetRed();
            }
        }

        /// <summary>
        /// Обработчик изменения текста в поле улицы.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                StreetTextBox.BackColor = ColorsTool.GetWhite();
                StreetToolTip.SetToolTip(StreetTextBox, "Не более 100 символов");

                Address.Street = StreetTextBox.Text;
            }
            catch (Exception)
            {
                StreetTextBox.BackColor = ColorsTool.GetRed();
            }
        }

        /// <summary>
        /// Обработчик изменения текста в поле здания.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                BuildingTextBox.BackColor = ColorsTool.GetWhite();
                BuildingToolTip.SetToolTip(BuildingTextBox, "Не более 10 символов");

                Address.Building = BuildingTextBox.Text;
            }
            catch (Exception)
            {
                BuildingTextBox.BackColor = ColorsTool.GetRed();
            }
        }

        /// <summary>
        /// Обработчик изменения текста в поле квартиры.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ApartmentTextBox.BackColor = ColorsTool.GetWhite();
                ApartmentToolTip.SetToolTip(ApartmentTextBox, "Не более 10 символов");

                Address.Apartment = ApartmentTextBox.Text;
            }
            catch (Exception)
            {
                ApartmentTextBox.BackColor = ColorsTool.GetRed();
            }
        }
    }
}
