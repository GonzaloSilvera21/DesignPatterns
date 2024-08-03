namespace Prototype.Car
{
    public class KIAPrototype : CarPrototype
    {
        public override CarPrototype Clonar() => (KIAPrototype)MemberwiseClone();

        public override string SeeCar() => $"KIA, model: {_model}, color: {_color}";
    }
}
