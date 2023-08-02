using ShapeAreaCalculator.Shapes;

namespace ShapeAreaCalculator.Validators
{
    public class TriangleIsoscelesValidator : DefaultTriangleValidator
    {
        public TriangleIsoscelesValidator(Triangle triangle) : base(triangle) { }

        public override bool IsValid()
        {
            if (IsNotTriangleIsosceles())
                return base.IsValid();
            else
            {
                ResultMessage = "Triangle is Isosceles";
                return false;
            }
        }

        private bool IsNotTriangleIsosceles()
        {
            double a = Triangle.SideA;
            double b = Triangle.SideB;
            double c = Triangle.SideC;

            if (a == b || a == c || b == c)
                return false;
            else
                return true;
        }
    }
}
