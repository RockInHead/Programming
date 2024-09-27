using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OOP.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        //Поля
        private List<Item> _items = new List<Item>();
        private Item _currentItem;
        private List<string> ItemsListBoxItems = new List<string>();


        public ItemsTab()
        {


            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

            try
            {



                CostTextBox.BackColor = System.Drawing.Color.White;
                Item NewItem = new Item();

                NewItem.Cost = Convert.ToDouble((CostTextBox.Text));
                NewItem.Name = NameRichTextBox.Text;
                NewItem.Info = DescriptionRichTextBox.Text;

                _items.Add(NewItem);
                ItemsListBoxItems.Add($"{NewItem.Id.ToString()})");
                ItemsListBox.Items.Add(ItemsListBoxItems[ItemsListBoxItems.Count - 1]);

                /*AddButton.Enabled = true;*/

                CostTextBox.Text = "";
                NameRichTextBox.Text = "";
                DescriptionRichTextBox.Text = "";


            }
            catch (Exception)
            {
                CostTextBox.BackColor = System.Drawing.Color.LightPink;

            }


        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if (ItemsListBox.Items.Count == 0 || ItemsListBox.SelectedIndex == -1)
            {
                IdTextBox.Text = "";

                CostTextBox.Text = "";


                NameRichTextBox.Text = "";

                DescriptionRichTextBox.Text = "";


            }*/



            /*if (ItemsListBox.SelectedIndex != -1 || ItemsListBox.SelectedIndex != 0)
            {
            }*/
            if (ItemsListBox.SelectedIndex == -1)
            {
                AddButton.Enabled = true;

                IdTextBox.Text = "";

                CostTextBox.Text = "";


                NameRichTextBox.Text = "";

                DescriptionRichTextBox.Text = "";
            }
            else
            {
                AddButton.Enabled = false;

                int selectedIndex = ItemsListBox.SelectedIndex;

                _currentItem = _items[selectedIndex];
                IdTextBox.Text = _currentItem.Id.ToString();
                CostTextBox.Text = _currentItem.Cost.ToString();
                NameRichTextBox.Text = _currentItem.Name;
                DescriptionRichTextBox.Text = _currentItem.Info;
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = ItemsListBox.SelectedIndex;


            if (selectedIndex == -1) return;

            _items.RemoveAt(selectedIndex);
            ItemsListBoxItems.RemoveAt(selectedIndex);
            ItemsListBox.Items.RemoveAt(selectedIndex);



            IdTextBox.Text = "";

            CostTextBox.Text = "";
            /*CanvaLengthTextBox.ReadOnly = true;*/

            NameRichTextBox.Text = "";
            /*CanvaWidthTextBox.ReadOnly = true;*/
            DescriptionRichTextBox.Text = "";

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
                        /*Item SomeItem = new Item();
                        SomeItem.Cost = cost;*/
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

                    }
                }

                catch (Exception)
                {
                    CostTextBox.BackColor = System.Drawing.Color.LightPink;
                }
            }
            /* }*/
        }

        private void NameRichTextBox_TextChanged(object sender, EventArgs e)
        {


            if ((ItemsListBox.SelectedIndex != -1))
            {
                _currentItem.Name = NameRichTextBox.Text;
            }

        }

        private void DescriptionRichTextBox_TextChanged(object sender, EventArgs e)
        {

            if (ItemsListBox.SelectedIndex != -1)
            {
                int selectedIndex = ItemsListBox.SelectedIndex;
                _currentItem = _items[selectedIndex];
                _currentItem.Info = DescriptionRichTextBox.Text;
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
    }
}
