namespace AbstractFactory.VehiculoFactory
{
    public class MotorMotocicleta : IMotor
    {
        public void Arrancar() => Console.WriteLine("Arrancando el motor de una motocicleta...");
    }
}
