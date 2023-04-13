namespace MyLibrary_DotNETstd_2_1.BetterOOP
{
    public class Sailboat : IRental
    {
        public int RentalId { get; set; }

        public string CurrentRenter { get; set; }

        public decimal PricePerDay { get; set; }
    }
}
