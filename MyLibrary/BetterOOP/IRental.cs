namespace MyLibrary_DotNETstd_2_1.BetterOOP
{
    public interface IRental
    {
        int RentalId { get; }
        string CurrentRenter { get; }
        decimal PricePerDay { get; }

    }
}
