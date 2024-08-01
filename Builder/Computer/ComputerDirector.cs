namespace Builder.Computer
{
    public class ComputerDirector
    {
        public void Construct(IComputerBuilder builder)
        {
            builder.SetCPU();
            builder.SetGPU();
            builder.SetRAM();
            builder.SetStorage();
            builder.SetPowerSupply();
        }
    }
}
