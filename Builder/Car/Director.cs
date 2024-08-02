using Builder.Conceptual;

namespace Builder.Car
{
    public class Director
    {
        public void ConstructSportCar(IBuilder builder)
        {
            builder.Reset();
            builder.SetSeats();
            builder.SetEngine();
            builder.SetTripComputer();
            builder.SetGPS();
        }
    }
}
