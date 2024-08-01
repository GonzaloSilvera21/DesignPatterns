namespace AbstractFactory.VehiculoFactory
{
    public class Automovil : IVehiculo
    {
        public void Conducir() => Console.WriteLine("Conduciendo un automóvil");
    }
}
