using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentA
{
    interface IFraudConditions
    {
        bool NotOwner(string _travellerName, string _nameOnCard);
        bool InternationalBooking(string _cityName);
        bool BookingAmount(decimal _totalFare);
        bool OneWayBooking(bool _isRoundTrip);
        bool FraudDestinations(string _countryName);
        bool TravelTime(DateTime _travelDate);
    }
}
