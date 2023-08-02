using ShapeAreaCalculator.Shapes;

namespace ShapeAreaCalculator.Validators
{
    public class DefaultTriangleValidator : Validator
    {
        private Triangle _triangle;

        public Triangle Triangle
        {
            get => _triangle;
            private set => _triangle = value;
        }

        public DefaultTriangleValidator(Triangle triangle)
        {
            Triangle = triangle;
        }

        public override bool IsValid()
        {
            return base.IsValid();
        }
    }
}
