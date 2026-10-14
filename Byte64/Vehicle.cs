namespace Byte64
{
    public abstract class Vehicle
    {
        private double SizeInCm { get; set; }
        public double WeightInKg { get; set; }
        public string Color { get; set; }

        public Vehicle(double sizeInCm, double weightInKg, string color)
        {
            SizeInCm = sizeInCm;
            WeightInKg = weightInKg;
            Color = color;
        }

        public void Repaint(string newColor)
            => Color = newColor;

        public abstract void Move();
    }
}
