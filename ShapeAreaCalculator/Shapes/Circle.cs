using ShapeAreaCalculator.Validators;

namespace ShapeAreaCalculator.Shapes
{
    public class Circle : Shape
    {
        private double _radius;
        private DefaultValidator _validator;

        public double Radius
        {
            get => _radius;
            set
            {
                if (value >= 0)
                    _radius = value;
                else
                    throw new ArgumentException($"Radius ({value}) must be positive");
            }
        }

        public DefaultValidator Validator
        {
            get => _validator;
            set => _validator = value;
        }

        public Circle(string name, double radius) : base(name)
        {
            Radius = radius;
            Validator = new DefaultValidator(this);
            
        }

        public override double CalculateArea()
        {
            if (Validator.IsValid())
                return CalculateCircleArea();
            else
                throw new Exception($"Circle is not valid. {Validator.ResultMessage}");
        }

        private double CalculateCircleArea()
        {
            double shape = Math.PI * Math.Pow(_radius, 2);
            return shape;
        }
    }
}
