namespace Builder.Car
{
    public interface IBuilder
    {
        void Reset();
        void SetSeats();
        void SetEngine();
        void SetTripComputer();
        void SetGPS();

    }
}
