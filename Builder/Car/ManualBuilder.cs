namespace Builder.Car
{
    public class ManualBuilder : IBuilder
    {
        private Manual _manual;

        public ManualBuilder() => Reset();

        public void Reset() => _manual = new Manual();

        public void SetEngine() => Console.WriteLine("Set Manual Engine");

        public void SetGPS() => Console.WriteLine("Set Manual GPS");

        public void SetSeats() => Console.WriteLine("Set Manual Seats");

        public void SetTripComputer() => Console.WriteLine("Set Manual Trip Computer");

        public Manual GetManual() => _manual;
        
    }
}
