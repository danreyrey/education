namespace InterfacesExercise
{
    public class FlyingSquirrel : Mammal, IFly, IWalk
    {
        public void Fly()
        {
            Console.WriteLine("I fly through the air like a flying squirrel!");
        }

        public void Walk()
        {
            Console.WriteLine("I walk around like a flying squirrel!");
        }
    }
}
