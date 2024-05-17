using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Drawing;

namespace _8_laba.Model.Classes
{
    internal class FlightDate
    {
        public string DeparturePoint { get; set; }
        public string DestinationPoint { get; set; }
        public DateTime DepartureDate { get; set; }
        public int FlightTimeMinutes { get; set; }
        public TypesOfFlight TypeOfFlight { get; set; }
        
    }
}
