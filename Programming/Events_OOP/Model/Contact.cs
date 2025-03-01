﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_OOP.Model
{
    public class Contact : EventArgs
    {
       


        private string _fullName;
        private string _phoneNumber;
        private string _address;

        public string FullName
        {
            get { return _fullName; }
            set { 
                
                if (_fullName != value)
                {
                    
                    _fullName = value;
                    FullNameChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        public string PhoneNumber
        {
            get { return _phoneNumber; }
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
            get { return _address; }
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
