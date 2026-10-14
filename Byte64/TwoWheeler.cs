namespace Byte64
{
    public abstract class TwoWheeler : Vehicle
    {
        public int Decibels { get; }

        public TwoWheeler(double sizeInCm, double weightInKg, string color, int decibels)
            : base(sizeInCm, weightInKg, color)
        {
            Decibels = decibels;
        }
    }
}
