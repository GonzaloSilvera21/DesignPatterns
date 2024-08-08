namespace Adapter.Shape
{
    public class Rectangle
    {
        private double _width;
        private double _height;

        public Rectangle(double width, double height)
        {
            _width = width;
            _height = height;
        }

        public double GetArea() => _width * _height;
    }
}
