namespace InterfacesExercise
{
    public class Penguin : Bird, ISwim, IWalk
    {
        public void Swim()
        {
            Console.WriteLine("I swim through the water like a penguin!");
        }

        public void Walk()
        {
            Console.WriteLine("I walk around like a penguin!");
        }
    }
}
