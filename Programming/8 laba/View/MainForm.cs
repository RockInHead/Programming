namespace _8_laba
{
    public partial class MainForm : Form
    {
        Random random = new Random();
        private List<Flight> _flights = new List<Flight>();
        private Flight _currentFlight = new Flight();
        private List<string> _flightsListBoxItems = new List<string>();
        private string[] Cities = (string[])Enum.GetNames(typeof(Cities));

        public void CanvaRectangleInitiaziation()
        {
            for (int i = 0; i < 5; i++)
            {
                string departute = Cities[random.Next(0, Cities.Length)];
                string destination = Cities[random.Next(0, Cities.Length)];
                int flightDuration = random.Next(60, 600);

            }
            foreach (string el in CanvaRectanglesListBoxItems)
            {
                CanvaRectanglesListBox.Items.Add(el);
            }
            FindCollision();
        }
        public MainForm()
        {
            InitializeComponent();
        }
        
     
    }
}
