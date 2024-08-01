namespace AbstractFactory.VehiculoFactory
{
    public class Motocicleta : IVehiculo
    {
        public void Conducir() => Console.WriteLine("Conduciendo una motocicleta...");
    }
}
