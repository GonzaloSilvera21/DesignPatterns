namespace Builder.Car
{
    public class CarBuilder : IBuilder
    {
        private Car _car;

        public CarBuilder() => Reset();

        public void Reset() => _car = new Car();

        public void SetEngine() => Console.WriteLine("Set Car Engine");

        public void SetGPS() => Console.WriteLine("Set Car GPS");

        public void SetSeats() => Console.WriteLine("Set Car Seats");

        public void SetTripComputer() => Console.WriteLine("Set Car Trip Computer");

        public Car GetCar() => _car;
    }
}
