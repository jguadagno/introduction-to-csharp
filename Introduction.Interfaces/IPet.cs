namespace Introduction.Interfaces
{
    public interface IPet
    {
        GenderEnum Gender { get; set; }
        string Name { get; set; }
        int NumberOfLegs { get; set; }
        int NumberOfLives { get; set; }

        void Speak(string whatToSay);
    }
}