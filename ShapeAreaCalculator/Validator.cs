namespace ShapeAreaCalculator
{
    public abstract class Validator
    {
        protected const string ValidationPassedMessage = "Validation Passed";
        protected const string ValidationFailedMessage = "Validation Passed";

        private string _resultMessage;

        public string ResultMessage
        {
            get => _resultMessage;
            protected set => _resultMessage = value.Trim();
        }

        public Validator()
        {
            _resultMessage = string.Empty;
        }

        public virtual bool IsValid()
        {
            _resultMessage = ValidationPassedMessage;
            return true;
        }
    }
}
