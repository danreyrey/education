namespace InterfacesExercise
{
    public class Parrot : Bird, IFly, IWalk
    {
        public void Fly()
        {
            Console.WriteLine("I fly through the air like a parrot!");
        }

        public void Walk()
        {
            Console.WriteLine("I walk around like a parrot!");
        }
    }
}
