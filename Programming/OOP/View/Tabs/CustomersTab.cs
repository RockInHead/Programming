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
    public partial class СustomersTab : UserControl
    {
        private List<Customer> _customers;
        private Customer _currentCustomer;
        private List<string> CustomersListBoxItems = new List<string>();

        public List<Customer> Customers
        {
            get { return _customers; }
            set { _customers = value; }
        }
        public СustomersTab()
        {
            InitializeComponent();
        }
        
        private void RemoveCustomerButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = CustomersListBox.SelectedIndex;


            if (selectedIndex == -1) return;

            Customers.RemoveAt(selectedIndex);
            CustomersListBoxItems.RemoveAt(selectedIndex);
            CustomersListBox.Items.RemoveAt(selectedIndex);

            FullNameTextBox.Text = "";
            /*AddressRichTextBox.Text = "";*/

        }

        private void AddressRichTextBox_TextChanged(object sender, EventArgs e)
        {
            /* if ((CustomersListBox.SelectedIndex != -1))
             {
                 _currentCustomer.Address = AddressRichTextBox.Text;
             }*/
        }
        private int ListBoxState()
        {
            return CustomersListBox.SelectedIndex;
        }


        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*addressControl1.ListBoxfromCustomersTabState(CustomersListBox.SelectedIndex);*/
            if (CustomersListBox.Items.Count == 0 || CustomersListBox.SelectedIndex == -1)
            {
                addressControl1.ListBoxNull = true;
                AddCustomerButton.Enabled = true;
                IdTextBox.Text = "";

                FullNameTextBox.Text = "";
                addressControl1.ClearForm();

                /*AddressRichTextBox.Text = "";*/

            }
            else
            {
                addressControl1.ListBoxNull = false;

                AddCustomerButton.Enabled = false;


                int selectedIndex = CustomersListBox.SelectedIndex;
                if (selectedIndex == -1) return;

                _currentCustomer = Customers[selectedIndex];

                IdTextBox.Text = _currentCustomer.Id.ToString();
                FullNameTextBox.Text = _currentCustomer.FullName;

                /*                AddressControl.Get(_currentCustomer.Address);
                                addressControl1.ShowValues();*/
                addressControl1.ShowValues(_currentCustomer.Address);
                /*AddressRichTextBox.Text = _currentCustomer.Address;*/
            }
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {

            Customer NewCustomer = new Customer();
            NewCustomer.FullName = FullNameTextBox.Text;
            NewCustomer.Address = addressControl1.GiveValues();
            /*NewCustomer.Address = addressControl1.Address;*/
            /* NewCustomer.Address = AddressRichTextBox.Text;*/


            Customers.Add(NewCustomer);
            CustomersListBoxItems.Add($"{NewCustomer.Id.ToString()})");
            CustomersListBox.Items.Add(CustomersListBoxItems[CustomersListBoxItems.Count - 1]);
            /*CanvaRectanglesListBox.SelectedIndex = CanvaRectanglesListBox.Items.Count - 1;*/

            FullNameTextBox.Text = "";

            addressControl1.ClearForm();
            /*addressControl1.ListBoxfromCustomersTabState(CustomersListBox.SelectedIndex);*/

            /*AddressRichTextBox.Text = "";*/




        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if ((CustomersListBox.SelectedIndex != -1))
            {
                _currentCustomer.FullName = FullNameTextBox.Text;
            }
        }

        private void CustomersListBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (CustomersListBox.IndexFromPoint(e.Location) == -1)
            {
                // Если кликнули на пустое место, сбрасываем выбор
                addressControl1.ListBoxNull = true;
                CustomersListBox.ClearSelected();
                CustomersListBox.SelectedIndex = -1;

            }
        }

        private void SelectedCustomerGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void addressControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
