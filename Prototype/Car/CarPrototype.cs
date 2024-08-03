namespace Prototype.Car
{
    public abstract class CarPrototype
    {
        protected string _color;
        protected string _model;

        public string Color { set { _color = value; } }
        public string Model { set { _model = value; } }

        public abstract CarPrototype Clonar();
        public abstract string SeeCar();
    }
}
