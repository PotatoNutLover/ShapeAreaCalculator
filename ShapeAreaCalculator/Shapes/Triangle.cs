using ShapeAreaCalculator.Validators;

namespace ShapeAreaCalculator.Shapes
{
    public class Triangle : Shape
    {
        private double _sideA, _sideB, _sideC;
        private DefaultTriangleValidator _validator;

        public double SideA
        {
            get => _sideA;
            set
            {
                if (value >= 0)
                    _sideA = value;
                else
                    throw new ArgumentException($"Side ({value}) must be positive");
            }
        }

        public double SideB
        {
            get => _sideB;
            set
            {
                if (value >= 0)
                    _sideB = value;
                else
                    throw new ArgumentException($"Side ({value}) must be positive");
            }
        }

        public double SideC
        {
            get => _sideC;
            set
            {
                if (value >= 0)
                    _sideC = value;
                else
                    throw new ArgumentException($"Side ({value}) must be positive");
            }
        }

        public DefaultTriangleValidator Validator
        {
            get => _validator;
            set => _validator = value;
        }

        public Triangle (string name, double sideA, double sideB, double sideC) : base(name)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            Validator = new TriangleIsoscelesValidator(this);
        }

        public override double CalculateArea()
        {
            if (Validator.IsValid())
                return CalculateTriangleArea();
            else
                throw new Exception($"Triangle is not valid. {Validator.ResultMessage}");
        }

        private double CalculateTriangleArea()
        {
            double p = (SideA + SideB + SideC) / 2;
            double h = 2/SideA * Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));

            double area = (SideA * h) / 2;

            return area;
        }
    }
}
