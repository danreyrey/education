namespace Byte64
{
    public class Car : Vehicle
    {
        public int DoorCount { get; }

        public Car(double sizeInCm, double weightInKg, string color, int doors)
            : base(sizeInCm, weightInKg, color)
        {
            DoorCount = doors;
        }

        public override void Move()
        {
            Console.Write("The car drives");
        }
    }
}
