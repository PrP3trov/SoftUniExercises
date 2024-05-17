namespace Shapes
{
    public class Circle : Shape
    {
        public Circle(double r)
        {
            R = r;
        }

        public double R { get; set; }
        public override double CalculateArea()
        {
            return Math.PI * (R * R);
        }

        public override double CalculatePerimeter()
        {
           return 2 * Math.PI * R;
        }
        public override string Draw()
        {
            return base.Draw();

        }
    }
}
