using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentA
{
    public class FraudChecker
    {
        public bool IsFraudBooking(Booking booking)
        {
            if (booking == null)
            {
                throw new System.Exception();
            }
            {
                FraudConditions condition = new FraudConditions();
                var condition1 = condition.NotOwner(booking.TravelerName, booking.Card.NameOnCard);
                var condition2 = condition.InternationalBooking(booking.Origin.CountryCode);
                var condition3 = condition.BookingAmount(booking.TotalFare);
                var condition4 = condition.OneWayBooking(booking.IsRoundTrip);
                var condition5 = condition.FraudDestinations(booking.Destination.CountryCode);
                var condition6 = condition.TravelTime(booking.TravelDate);
                var condition7 = condition.SuccessiveBookings(booking.Card.CardNumber);
                bool[] conditionArr = { condition1, condition2, condition3, condition4, condition5 };

                if (condition7 == true)
                    return true;
                else if ((condition3 == true && condition6 == true) || (FraudCount(conditionArr) > 1))
                    return true;
                else
                    return false;
            }
        }

        public int FraudCount(bool[] arr)
        {
            int count = 0;
            for (var i = 0; i < arr.Length; i++)
            {
                if (arr[i] == true)
                    count++;
            }
            return count;
        }
    }
}
