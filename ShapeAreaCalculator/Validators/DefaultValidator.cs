namespace ShapeAreaCalculator.Validators
{
    public class DefaultValidator : Validator
    {
        protected const string DefaultValidationFailedMessage = "Shape name is forbidden. Choose another.";

        private Shape _shape;

        public Shape Shape
        {
            get => _shape;
            private set => _shape = value;
        }

        public DefaultValidator(Shape shape)
        {
            Shape = shape;
        }

        public override bool IsValid()
        {
            if (Shape.Name != "Some forbidden name")
                return base.IsValid();
            else
            {
                ResultMessage = DefaultValidationFailedMessage;
                return false;
            }

        }
    }
}
