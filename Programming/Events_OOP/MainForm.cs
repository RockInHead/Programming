using Events_OOP.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Events_OOP
{
    public partial class MainForm : Form
    {
        Contact _contact;
        public Contact Contact
        {
            get
            {
                return _contact;
            }
            set
            {
                if (_contact != null)
                {
                    Contact.FullNameChanged -= FullNameChanged;
                    Contact.PhoneNumberChanged -= PhoneNumberChanged;
                    Contact.AddressChanged -= AddressChanged;
                }
                if (value == null) return;
                _contact = value;
                FullNameTextBox.Text = Contact.FullName;
                PhoneNumberTextBox.Text = Contact.PhoneNumber;
                AddressTextBox.Text = Contact.Address;
                Contact.FullNameChanged += FullNameChanged;
                Contact.PhoneNumberChanged += PhoneNumberChanged;
                Contact.AddressChanged += AddressChanged;
            }
        }
        public MainForm()
        {
            
            InitializeComponent();
           /* Form SecondForm = new SecondForm();
            Form ThirdForm = new SecondForm();

            SecondForm.Show();
            ThirdForm.Show();*/
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        



        }

        private void contactTab1_Load(object sender, EventArgs e)
        {

        }

        

        public void FullNameChanged(object sender, EventArgs args)
        {
            FullNameTextBox.Text = Contact.FullName;
        }
        public void PhoneNumberChanged(object sender, EventArgs args)
        {
            PhoneNumberTextBox.Text = Contact.PhoneNumber;
        }
        public void AddressChanged(object sender, EventArgs args)
        {
            AddressTextBox.Text = Contact.Address;
        }
    }
}
