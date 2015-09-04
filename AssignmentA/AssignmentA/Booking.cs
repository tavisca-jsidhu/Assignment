using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentA
{

    public class Booking
    {
        public string TravelerName { get; set; }

        public City Origin { get; set; }

        public City Destination { get; set; }

        public decimal TotalFare { get; set; }

        public Card Card { get; set; }

        public DateTime BookingDate { get; set; }

        public DateTime TravelDate { get; set; }

        public DateTime ReturnDate { get; set; }

        public bool IsRoundTrip { get; set; }

        public Booking()
        {
            Origin = new City();
            Destination = new City();
            Card = new Card();
        }
    }
}
