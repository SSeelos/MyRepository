using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary.BetterOOP
{

    public class Car : _LandVehicle, IRental
    {
        public CarStyle Style { get; set; }
        public int RentalId { get; set; }

        public string CurrentRenter { get; set; }

        public decimal PricePerDay { get; set; }
    }
}
