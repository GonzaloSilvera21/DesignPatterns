namespace AbstractFactory.VehiculoFactory
{
    public interface IVehiculoFactory
    {
        IVehiculo CrearVehiculo();
        IMotor CrearMotor();
    }
}
