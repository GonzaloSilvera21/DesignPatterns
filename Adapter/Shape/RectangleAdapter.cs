namespace Adapter.Shape
{
    public class RectangleAdapter : IShape
    {
        private readonly Rectangle _rectangle;

        public RectangleAdapter(Rectangle rectangle) => _rectangle = rectangle;

        public double Area => _rectangle.GetArea();
    }
}
