using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP.View.Tabs
{
    public partial class Сustomers : UserControl
    {
        private List<Customer> _customers = new List<Customer>();
        private Customer _currentCustomer;
        private List<string> CustomersListBoxItems = new List<string>();
        public Сustomers()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int selectedIndex = CustomersListBox.SelectedIndex;


            if (selectedIndex == -1) return;

            _customers.RemoveAt(selectedIndex);
            CustomersListBoxItems.RemoveAt(selectedIndex);
            CustomersListBox.Items.RemoveAt(selectedIndex);

            FullNameTextBox.Text = "";
            AddressRichTextBox.Text = "";

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if ((CustomersListBox.SelectedIndex != -1))
            {
                _currentCustomer.Address = AddressRichTextBox.Text;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CustomersGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void Сustomers_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.Items.Count == 0 || CustomersListBox.SelectedIndex == -1)
            {
                IdTextBox.Text = "";

                FullNameTextBox.Text = "";


                AddressRichTextBox.Text = "";

            }



            int selectedIndex = CustomersListBox.SelectedIndex;
            if (selectedIndex == -1) return;

            _currentCustomer = _customers[selectedIndex];

            IdTextBox.Text = _currentCustomer.Id.ToString();
            FullNameTextBox.Text = _currentCustomer.FullName;
            AddressRichTextBox.Text = _currentCustomer.Address;

        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {

            Customer NewCustomer = new Customer();
            NewCustomer.FullName = FullNameTextBox.Text;
            NewCustomer.Address = AddressRichTextBox.Text;


            _customers.Add(NewCustomer);
            CustomersListBoxItems.Add($"{NewCustomer.Id.ToString()})");
            CustomersListBox.Items.Add(CustomersListBoxItems[CustomersListBoxItems.Count - 1]);
            /*CanvaRectanglesListBox.SelectedIndex = CanvaRectanglesListBox.Items.Count - 1;*/

            FullNameTextBox.Text = "";


            AddressRichTextBox.Text = "";




        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if ((CustomersListBox.SelectedIndex != -1))
            {
                _currentCustomer.FullName = FullNameTextBox.Text;
            }
        }
    }
}
