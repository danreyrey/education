namespace InterfacesExercise
{
    public class Perch : Fish, ISwim
    {
        public void Swim()
        {
            Console.WriteLine("I swim through the water like a perch!");
        }
    }
}
