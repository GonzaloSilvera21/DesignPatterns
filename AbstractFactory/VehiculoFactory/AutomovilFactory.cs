namespace AbstractFactory.VehiculoFactory
{
    public class AutomovilFactory : IVehiculoFactory
    {
        public IMotor CrearMotor() => new MotorAutomovil();

        public IVehiculo CrearVehiculo() => new Automovil();
    }
}
