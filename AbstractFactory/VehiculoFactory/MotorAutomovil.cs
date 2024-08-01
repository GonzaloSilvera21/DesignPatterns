namespace AbstractFactory.VehiculoFactory
{
    public class MotorAutomovil : IMotor
    {
        public void Arrancar() => Console.WriteLine("Arrancando el motor de un automóvil...");
    }
}
