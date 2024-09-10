using _8_laba.Model.Classes;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Text.Json;

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
                /* int cityIndex = random.Next(0, Cities.Length);
                 string departute = Cities[cityIndex];
                 string destination = Cities[cityIndex == Cities.Length - 1 ? cityIndex - random.Next(0, cityIndex) : cityIndex + 1];

                 DateTime start = DateTime.Today;
                 DateTime end = new DateTime(2050, 12, 31);
                 int range = (end - start).Days;
                 DateTime dateTime = start.AddDays(random.Next(range));

                 //DateTime dateTime = new DateTime(random.Next(2024, 2050), random.Next(1, 12), random.Next(27));
                 int flightDuration = random.Next(0, 1000);
                 TypesOfFlight typesOfFlight = (TypesOfFlight)random.Next(2);*/
                Flight newFlight = FlightFactory.Randomize();
                _flights.Add(newFlight);
                _flightsListBoxItems.Add($"{newFlight.DepartureDate.ToShortDateString()}: {newFlight.DeparturePoint} Ч {newFlight.DestinationPoint}");


                // _flights.Add(new Flight(departute, destination, dateTime, flightDuration, typesOfFlight));
                //_flightsListBoxItems.Add($"{dateTime.ToShortDateString()}: {departute} Ч {destination}");

            }
            foreach (string el in _flightsListBoxItems)
            {
                FlightsListBox.Items.Add(el);
            }

        }
        public void SortedByUpcomingDates()
        {
            for (int i = 0; i < _flights.Count; i++)
            {
                for (int j = 0; j < _flights.Count; j++)
                {
                    if (_flights[i].DepartureDate < _flights[j].DepartureDate)
                    {
                        (_flights[i], _flights[j]) = (_flights[j], _flights[i]);
                        (_flightsListBoxItems[i], _flightsListBoxItems[j]) = (_flightsListBoxItems[j], _flightsListBoxItems[i]);
                    }
                }
            }
            FlightsListBox.Items.Clear();
            foreach (string el in _flightsListBoxItems)
            {
                FlightsListBox.Items.Add(el);
            }

        }
        public void SortedByLaterDates()
        {
            for (int i = 0; i < _flights.Count; i++)
            {
                for (int j = 0; j < _flights.Count; j++)
                {
                    if (_flights[i].DepartureDate > _flights[j].DepartureDate)
                    {
                        (_flights[i], _flights[j]) = (_flights[j], _flights[i]);
                        (_flightsListBoxItems[i], _flightsListBoxItems[j]) = (_flightsListBoxItems[j], _flightsListBoxItems[i]);
                    }
                }
            }
            FlightsListBox.Items.Clear();
            foreach (string el in _flightsListBoxItems)
            {
                FlightsListBox.Items.Add(el);
            }

        }
        public MainForm()
        {
            InitializeComponent();
            //FlightsInitiaziation();

            ClearFlighteInfo();
            /*DepartureTextBox.ReadOnly = true;
            DestinationTextBox.ReadOnly = true;
            DepartureDateTimePicker.Enabled = false;
            FlightTimeTextBox.Enabled = false;
            TypeOfFlightComboBox.Enabled = false;*/

            TypeOfFlightComboBox.Items.AddRange(Enum.GetValues(typeof(TypesOfFlight)).Cast<object>().ToArray());

            this.Load += new System.EventHandler(this.AirTravelForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AirTravelForm_FormClosing);








        }

        private void ClearFlighteInfo()
        {
            if (FlightsListBox.Items.Count == 0 | FlightsListBox.SelectedIndex == -1)
            {
                DepartureTextBox.Text = "";
                DepartureTextBox.ReadOnly = true;

                DestinationTextBox.Text = "";
                DestinationTextBox.ReadOnly = true;

                FlightTimeTextBox.Text = "";
                FlightTimeTextBox.ReadOnly = true;

                DepartureDateTimePicker.Value = DateTime.Today;
                DepartureDateTimePicker.Enabled = false;

                TypeOfFlightComboBox.Enabled = false;
            }
            else
            {
                DepartureTextBox.ReadOnly = false;

                DestinationTextBox.ReadOnly = false;

                FlightTimeTextBox.ReadOnly = false;

                DepartureDateTimePicker.Enabled = true;

                TypeOfFlightComboBox.Enabled = true;
            }
        }
        private void FlightsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearFlighteInfo();

            int selectedIndex = FlightsListBox.SelectedIndex;

            if (selectedIndex == -1) return;

            /* DepartureTextBox.ReadOnly = false;
             DestinationTextBox.ReadOnly = false;
             DepartureDateTimePicker.Enabled = true;
             FlightTimeTextBox.Enabled = true;
             TypeOfFlightComboBox.Enabled = true;*/



            _currentFlight = _flights[selectedIndex];

            DepartureTextBox.Text = _currentFlight.DeparturePoint.ToString();
            DestinationTextBox.Text = _currentFlight.DestinationPoint.ToString();
            DepartureDateTimePicker.Text = _currentFlight.DepartureDate.ToString();
            FlightTimeTextBox.Text = _currentFlight.FlightTimeMinutes.ToString();
            TypeOfFlightComboBox.Text = _currentFlight.TypeOfFlight.ToString();

        }

        private void DepartureTextBox_TextChanged(object sender, EventArgs e)
        {
            int selectedIndex = FlightsListBox.SelectedIndex;
            if (selectedIndex == -1) return;
            try
            {
                if (FlightsListBox.Items.Count != 0)
                {
                    DepartureTextBox.BackColor = System.Drawing.Color.White;

                    string departure = DepartureTextBox.Text;
                    _currentFlight.DeparturePoint = departure;

                    _flightsListBoxItems[selectedIndex] = $"{_currentFlight.DepartureDate.ToShortDateString()}: {_currentFlight.DeparturePoint} Ч {_currentFlight.DestinationPoint}";
                    FlightsListBox.Items[selectedIndex] = _flightsListBoxItems[selectedIndex];

                    DepartureTextBox.Select(DepartureTextBox.Text.Length, 0);
                }
            }
            catch (Exception)
            {
                DepartureTextBox.BackColor = System.Drawing.Color.LightPink;
            }

        }

        private void DestinationTextBox_TextChanged(object sender, EventArgs e)
        {
            int selectedIndex = FlightsListBox.SelectedIndex;
            if (selectedIndex == -1) return;
            try
            {
                if (FlightsListBox.Items.Count != 0)
                {
                    DestinationTextBox.BackColor = System.Drawing.Color.White;

                    string departure = DestinationTextBox.Text;
                    _currentFlight.DestinationPoint = departure;

                    _flightsListBoxItems[selectedIndex] = $"{_currentFlight.DepartureDate.ToShortDateString()}: {_currentFlight.DeparturePoint} Ч {_currentFlight.DestinationPoint}";
                    FlightsListBox.Items[selectedIndex] = _flightsListBoxItems[selectedIndex];

                    DestinationTextBox.Select(DestinationTextBox.Text.Length, 0);
                }
            }
            catch (Exception)
            {
                DestinationTextBox.BackColor = System.Drawing.Color.LightPink;
            }

        }
        private void FlightTimeTextBox_TextChanged(object sender, EventArgs e)
        {
            int selectedIndex = FlightsListBox.SelectedIndex;
            if (selectedIndex == -1) return;
            try
            {
                FlightTimeTextBox.BackColor = System.Drawing.Color.White;

                int duration = int.Parse(FlightTimeTextBox.Text);
                _currentFlight.FlightTimeMinutes = duration;

            }
            catch (Exception)
            {
                FlightTimeTextBox.BackColor = System.Drawing.Color.LightPink;
            }

        }

        private void DepartureDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            int selectedIndex = FlightsListBox.SelectedIndex;
            
            if (selectedIndex == -1) return;
            try
            {
                DepartureDateTimePicker.MinDate = DateTime.Today;

                DateTime date = DepartureDateTimePicker.Value;
                _currentFlight.DepartureDate = date;

                _flightsListBoxItems[selectedIndex] = $"{_currentFlight.DepartureDate.ToShortDateString()}: {_currentFlight.DeparturePoint} Ч {_currentFlight.DestinationPoint}";
                FlightsListBox.Items[selectedIndex] = _flightsListBoxItems[selectedIndex];


                switch (SortedByComboBox.SelectedIndex)
                {
                    case 0:
                        SortedByUpcomingDates();
                        break;
                    case 1:
                        SortedByLaterDates();
                        break;
                }
                //SortedFlag = true;

                FlightsListBox.SelectedIndex = _flightsListBoxItems.IndexOf($"{_currentFlight.DepartureDate.ToShortDateString()}: {_currentFlight.DeparturePoint} Ч {_currentFlight.DestinationPoint}");
            }

            catch (Exception)
            {
                MessageBox.Show("Ќельз€ выбрать дату раньше сегодн€шней!");
            }


            // SortedByComboBox.Text = "<Ќе отсортировано>";

        }



        private void TypeOfFlightComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = FlightsListBox.SelectedIndex;

            TypesOfFlight type = (TypesOfFlight)TypeOfFlightComboBox.SelectedItem;
            _currentFlight.TypeOfFlight = type;
        }

        private void AddFlightButton_Click(object sender, EventArgs e)
        {
            Flight newFlight = FlightFactory.Randomize();
            _flights.Add(newFlight);
            _flightsListBoxItems.Add($"{newFlight.DepartureDate.ToShortDateString()}: {newFlight.DeparturePoint} Ч {newFlight.DestinationPoint}");
            FlightsListBox.Items.Add($"{newFlight.DepartureDate.ToShortDateString()}: {newFlight.DeparturePoint} Ч {newFlight.DestinationPoint}");
            //SortedByComboBox.Text = "<Ќе отсортировано>";

            switch (SortedByComboBox.SelectedIndex)
            {
                case 0:
                    SortedByUpcomingDates();
                    break;
                case 1:
                    SortedByLaterDates();
                    break;
            }
        }

        private void SaveDataToFile(string filePath)
        {
            var flightDataList = _flights.Select(flight => new FlightDate
            {
                DeparturePoint = flight.DeparturePoint,
                DestinationPoint = flight.DestinationPoint,
                DepartureDate = flight.DepartureDate,
                FlightTimeMinutes = flight.FlightTimeMinutes,
                TypeOfFlight = flight.TypeOfFlight,

            }).ToList();

            string jsonData = JsonConvert.SerializeObject(flightDataList, Formatting.Indented);
            File.WriteAllText(filePath, jsonData);
        }

        private void LoadDataFromFile(string filePath)
        {
            if (!File.Exists(filePath))
                return;

            string jsonData = File.ReadAllText(filePath);
            var flightDataList = JsonConvert.DeserializeObject<List<FlightDate>>(jsonData);

            _flights.Clear();
            FlightsListBox.Items.Clear();

            foreach (var flightData in flightDataList)
            {
                Flight flight = new Flight
                {
                    DeparturePoint = flightData.DeparturePoint,
                    DestinationPoint = flightData.DestinationPoint,
                    DepartureDate = flightData.DepartureDate,
                    FlightTimeMinutes = flightData.FlightTimeMinutes,
                    TypeOfFlight = flightData.TypeOfFlight,

                };

                _flights.Add(flight);
                _flightsListBoxItems.Add($"{flight.DepartureDate.ToShortDateString()}: {flight.DeparturePoint} Ч {flight.DestinationPoint}");
                FlightsListBox.Items.Add($"{flight.DepartureDate.ToShortDateString()}: {flight.DeparturePoint} Ч {flight.DestinationPoint}");
            }
        }

        private void AirTravelForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "AirTravel");
            Directory.CreateDirectory(folderPath); // —оздаем папку, если она не существует
            string filePath = Path.Combine(folderPath, "flights_data.json");
            SaveDataToFile(filePath);
        }

        private void AirTravelForm_Load(object sender, EventArgs e)
        {
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "AirTravel");
            Directory.CreateDirectory(folderPath); // —оздаем папку, если она не существует
            string filePath = Path.Combine(folderPath, "flights_data.json");

            // «агрузка данных из файла
            LoadDataFromFile(filePath);
        }

        private void RemoveFlightButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = FlightsListBox.SelectedIndex;

            if (selectedIndex == -1) return;

            _flights.RemoveAt(selectedIndex);
            _flightsListBoxItems.RemoveAt(selectedIndex);
            FlightsListBox.Items.RemoveAt(selectedIndex);

            // FlightsListBox.SelectedIndex = FlightsListBox.Items.Count - 1;
            /*switch (SortedByComboBox.SelectedIndex)
            {
                case 0:
                    SortedByUpcomingDates();
                    break;
                case 1:
                    SortedByLaterDates();
                    break;
            }*/
            ClearFlighteInfo();
            /*DepartureTextBox.Text = "";
            DepartureTextBox.ReadOnly = true;

            DestinationTextBox.Text = "";
            DestinationTextBox.ReadOnly = true;

            FlightTimeTextBox.Text = "0";
            FlightTimeTextBox.Enabled = false;

            DepartureDateTimePicker.Enabled = false;

            TypeOfFlightComboBox.Enabled = false;*/

        }

        private void SortedByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (SortedByComboBox.SelectedIndex)
            {
                case 0:
                    SortedByUpcomingDates();
                    break;
                case 1:
                    SortedByLaterDates();
                    break;
            }

            ClearFlighteInfo();
        }

    }
}
