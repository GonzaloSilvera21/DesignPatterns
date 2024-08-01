namespace Builder.Computer
{
    public class OfficeComputerBuilder : IComputerBuilder
    {
        private Computer _computer = new Computer();

        public Computer GetComputer() => _computer;

        public void SetCPU() => _computer.CPU = "Intel i5";

        public void SetGPU() => _computer.GPU = "Integrated";

        public void SetRAM() => _computer.RAM = "16GB";

        public void SetStorage() => _computer.Storage = "512GB SSD";

        public void SetPowerSupply() => _computer.PowerSupply = "500W";
    }
}
