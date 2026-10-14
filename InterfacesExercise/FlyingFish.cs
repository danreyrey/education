namespace InterfacesExercise
{
    public class FlyingFish : Animal, ISwim, IFly
    {
        public void Swim()
        {
            Console.WriteLine("I swim through the water like a flying fish!");
        }

        public void Fly()
        {
            Console.WriteLine("I fly through the air like a flying fish!");
        }
    }
}
