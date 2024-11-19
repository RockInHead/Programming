using OOP.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OOP.Services.DataTools;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OOP.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Событие изменения товаров.
        /// </summary>
        public event EventHandler<EventArgs> ItemsChanged;

        //Поля
        private List<Item> _items;
        private Item _currentItem;
        List<Item> _displayedItems;
        private List<string> ItemsListBoxItems = new List<string>();

        public List<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }
        public ItemsTab()
        {
            InitializeComponent();
            CategoryComboBox.Items.AddRange(Enum.GetValues(typeof(Category)).Cast<object>().ToArray());
            SortByComboBox.SelectedIndex = 0;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

            try
            {
                CostTextBox.BackColor = System.Drawing.Color.White;
                label6.Visible = false;
                Category NewCategory = (Category)Enum.Parse(typeof(Category), CategoryComboBox.Text);
                Item NewItem = new Item();

                NewItem.Cost = Convert.ToDouble((CostTextBox.Text));
                NewItem.Name = NameRichTextBox.Text;
                NewItem.Info = DescriptionRichTextBox.Text;

                NewItem.Category = NewCategory;

                Items.Add(NewItem);
                ItemsListBoxItems.Add($"{NewItem.Id.ToString()}){NewItem.Name.ToString()}");
                ItemsListBox.Items.Add(ItemsListBoxItems[ItemsListBoxItems.Count - 1]);
                /*_displayedItems = Items;*/
                TypeOfSorting();


                CostTextBox.Text = "";
                NameRichTextBox.Text = "";
                DescriptionRichTextBox.Text = "";
                CategoryComboBox.SelectedIndex = -1;
                ItemsChanged?.Invoke(this, EventArgs.Empty);

            }

            catch (ArgumentException)
            {
                label6.Visible = true;


            }
            catch (Exception)
            {
                CostTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

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
                AddButton.Enabled = false;

                int selectedIndex = ItemsListBox.SelectedIndex;
                /*              _displayedItems = Items;*/
                _currentItem = _displayedItems[selectedIndex];
                IdTextBox.Text = _currentItem.Id.ToString();
                CostTextBox.Text = _currentItem.Cost.ToString();
                NameRichTextBox.Text = _currentItem.Name;
                DescriptionRichTextBox.Text = _currentItem.Info;
                CategoryComboBox.Text = _currentItem.Category.ToString();
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = ItemsListBox.SelectedIndex;


            if (selectedIndex == -1) return;

            Items.RemoveAt(selectedIndex);
            ItemsListBoxItems.RemoveAt(selectedIndex);
            ItemsListBox.Items.RemoveAt(selectedIndex);
            /*_displayedItems = Items;*/
            TypeOfSorting();


            IdTextBox.Text = "";

            CostTextBox.Text = "";

            NameRichTextBox.Text = "";

            DescriptionRichTextBox.Text = "";

            CategoryComboBox.SelectedIndex = -1;
            ItemsChanged?.Invoke(this, EventArgs.Empty);

        }



        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            int selectedIndex = ItemsListBox.SelectedIndex;
            if (selectedIndex == -1 || selectedIndex == null)
            {
                try
                {
                    if (!(CostTextBox.Text.Any(Char.IsWhiteSpace)) && !(String.IsNullOrEmpty(CostTextBox.Text)))
                    {
                        CostTextBox.BackColor = System.Drawing.Color.White;
                        double cost = double.Parse(CostTextBox.Text);
                        ItemsChanged?.Invoke(this, EventArgs.Empty);
                    }
                }
                catch (Exception)
                {
                    CostTextBox.BackColor = System.Drawing.Color.LightPink;
                }
            }



            if (ItemsListBox.SelectedIndex != -1)
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

        private void NameRichTextBox_TextChanged(object sender, EventArgs e)
        {


            if ((ItemsListBox.SelectedIndex != -1))
            {
                _currentItem.Name = NameRichTextBox.Text;
                ItemsChanged?.Invoke(this, EventArgs.Empty);
            }

        }

        private void DescriptionRichTextBox_TextChanged(object sender, EventArgs e)
        {

            if (ItemsListBox.SelectedIndex != -1)
            {
                /*int selectedIndex = ItemsListBox.SelectedIndex;
                _currentItem = Items[selectedIndex];*/
                _currentItem.Info = DescriptionRichTextBox.Text;
                ItemsChanged?.Invoke(this, EventArgs.Empty);
            }
        }





        private void ItemsListBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (ItemsListBox.IndexFromPoint(e.Location) == -1)
            {
                // Если кликнули на пустое место, сбрасываем выбор
                ItemsListBox.ClearSelected();
                ItemsListBox.SelectedIndex = -1;
            }
        }

        private void NameRichTextBox_MouseMove(object sender, MouseEventArgs e)
        {
            NameToolTip.SetToolTip(NameRichTextBox, "Не более 200 символов");
        }

        private void DescriptionRichTextBox_MouseMove(object sender, MouseEventArgs e)
        {
            DesriptionToolTip.SetToolTip(DescriptionRichTextBox, "Не более 1000 символов");

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1)
            {
                Category category = (Category)CategoryComboBox.SelectedItem;
                _currentItem.Category = category;
                ItemsChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        private void SelectedItemGroupBox_Enter(object sender, EventArgs e)
        {

        }
        private bool FindSubstringInString(Item item)
        {
            if (item.Name.IndexOf(FindSubstringTextBox.Text) != -1)
            {
                return true;
            }
            return false;
        }
        private void FilterListBox()
        {
            /*SortingCriteria substringCriteria;*/
            /*substringCriteria = FindSubstringInString;*/
            List<Item> filteredItems = DataTools.Filter(Items, FindSubstringInString);
            /*            _displayedItems.Clear();*/
            _displayedItems = filteredItems;
            ItemsListBoxItems.Clear();
            foreach (Item item in filteredItems)
            {
                ItemsListBoxItems.Add($"{item.Id.ToString()}){item.Name}");
            }
            ItemsListBox.Items.Clear();
            ItemsListBox.Items.AddRange(ItemsListBoxItems.ToArray());
        }
        private void FindSubstringTextBox_TextChanged(object sender, EventArgs e)
        {
            FilterListBox();
            /*SortingCriteria substringCriteria;*/
            /*substringCriteria = FindSubstringInString;*//*
            List<Item> filteredItems = DataTools.Filter(Items, FindSubstringInString);
            *//*            _displayedItems.Clear();*//*
            _displayedItems = filteredItems;
            ItemsListBoxItems.Clear();
            foreach (Item item in filteredItems)
            {
                ItemsListBoxItems.Add($"{item.Id.ToString()}){item.Name}");
            }
            ItemsListBox.Items.Clear();
            ItemsListBox.Items.AddRange(ItemsListBoxItems.ToArray());*/
        }
        private bool CostAscending(Item item1,Item item2)
        {
            return item1.Cost > item2.Cost;
        }
        private bool CostDescending(Item item1, Item item2)
        {
            return item1.Cost < item2.Cost;
        }
        private bool AlphabetAZ(Item item1,Item item2)
        {
            if ((string.Compare(item1.Name, item2.Name)) < 0)
             {
                return false;

            }
            else { 
                return true; 
            }
        }
        private bool AlphabetZA(Item item1, Item item2)
        {
            if ((string.Compare(item1.Name, item2.Name)) < 0)
            {
                return true;

            }
            else
            {
                return false;
            }
        }
        private void SortItemsListBox(SortingCriteria sortingCriteria)
        {
            List<Item> sortedItems;
            sortedItems = DataTools.SortBy(Items, sortingCriteria);
            _displayedItems = sortedItems;
            ItemsListBoxItems.Clear();
            foreach (Item item in sortedItems)
            {
                ItemsListBoxItems.Add($"{item.Id.ToString()}){item.Name}");
            }
            ItemsListBox.Items.Clear();
            ItemsListBox.Items.AddRange(ItemsListBoxItems.ToArray());
      
        }
        private void TypeOfSorting()
        {
            SortingCriteria sortingCriteria;
            List<Item> sortedItems;

            switch (SortByComboBox.SelectedIndex)
            {
                case 0:
                    sortingCriteria = AlphabetAZ;
                    SortItemsListBox(sortingCriteria);

                    /*sortedItems = DataTools.SortBy(Items, sortingCriteria);
                    _displayedItems = sortedItems;
                    ItemsListBoxItems.Clear();
                    foreach (Item item in sortedItems)
                    {
                        ItemsListBoxItems.Add($"{item.Id.ToString()}){item.Name}");
                    }
                    ItemsListBox.Items.Clear();
                    ItemsListBox.Items.AddRange(ItemsListBoxItems.ToArray());*/
                    break;
                case 1:
                    sortingCriteria = AlphabetZA;
                    SortItemsListBox(sortingCriteria);
                    /*sortedItems = DataTools.SortBy(Items, sortingCriteria);
                    _displayedItems = sortedItems;
                    ItemsListBoxItems.Clear();
                    foreach (Item item in sortedItems)
                    {
                        ItemsListBoxItems.Add($"{item.Id.ToString()}){item.Name}");
                    }
                    ItemsListBox.Items.Clear();
                    ItemsListBox.Items.AddRange(ItemsListBoxItems.ToArray());*/
                    break;
                case 2:
                    sortingCriteria = CostAscending;
                    SortItemsListBox(sortingCriteria);

                    /*sortedItems = DataTools.SortBy(Items, sortingCriteria);
                    _displayedItems = sortedItems;
                    ItemsListBoxItems.Clear();
                    foreach (Item item in sortedItems)
                    {
                        ItemsListBoxItems.Add($"{item.Id.ToString()}){item.Name}");
                    }
                    ItemsListBox.Items.Clear();
                    ItemsListBox.Items.AddRange(ItemsListBoxItems.ToArray());*/
                    break;
                case 3:
                    sortingCriteria = CostDescending;
                    SortItemsListBox(sortingCriteria);

                    /*sortedItems = DataTools.SortBy(Items, sortingCriteria);
                    _displayedItems = sortedItems;
                    ItemsListBoxItems.Clear();
                    foreach (Item item in sortedItems)
                    {
                        ItemsListBoxItems.Add($"{item.Id.ToString()}){item.Name}");
                    }
                    ItemsListBox.Items.Clear();
                    ItemsListBox.Items.AddRange(ItemsListBoxItems.ToArray());*/

                    break;

            }
            FilterListBox();

        }
        private void SortByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.Items.Count!=0)
            {
                ItemsListBox.SelectedIndex = -1;
                TypeOfSorting();
            }
        }
    }
}
