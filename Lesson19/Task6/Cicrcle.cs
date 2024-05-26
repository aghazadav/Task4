namespace Task6
{
    internal class Circle
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double CalculateCircumference()
        {
            return 2 * Math.PI * radius;
        }
    }
}
