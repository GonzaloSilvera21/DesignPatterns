namespace Prototype.Car
{
    public class VWPrototype : CarPrototype
    {
        public override CarPrototype Clonar() => (BMWPrototype)MemberwiseClone();

        public override string SeeCar() => $"VW, model: {_model}, color: {_color}";
    }
}
