using AbstractFactory.VehiculoFactory;

IVehiculoFactory vehiculoFactory;
IVehiculo vehiculo;
IMotor motor;

// Automovil
vehiculoFactory = new AutomovilFactory();
vehiculo = vehiculoFactory.CrearVehiculo();
motor = vehiculoFactory.CrearMotor();

motor.Arrancar();
vehiculo.Conducir();

Console.WriteLine("\n");

// Motocicleta
vehiculoFactory = new MotocicletaFactory();
vehiculo = vehiculoFactory.CrearVehiculo();
motor = vehiculoFactory.CrearMotor();

motor.Arrancar();
vehiculo.Conducir();