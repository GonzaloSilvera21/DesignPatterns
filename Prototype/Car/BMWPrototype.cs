namespace Prototype.Car
{
    public class BMWPrototype : CarPrototype
    {
        public override CarPrototype Clonar() => (BMWPrototype)MemberwiseClone();

        public override string SeeCar() => $"BMW, model: {_model}, color: {_color}";
    }
}
