namespace Shapes
{
    public class Rectangle : Shape
    {
        private readonly double height;
        private readonly double width;

        public Rectangle(double height, double width)
        {
            this.height = height;
            this.width = width;
        }

        public override double CalculateArea()
        {
            return height * width;
        }

        public override double CalculatePerimeter()
        {
            return (height + width) * 2;
        }

        public override string Draw()
        {
            return base.Draw() + nameof(Rectangle);
        }
    }
}