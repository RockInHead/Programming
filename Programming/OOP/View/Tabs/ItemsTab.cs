using OOP.Services;
using static OOP.Services.DataTools;

namespace OOP.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Список всех доступных товаров.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Текущий выбранный товар.
        /// </summary>
        private Item _currentItem;

        /// <summary>
        /// Список предметов, отображаемых в пользовательском интерфейсе.
        /// </summary>
        List<Item> _displayedItems;

        /// <summary>
        /// Получает или устанавливает список товаров.
        /// </summary>
        public List<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }

        /// <summary>
        /// Событие изменения товаров.
        /// </summary>
        public event EventHandler<EventArgs> ItemsChanged;

        /// <summary>
        /// Конструктор класса ItemsTab. 
        /// Инициализирует компоненты и заполняет комбобокс категориями.
        /// </summary>
        public ItemsTab()
        {
            InitializeComponent();
            CategoryComboBox.Items.AddRange(
                 Enum.GetValues(typeof(Category))
                .Cast<object>().ToArray());
            SortByComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Проверяет, содержится ли подстрока в названии товара.
        /// </summary>
        /// <param name="item">Товар для проверки.</param>
        /// <returns>True, если подстрока найдена; иначе False.</returns>
        private bool FindSubstringInString(Item item)
        {
            if (item.Name.IndexOf(FindSubstringTextBox.Text) != -1)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Сортирует товары в порядке возрастания стоимости.
        /// </summary>
        /// <param name="item1">Первый товар для сравнения.</param>
        /// <param name="item2">Второй товар для сравнения.</param>
        /// <returns>True, если первый товар дороже второго.</returns>
        private bool CostAscending(Item item1, Item item2)
        {
            return item1.Cost > item2.Cost;
        }

        /// <summary>
        /// Сортирует товары в порядке убывания стоимости.
        /// </summary>
        /// <param name="item1">Первый товар для сравнения.</param>
        /// <param name="item2">Второй товар для сравнения.</param>
        /// <returns>True, если первый товар дешевле второго.</returns>
        private bool CostDescending(Item item1, Item item2)
        {
            return item1.Cost < item2.Cost;
        }

        /// <summary>
        /// Сравнивает два товара по алфавиту (от A до Z).
        /// </summary>
        /// <param name="item1">Первый товар для сравнения.</param>
        /// <param name="item2">Второй товар для сравнения.</param>
        /// <returns>True, если первый товар идет перед вторым в алфавитном порядке.</returns>
        private bool AlphabetAZ(Item item1, Item item2)
        {
            if ((string.Compare(item1.Name, item2.Name)) < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Сравнивает два товара по алфавиту (от Z до A).
        /// </summary>
        /// <param name="item1">Первый товар для сравнения.</param>
        /// <param name="item2">Второй товар для сравнения.</param>
        /// <returns>True, если первый товар идет после второго в алфавитном порядке.</returns>
        private bool AlphabetZA(Item item1, Item item2)
        {
            if (string.Compare(item1.Name, item2.Name) < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Сортирует список товаров в зависимости от выбранного критерия сортировки.
        /// </summary>
        /// <param name="sortingCriteria">Критерий сортировки.</param>
        private void SortItemsListBox(SortingCriteria sortingCriteria)
        {
            List<Item> sortedItems;
            sortedItems = DataTools.SortBy(Items, sortingCriteria);
            _displayedItems = sortedItems;
            ItemsListBox.Items.Clear();
            foreach (Item item in sortedItems)
            {
                ItemsListBox.Items.Add($"{item.Id.ToString()}){item.Name}");
            }
        }

        /// <summary>
        /// Определяет тип сортировки на основе выбранного критерия.
        /// </summary>
        private void TypeOfSorting()
        {
            SortingCriteria sortingCriteria;
            List<Item> sortedItems;

            switch (SortByComboBox.SelectedIndex)
            {
                case 0:
                    sortingCriteria = AlphabetAZ;
                    SortItemsListBox(sortingCriteria);

                    break;
                case 1:
                    sortingCriteria = AlphabetZA;
                    SortItemsListBox(sortingCriteria);
                    break;
                case 2:
                    sortingCriteria = CostAscending;
                    SortItemsListBox(sortingCriteria);

                    break;
                case 3:
                    sortingCriteria = CostDescending;
                    SortItemsListBox(sortingCriteria);
                    break;
            }

            FilterListBox();
        }

        /// <summary>
        /// Фильтрует список товаров с учетом введенной подстроки.
        /// </summary>
        private void FilterListBox()
        {
            List<Item> filteredItems = DataTools.Filter(Items, FindSubstringInString);
            _displayedItems = filteredItems;
            ItemsListBox.Items.Clear();
            foreach (Item item in filteredItems)
            {
                ItemsListBox.Items.Add($"{item.Id.ToString()}){item.Name}");
            }
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Добавить".
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            ItemsListBox.SelectedIndex = -1;
            AddButton.Enabled = false;
            IdTextBox.Text = "";
            CostTextBox.Text = "";
            NameRichTextBox.Text = "";
            DescriptionRichTextBox.Text = "";
            CategoryComboBox.ResetText();

            OkButton.Enabled = true;
            CancelButton.Enabled = true;

            CostTextBox.ReadOnly = false;
            NameRichTextBox.ReadOnly = false;
            DescriptionRichTextBox.ReadOnly = false;
            CategoryComboBox.Enabled = true;
        }

        /// <summary>
        /// Обработчик изменения выбранного элемента в списке товаров.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1)
            {
                AddButton.Enabled = true;
                IdTextBox.Text = "";
                CostTextBox.Text = "";
                NameRichTextBox.Text = "";
                DescriptionRichTextBox.Text = "";
                CategoryComboBox.SelectedIndex = -1;
            }
            else
            {
                CostTextBox.ReadOnly = false;
                NameRichTextBox.ReadOnly = false;
                DescriptionRichTextBox.ReadOnly = false;
                CategoryComboBox.Enabled = true;

                int selectedIndex = ItemsListBox.SelectedIndex;
                _currentItem = _displayedItems[selectedIndex];
                IdTextBox.Text = _currentItem.Id.ToString();
                CostTextBox.Text = _currentItem.Cost.ToString();
                NameRichTextBox.Text = _currentItem.Name;
                DescriptionRichTextBox.Text = _currentItem.Info;
                CategoryComboBox.Text = _currentItem.Category.ToString();
            }
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Удалить".
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = ItemsListBox.SelectedIndex;

            if (selectedIndex == -1) return;

            Items.RemoveAt(selectedIndex);
            ItemsListBox.Items.RemoveAt(selectedIndex);
            TypeOfSorting();

            IdTextBox.Text = "";
            CostTextBox.Text = "";
            NameRichTextBox.Text = "";
            DescriptionRichTextBox.Text = "";
            CategoryComboBox.SelectedIndex = -1;

            ItemsChanged?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Обработчик изменения текста в текстовом поле стоимости.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            int selectedIndex = ItemsListBox.SelectedIndex;

            if (selectedIndex == -1 || selectedIndex == null)
            {
                try
                {
                    if (!(CostTextBox.Text.Any(Char.IsWhiteSpace)) &&
                        !(String.IsNullOrEmpty(CostTextBox.Text)))
                    {
                        CostTextBox.BackColor = ColorsTool.GetWhite();
                        double cost = double.Parse(CostTextBox.Text);
                        ItemsChanged?.Invoke(this, EventArgs.Empty);
                    }
                }
                catch (Exception)
                {
                    CostTextBox.BackColor = ColorsTool.GetRed();
                }
            }

            if (selectedIndex != -1)
            {
                try
                {
                    if (ItemsListBox.Items.Count != 0)
                    {

                        CostTextBox.BackColor = System.Drawing.Color.White;
                        double cost = double.Parse(CostTextBox.Text);
                        _currentItem.Cost = cost;
                        ItemsChanged?.Invoke(this, EventArgs.Empty);
                    }
                }

                catch (Exception)
                {
                    CostTextBox.BackColor = System.Drawing.Color.LightPink;
                }
            }

        }

        /// <summary>
        /// Обработчик изменения текста в текстовом поле имени товара.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void NameRichTextBox_TextChanged(object sender, EventArgs e)
        {
            if ((ItemsListBox.SelectedIndex != -1))
            {
                _currentItem.Name = NameRichTextBox.Text;

                ItemsListBox.Items[ItemsListBox.SelectedIndex] = $"{_currentItem.Id.ToString()}){_currentItem.Name.ToString()}";

                NameRichTextBox.Select(NameRichTextBox.Text.Length, 0);
                ItemsChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Обработчик изменения текста в текстовом поле описания товара.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void DescriptionRichTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1)
            {
                _currentItem.Info = DescriptionRichTextBox.Text;
                ItemsChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Обработчик события перемещения мыши над текстовым полем имени.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void NameRichTextBox_MouseMove(object sender, MouseEventArgs e)
        {
            NameToolTip.SetToolTip(NameRichTextBox, "Не более 200 символов");
        }

        /// <summary>
        /// Обработчик события перемещения мыши над текстовым полем описания.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void DescriptionRichTextBox_MouseMove(object sender, MouseEventArgs e)
        {
            DesriptionToolTip.SetToolTip(DescriptionRichTextBox, "Не более 1000 символов");
        }

        /// <summary>
        /// Обработчик изменения выбранной категории товара из комбобокса.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1)
            {
                Category category = (Category)CategoryComboBox.SelectedItem;
                _currentItem.Category = category;
                ItemsChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Обработчик изменения текста в текстовом поле для поиска.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void FindSubstringTextBox_TextChanged(object sender, EventArgs e)
        {
            FilterListBox();
        }

        /// <summary>
        /// Обработчик изменения выбранного критерия сортировки.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void SortByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.Items.Count != 0)
            {
                ItemsListBox.SelectedIndex = -1;
                TypeOfSorting();
            }
        }

        /// <summary>
        /// Обработчик события клика по кнопке "OK".
        /// Проверяет введенные данные и добавляет новый элемент в список.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void OkButton_Click(object sender, EventArgs e)
        {
            try
            {
                CostTextBox.BackColor = ColorsTool.GetWhite();
                ErrorLabel.Visible = false;
                Category NewCategory = (Category)Enum.Parse(typeof(Category), CategoryComboBox.Text);
                Item NewItem = new Item();

                NewItem.Cost = Convert.ToDouble((CostTextBox.Text));
                NewItem.Name = NameRichTextBox.Text;
                NewItem.Info = DescriptionRichTextBox.Text;

                NewItem.Category = NewCategory;

                Items.Add(NewItem);

                ItemsListBox.Items.Add($"{NewItem.Id.ToString()}){NewItem.Name.ToString()}");

                TypeOfSorting();


                CostTextBox.Text = "";
                NameRichTextBox.Text = "";
                DescriptionRichTextBox.Text = "";
                CategoryComboBox.SelectedIndex = -1;
                ItemsChanged?.Invoke(this, EventArgs.Empty);

                AddButton.Enabled = true;
                OkButton.Enabled = false;
                CancelButton.Enabled = false;

                CostTextBox.ReadOnly = true;
                NameRichTextBox.ReadOnly = true;
                DescriptionRichTextBox.ReadOnly = true;
                CategoryComboBox.Enabled = false;
            }

            catch (ArgumentException)
            {
                ErrorLabel.Visible = true;
            }
            catch (Exception)
            {
                CostTextBox.BackColor = ColorsTool.GetRed();
            }

        }

        /// <summary>
        /// Обработчик события клика по кнопке "Отмена".
        /// Очищает все поля ввода и сбрасывает состояние кнопок.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            CostTextBox.Text = "";
            NameRichTextBox.Text = "";
            DescriptionRichTextBox.Text = "";
            CategoryComboBox.SelectedIndex = -1;

            AddButton.Enabled = true;
            OkButton.Enabled = false;
            CancelButton.Enabled = false;

            CostTextBox.ReadOnly = true;
            NameRichTextBox.ReadOnly = true;
            DescriptionRichTextBox.ReadOnly = true;
            CategoryComboBox.Enabled = false;
        }

        /// <summary>
        /// Обработчик события загрузки вкладки элементов.
        /// Инициализирует состояние кнопок при загрузке.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void ItemsTab_Load(object sender, EventArgs e)
        {
            CostTextBox.ReadOnly = true;
            NameRichTextBox.ReadOnly = true;
            DescriptionRichTextBox.ReadOnly = true;
            CategoryComboBox.Enabled = false;

            OkButton.Enabled = false;
            CancelButton.Enabled = false;
        }
    }
}
