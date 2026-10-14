namespace Exercise_2025_12_09_OOP
{
    public abstract class Animal
    {

        private string animalSpecies;

        private int Age;
        private bool IsFemale; 

        public Animal (string animalSpecies, int age, bool isFemale)
        {
            this.animalSpecies = animalSpecies;
            this.Age = age;
            this.IsFemale = isFemale;
        }

        public string GetAnimalSpecies() => this.animalSpecies;
        //{
        //    return this.animalSpecies;
        //}

        public void SetAnimalSpecies(string newAnimalSpecies) => this.animalSpecies = newAnimalSpecies;
        //{
        //    this.animalSpecies = newAnimalSpecies;
        //}

        public int GetAge() => this.Age;
        //{
        //    return this.Age;
        //}

        public void SetAge(int newAge) => this.Age = newAge;
        //{
        //    this.Age = newAge;
        //}

        public bool GetIsFemale() => this.IsFemale;
        //{
        //    return this.IsFemale;
        //}

        public void SetIsFemale(bool newIsFemale) => this.IsFemale = newIsFemale;
        //{
        //    this.IsFemale = newIsFemale;
        //}
    }
}
