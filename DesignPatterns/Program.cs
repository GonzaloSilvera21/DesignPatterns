
using Builder.Car;
using Builder.Conceptual;

var director = new Builder.Car.Director();
CarBuilder builder = new CarBuilder();
director.ConstructSportCar(builder);

Car car = builder.GetCar();

Console.WriteLine(car);

ManualBuilder manualBuilder = new ManualBuilder();
director.ConstructSportCar(manualBuilder);

Manual manual = manualBuilder.GetManual();
Console.WriteLine(manual);