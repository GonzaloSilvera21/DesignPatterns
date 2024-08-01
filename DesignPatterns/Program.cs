using Builder.Computer;

ComputerDirector director = new ComputerDirector();

IComputerBuilder gamingBuilder = new GamingComputerBuilder();
director.Construct(gamingBuilder);
Computer gamingComputer = gamingBuilder.GetComputer();
Console.WriteLine("Gaming Computer: " + gamingComputer);

IComputerBuilder officeBuilder = new OfficeComputerBuilder();
director.Construct(officeBuilder);
Computer officeComputer = officeBuilder.GetComputer();
Console.WriteLine("Office Computer: " +  officeComputer);
