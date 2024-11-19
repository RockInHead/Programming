using EventsPractics.Model;

namespace EventsPractics
{
    public partial class MainWindow : Form
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
                FullNameTextBox.Text = Contact.Fullname;
                PhoneNumberTextBox.Text = Contact.PhoneNumber;
                AddressTextBox.Text = Contact.Address;
                Contact.FullNameChanged += FullNameChanged;
                Contact.PhoneNumberChanged += PhoneNumberChanged;
                Contact.AddressChanged += AddressChanged;
            }
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        public void FullNameChanged(object? sender, EventArgs args)
        {
            FullNameTextBox.Text = Contact.Fullname;
        }
        public void PhoneNumberChanged(object? sender, EventArgs args)
        {
            PhoneNumberTextBox.Text = Contact.PhoneNumber;
        }
        public void AddressChanged(object? sender, EventArgs args)
        {
            AddressTextBox.Text = Contact.Address;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Contact.FullNameChanged -= FullNameChanged;
            Contact.PhoneNumberChanged -= PhoneNumberChanged;
            Contact.AddressChanged -= AddressChanged;
            Close();
        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            Contact.Fullname = FullNameTextBox.Text;
        }

        private void PhoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            Contact.PhoneNumber = PhoneNumberTextBox.Text;
        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            Contact.Address = AddressTextBox.Text;
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Contact.FullNameChanged -= FullNameChanged;
            Contact.PhoneNumberChanged -= PhoneNumberChanged;
            Contact.AddressChanged -= AddressChanged;
        }
    }
}
