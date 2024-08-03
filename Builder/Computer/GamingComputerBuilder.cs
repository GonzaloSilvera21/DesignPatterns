﻿namespace Builder.Computer
{
    public class GamingComputerBuilder : IComputerBuilder
    {
        private Computer _computer = new Computer();
        public Computer GetComputer() => _computer;

        public void SetCPU() => _computer.CPU = "Intel i9";

        public void SetGPU() => _computer.GPU = "NVIDIA RTX 3080";

        public void SetRAM() => _computer.RAM = "32GB";

        public void SetStorage() => _computer.Storage = "1TB SSD";

        public void SetPowerSupply() => _computer.PowerSupply = "850W";

    }
}