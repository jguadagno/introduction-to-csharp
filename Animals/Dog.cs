using Logging;

namespace Animals
{
    public class Dog : Animal
    {
        public string CollarColor { get; set; }

        public readonly string MySpecies = "Canine";

        public void Speak(params string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                Logger.Log(words[i]);
            }
        }
    }
}