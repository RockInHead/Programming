namespace _8_laba
{
    public partial class MainForm : Form
    {
        Random random = new Random();
        private List<Flight> _flights = new List<Flight>();
        private Flight _currentFlight = new Flight();
        private List<string> _flightsListBoxItems = new List<string>();
        private string[] Cities = (string[])Enum.GetNames(typeof(Cities));


        public void FlightsInitiaziation()
        {
            for (int i = 0; i < 5; i++)
            {
                int cityIndex = random.Next(0, Cities.Length);
                string departute = Cities[cityIndex];        
                string destination = Cities[cityIndex==Cities.Length-1 ?cityIndex-random.Next(0,cityIndex):cityIndex+1];
                DateTime dateTime = new DateTime(random.Next(2024, 2050), random.Next(1, 12), random.Next(28));
                int flightDuration = random.Next(60, 600);
                TypesOfFlight typesOfFlight = (TypesOfFlight)random.Next(2);

                _flights.Add(new Flight(departute, destination, dateTime, flightDuration, typesOfFlight));
                _flightsListBoxItems.Add($"{dateTime.ToShortDateString()}: {departute} - {destination}");

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
        }

        private void FlightsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = FlightsListBox.SelectedIndex;

            if (selectedIndex == null) return;
            _currentFlight = _flights[selectedIndex];

            DepartureTextBox.Text = _currentFlight.DeparturePoint.ToString();
            DestinationTextBox.Text = _currentFlight.DestinationPoint.ToString();
            DepartureDateTimePicker.Text=_currentFlight.DepartureDate.ToString();
            FlightTimeNumericUpDown.Text=_currentFlight.FlightTimeMinutes.ToString();
            TypeOfFlightComboBox.Text=_currentFlight.TypeOfFlight.ToString();

        }
    }
}
