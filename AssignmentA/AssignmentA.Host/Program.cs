using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentA.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var booking = new Booking();
                var Origin = new City();
                var Destination = new City();
                var fraudChecker = new FraudChecker();

                Console.WriteLine("Enter your details : ");
                Console.WriteLine("\n TravelerName : ");
                booking.TravelerName = Console.ReadLine();
                Console.WriteLine("\n TravelDate : ");
                booking.TravelDate = Convert.ToDateTime(Console.ReadLine());
                //Console.WriteLine("\n ReturnDate : ");
                //booking.ReturnDate = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("\n TotalFare : ");
                booking.TotalFare = Convert.ToDecimal(Console.ReadLine());
                //Console.WriteLine("\n BookingDate : ");
                //booking.BookingDate = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("\n IsRoundTrip : ");
                booking.IsRoundTrip = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine("\n Origin City Name : ");
                //booking.Origin.Name = Console.ReadLine();
                //booking.Origin.CityCode = Console.ReadLine();
                booking.Origin.CountryCode = Console.ReadLine();
                Console.WriteLine("\n Destination City Name : ");
                //booking.Destination.Name = Console.ReadLine();
                //booking.Destination.CityCode = Console.ReadLine();
                booking.Destination.CountryCode = Console.ReadLine();

                Console.WriteLine("\n Name on Card : ");
                booking.Card.NameOnCard = Console.ReadLine();
                //Console.WriteLine("\n CardNumber : ");
                //booking.Card.CardNumber = Console.ReadLine();
                //booking.Card.ExpiryMMYY = Console.ReadLine();

                Console.WriteLine("\n\n Booking is Fraud : " + fraudChecker.IsFraudBooking(booking));
            }

            catch (ArgumentException a)
            {
                Console.WriteLine(a.Message);
            }
            Console.ReadKey();
        }
    }
}
