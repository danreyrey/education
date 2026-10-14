namespace Exercise_2025_12_09_OOP
{
    public class Cat : Animal
    {
        private string FurColor;

        public Cat (string animalSpecies, int age, bool isFemale, string furColor) : base (animalSpecies, age, isFemale)
        {
            FurColor = furColor;
        }

        public string GetFurColor() => FurColor;

        public void SetFurColor(string newFurColor) => FurColor = newFurColor;

    }
}
