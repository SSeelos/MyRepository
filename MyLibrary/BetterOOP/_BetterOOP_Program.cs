using System.Collections.Generic;

namespace MyLibrary.BetterOOP
{
    class BetterOOP_Program : IProgram
    {

        public void Run()
        {
            List<IRental> rentals = new List<IRental>();

            rentals.Add(new Truck() { CurrentRenter = "Truck renter" });
            rentals.Add(new Car() { CurrentRenter = "Car renter" });
            rentals.Add(new Sailboat() { CurrentRenter = "Truck renter" });


            int numberOfTrucks = 0;
            decimal totalPrice = 0;
            foreach (var item in rentals)
            {
                totalPrice += item.PricePerDay;

                if (item is Truck truck) numberOfTrucks++;
            }
        }
    }
}
