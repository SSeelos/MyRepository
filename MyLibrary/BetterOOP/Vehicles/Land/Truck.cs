using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary.BetterOOP
{
    public class Truck : _LandVehicle, IRental
    {
        public TruckStyle Style { get; set; }
        public int RentalId { get; set; }

        public string CurrentRenter { get; set; }

        public decimal PricePerDay { get; set; }
    }
}
