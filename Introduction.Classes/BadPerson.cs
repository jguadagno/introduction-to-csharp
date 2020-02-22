namespace Introduction.Classes
{
    public class BadPerson
    {
        // Field
        public string Name; // DO NOT DO THIS

        // Constructor that takes no arguments.
        public BadPerson()
        {
            Name = "unknown";
        }

        // Constructor that takes one argument.
        public BadPerson(string nm) // DO NOT DO THIS
        {
            Name = nm;
        }

        // Method
        public void SetName(string newName)
        {
            Name = newName;
        }
    }
}
