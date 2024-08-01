namespace AbstractFactory.VehiculoFactory
{
    public class MotocicletaFactory : IVehiculoFactory
    {
        public IMotor CrearMotor() => new MotorMotocicleta();

        public IVehiculo CrearVehiculo() => new Motocicleta();
    }
}
