namespace ShapeAreaCalculator
{
    public abstract class Shape
    {
        private string _name;

        public string Name
        {
            get => _name;
            set => _name = value.Trim();
        }

        public Shape (string name)
        {
            Name = name;
        }

        public virtual double CalculateArea()
        {
            return 0;
        }
    }
}
