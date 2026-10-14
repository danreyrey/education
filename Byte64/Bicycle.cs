namespace Byte64
{
    internal class Bicycle : TwoWheeler
    {
        public Bicycle(double sizeInCm, double weightInKg, string color, int decibels)
            : base(sizeInCm, weightInKg, color, decibels)
        {
        }

        public override void Move()
        {
            Console.WriteLine("The bicycle rides");
        }
    }
}
