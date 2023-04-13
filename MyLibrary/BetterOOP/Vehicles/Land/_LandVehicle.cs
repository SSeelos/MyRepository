namespace MyLibrary_DotNETstd_2_1.BetterOOP
{
    public abstract class _LandVehicle
    {
        public int NumberOfPassengers { get; set; }

        public virtual void StartEngine()
        {
            //do start
        }
        public virtual void StopEngine()
        {
            //do stop
        }
    }
}
