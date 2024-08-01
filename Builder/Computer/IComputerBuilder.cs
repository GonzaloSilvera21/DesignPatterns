namespace Builder.Computer
{
    public interface IComputerBuilder
    {
        void SetCPU();
        void SetGPU();
        void SetRAM();
        void SetStorage();
        void SetPowerSupply();
        Computer GetComputer();
    }
}
