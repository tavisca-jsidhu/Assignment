using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AssignmentA.Tests
{
    [TestClass]
    public class TestCases
    {
        [TestMethod]
        public void TestMethod1()
        {
            Booking booking = new Booking();
            var fraudChecker = new FraudChecker();

            booking.TravelerName = "jas";
            booking.TravelDate = Convert.ToDateTime("09/05/2015 12:00:00 AM");
            booking.TotalFare = 1200;
            booking.IsRoundTrip = true;
            booking.Origin.CountryCode = "USA";
            booking.Destination.CountryCode = "India";
            booking.Card.NameOnCard = "jaspreet";

            Assert.IsTrue(fraudChecker.IsFraudBooking(booking));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Booking booking = new Booking();
            var fraudChecker = new FraudChecker();

            booking.TravelerName = "jas";
            booking.TravelDate = Convert.ToDateTime("09/15/2015 12:00:00 AM");
            booking.TotalFare = 900;
            booking.IsRoundTrip = false;
            booking.Origin.CountryCode = "USA";
            booking.Destination.CountryCode = "India";
            booking.Card.NameOnCard = "jaspreet";

            Assert.IsTrue(fraudChecker.IsFraudBooking(booking));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Booking booking = new Booking();
            var fraudChecker = new FraudChecker();

            booking.TravelerName = "jas";
            booking.TravelDate = Convert.ToDateTime("09/08/2015 12:00:00 AM");
            booking.TotalFare = 600;
            booking.IsRoundTrip = true;
            booking.Origin.CountryCode = "USA";
            booking.Destination.CountryCode = "nigeria";
            booking.Card.NameOnCard = "jas";

            Assert.IsFalse(fraudChecker.IsFraudBooking(booking));
        }

        [TestMethod]
        public void TestMethod4()
        {
            Booking booking = new Booking();
            var fraudChecker = new FraudChecker();

            booking.TravelerName = "jas";
            booking.TravelDate = Convert.ToDateTime("09/23/2015 12:00:00 AM");
            booking.TotalFare = 700;
            booking.IsRoundTrip = false;
            booking.Origin.CountryCode = "China";
            booking.Destination.CountryCode = "India";
            booking.Card.NameOnCard = "jas";

            Assert.IsTrue(fraudChecker.IsFraudBooking(booking));
        }

        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        public void TestMethod5()
        {
            Booking booking = new Booking();
            var fraudChecker = new FraudChecker();

            Assert.IsTrue(fraudChecker.IsFraudBooking(null));
        }
    }
}
