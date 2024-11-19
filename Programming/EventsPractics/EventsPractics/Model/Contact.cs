using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsPractics.Model
{
    public class Contact
    {
        string _fullname;
        string _phoneNumber;
        string _address;

        public string Fullname
        {
            get
            {
                return _fullname;
            }
            set
            {
                if (_fullname != value)
                {
                    _fullname = value;
                    FullNameChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        public string PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                if (_phoneNumber != value)
                {
                    _phoneNumber = value;
                    PhoneNumberChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                if (_address != value)
                {
                    _address = value;
                    AddressChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        public event EventHandler FullNameChanged;
        public event EventHandler PhoneNumberChanged;
        public event EventHandler AddressChanged;
    }
}
