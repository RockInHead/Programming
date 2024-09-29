﻿using OOP.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP.View
{
    public partial class AddressControl : UserControl
    {

        private Address _address;
        public Address Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }
        }
        /*public AddressControl()
        {
        }*/

        public AddressControl(Address address)
        {
            Address = address;
        }

        /* static Address SomeAddress = new Address(123456, "Россия", "Томск", "Репина", "12", "36");*/
        /*Address(NewAddress);
*/
        public AddressControl()
        {
            InitializeComponent();

            Address = new Address();

        }

        public AddressControl NewAddress;

        private void AddressControl_Load(object sender, EventArgs e)
        {

            NewAddress = new AddressControl();
            NewAddress.Address = new Address(123456, "Россия", "Томск", "Репина", "12", "36");
            PostIndexTextBox.Text = NewAddress.Address.Index.ToString();
            CountryTextBox.Text = NewAddress.Address.Country.ToString();
            CityTextBox.Text = NewAddress.Address.City.ToString();
            StreetTextBox.Text = NewAddress.Address.Street.ToString();
            BuildingTextBox.Text = NewAddress.Address.Building.ToString();
            ApartmentTextBox.Text = NewAddress.Address.Apartment.ToString();

        }

        private void AddButton_Click(object sender, EventArgs e)
        {

            label8.Text = $"{NewAddress.Address.Index.ToString()} - {NewAddress.Address.Country.ToString()} - {NewAddress.Address.City.ToString()} - {NewAddress.Address.Street.ToString()} - {NewAddress.Address.Building.ToString()} - {NewAddress.Address.Apartment.ToString()}";

        }

        private void PostIndexTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                PostIndexTextBox.BackColor = Color.White;

                NewAddress.Address.Index = int.Parse(PostIndexTextBox.Text);
            }
            catch (Exception)
            {
                PostIndexToolTip.SetToolTip(PostIndexTextBox, "Индекс должен состоять из 6 цифр");
                PostIndexTextBox.BackColor = Color.LightPink;
            }
        }

        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CountryTextBox.BackColor = Color.White;
                CountryToolTip.SetToolTip(CountryTextBox, "Не более 50 символов");

                NewAddress.Address.Country = CountryTextBox.Text;
        }
            catch (Exception)
            {
                CountryTextBox.BackColor = Color.LightPink;
            }
}

        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CityTextBox.BackColor = Color.White;
                CityToolTip.SetToolTip(CityTextBox, "Не более 50 символов");

                NewAddress.Address.City = CityTextBox.Text;
            }
            catch (Exception)
            {
                CityTextBox.BackColor = Color.LightPink;
            }
        }

        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                StreetTextBox.BackColor = Color.White;
                StreetToolTip.SetToolTip(StreetTextBox, "Не более 100 символов");

                NewAddress.Address.Street = StreetTextBox.Text;
            }
            catch (Exception)
            {
                StreetTextBox.BackColor = Color.LightPink;
            }
        }

        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                BuildingTextBox.BackColor = Color.White;
                BuildingToolTip.SetToolTip(BuildingTextBox, "Не более 10 символов");

                string i = Convert.ToString(BuildingTextBox.Text);
                
                NewAddress.Address.Building = i;

            }
            catch (Exception)
            {
                BuildingTextBox.BackColor = Color.LightPink;
               
            }
        }

        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ApartmentTextBox.BackColor = Color.White;
                ApartmentToolTip.SetToolTip(ApartmentTextBox, "Не более 10 символов");

                NewAddress.Address.Apartment = ApartmentTextBox.Text;
            }
            catch (Exception)
            {
                ApartmentTextBox.BackColor = Color.LightPink;
            }
        }
    }
}