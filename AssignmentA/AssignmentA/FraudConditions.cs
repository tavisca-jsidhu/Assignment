﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentA
{
    class FraudConditions : IFraudConditions
    {
        public bool NotOwner(string _travellerName, string _nameOnCard)
        {
            if (_travellerName == _nameOnCard)
                return false;
            return true;
        }

        public bool InternationalBooking(string _cityName)
        {
            if (_cityName == "USA")
                return false;
            return true;
        }

        public bool BookingAmount(decimal _totalFare)
        {
            if (_totalFare < 1000)
                return false;
            return true;
        }

        public bool OneWayBooking(bool _isRoundTrip)
        {
            if (_isRoundTrip)
                return false;
            return true;
        }

        public bool FraudDestinations(string _countryName)
        {
            if (_countryName != "nigeria")
                return false;
            return true;
        }

        public bool TravelTime(DateTime _travelDate)
        {
            if ((_travelDate - DateTime.Now).TotalHours > 48)
                return false;
            return true;
        }
    }
}
