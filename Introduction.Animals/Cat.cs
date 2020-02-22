namespace Introduction.Animals
{
    public class Cat: IAnimal, IPet
    {
        public int NumberOfLegs { get; set; }
        public int NumberOfLives { get; set; }
        public string Name { get; set; }
        public string Owner { get; set; }
    }
}
