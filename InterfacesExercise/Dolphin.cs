namespace InterfacesExercise
{
    public class Dolphin : Mammal, ISwim
    {
        public void Swim()
        {
            Console.WriteLine("I swim through the water like a dolphin!");
        }
    }
}
