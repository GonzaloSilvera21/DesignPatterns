namespace Builder.Computer
{
    public class Computer
    {
        public string CPU {  get; set; }
        public string GPU { get; set; }
        public string RAM { get; set; }
        public string Storage { get; set; }
        public string PowerSupply { get; set; }

        public override string ToString() => $"CPU: {CPU}, GPU: {GPU}, RAM: {RAM}, Storage: {Storage}, PowerSupply: {PowerSupply}";
    }
}
