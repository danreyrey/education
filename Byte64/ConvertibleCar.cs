namespace Byte64
{
    public class ConvertibleCar : Car
    {
        public ConvertibleCar(double sizeInCm, double weightInKg, string color, int doors)
            : base(sizeInCm, weightInKg, color, doors)
        {
        }

        public override void Move()
        {
            base.Move();
            Console.WriteLine(" and the roof is open");
        }
    }
}
