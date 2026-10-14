namespace Byte64
{
    public class Airplane : Vehicle
    {
        public int MaxFlightAltitude { get; set; }

        public Airplane(double sizeInCm, double weightInKg, string color, int maxFlightAltitude)
            : base(sizeInCm, weightInKg, color)
        {
            MaxFlightAltitude = maxFlightAltitude;
        }

        public override void Move()
        {
            Console.WriteLine("The airplane flies");
        }
    }
}
