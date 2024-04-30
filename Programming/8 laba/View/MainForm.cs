namespace _8_laba
{
    public partial class MainForm : Form
    {
        Random random = new Random();
        private List<Flight> _flights = new List<Flight>();
        private Flight _currentFlight = new Flight();
        private List<string> _flightsListBoxItems = new List<string>();
        private string[] Cities = (string[])Enum.GetNames(typeof(Cities));

        /// <summary>
        /// —оздает 5 рандомных объекта класса Flight.
        /// </summary>
        public void FlightsInitiaziation()
        {
            for (int i = 0; i < 5; i++)
            {
                int cityIndex = random.Next(0, Cities.Length);
                string departute = Cities[cityIndex];
                string destination = Cities[cityIndex == Cities.Length - 1 ? cityIndex - random.Next(0, cityIndex) : cityIndex + 1];

                DateTime start = DateTime.Today;
                DateTime end = new DateTime(2050, 12, 31);
                int range = (end - start).Days;
                DateTime dateTime = start.AddDays(random.Next(range));

                //DateTime dateTime = new DateTime(random.Next(2024, 2050), random.Next(1, 12), random.Next(27));
                int flightDuration = random.Next(0, 1000);
                TypesOfFlight typesOfFlight = (TypesOfFlight)random.Next(2);

                _flights.Add(new Flight(departute, destination, dateTime, flightDuration, typesOfFlight));
                _flightsListBoxItems.Add($"{dateTime.ToShortDateString()}: {departute} Ч {destination}");

            }
            foreach (string el in _flightsListBoxItems)
            {
                FlightsListBox.Items.Add(el);
            }

        }
        public MainForm()
        {
            InitializeComponent();
            FlightsInitiaziation();

            DepartureTextBox.ReadOnly = true;
            DestinationTextBox.ReadOnly = true;
            DepartureDateTimePicker.Enabled = false;
            FlightTimeNumericUpDown.Enabled = false;
            TypeOfFlightComboBox.Enabled = false;

            TypeOfFlightComboBox.Items.AddRange(Enum.GetValues(typeof(TypesOfFlight)).Cast<object>().ToArray());

        }

        private void FlightsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = FlightsListBox.SelectedIndex;

            if (selectedIndex == -1) return;

            DepartureTextBox.ReadOnly = false;
            DestinationTextBox.ReadOnly = false;
            DepartureDateTimePicker.Enabled = true;
            FlightTimeNumericUpDown.Enabled = true;
            TypeOfFlightComboBox.Enabled = true;



            _currentFlight = _flights[selectedIndex];

            DepartureTextBox.Text = _currentFlight.DeparturePoint.ToString();
            DestinationTextBox.Text = _currentFlight.DestinationPoint.ToString();
            DepartureDateTimePicker.Text = _currentFlight.DepartureDate.ToString();
            FlightTimeNumericUpDown.Text = _currentFlight.FlightTimeMinutes.ToString();
            TypeOfFlightComboBox.Text = _currentFlight.TypeOfFlight.ToString();

        }

        private void DepartureTextBox_TextChanged(object sender, EventArgs e)
        {
            int selectedIndex = FlightsListBox.SelectedIndex;
            try
            {
                DepartureTextBox.BackColor = System.Drawing.Color.White;

                string departure = DepartureTextBox.Text;
                _currentFlight.DeparturePoint = departure;

                _flightsListBoxItems[selectedIndex] = $"{_currentFlight.DepartureDate.ToShortDateString()}: {_currentFlight.DeparturePoint} Ч {_currentFlight.DestinationPoint}";
                FlightsListBox.Items[selectedIndex] = _flightsListBoxItems[selectedIndex];

            }
            catch (Exception)
            {
                DepartureTextBox.BackColor = System.Drawing.Color.LightPink;
            }

        }

        private void DestinationTextBox_TextChanged(object sender, EventArgs e)
        {
            int selectedIndex = FlightsListBox.SelectedIndex;
            try
            {
                DestinationTextBox.BackColor = System.Drawing.Color.White;

                string departure = DestinationTextBox.Text;
                _currentFlight.DestinationPoint = departure;

                _flightsListBoxItems[selectedIndex] = $"{_currentFlight.DepartureDate.ToShortDateString()}: {_currentFlight.DeparturePoint} Ч {_currentFlight.DestinationPoint}";
                FlightsListBox.Items[selectedIndex] = _flightsListBoxItems[selectedIndex];

            }
            catch (Exception)
            {
                DestinationTextBox.BackColor = System.Drawing.Color.LightPink;
            }

        }

        private void DepartureDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = FlightsListBox.SelectedIndex;
                DepartureDateTimePicker.MinDate = DateTime.Today;

                DateTime date = DepartureDateTimePicker.Value;
                _currentFlight.DepartureDate = date;

                _flightsListBoxItems[selectedIndex] = $"{_currentFlight.DepartureDate.ToShortDateString()}: {_currentFlight.DeparturePoint} Ч {_currentFlight.DestinationPoint}";
                FlightsListBox.Items[selectedIndex] = _flightsListBoxItems[selectedIndex];
            }
            catch (Exception)
            {
                MessageBox.Show("Ќельз€ выбрать дату раньше сегодн€шней!");
            }
        }

        private void FlightTimeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = FlightsListBox.SelectedIndex;


                int duration = (int)FlightTimeNumericUpDown.Value;
                _currentFlight.FlightTimeMinutes = duration;


            }
            catch (Exception)
            {
                FlightTimeNumericUpDown.BackColor = System.Drawing.Color.LightPink;
            }

        }

        private void TypeOfFlightComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex= FlightsListBox.SelectedIndex;

            TypesOfFlight type = (TypesOfFlight)TypeOfFlightComboBox.SelectedItem;
            _currentFlight.TypeOfFlight = type;
        }
    }
}
