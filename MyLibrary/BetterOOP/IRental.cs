namespace MyLibrary.BetterOOP
{
    public interface IRental
    {
        int RentalId { get; }
        string CurrentRenter { get; }
        decimal PricePerDay { get; }

    }
}
