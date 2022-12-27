using GuessTheWord.Interfaces;

namespace GuessTheWord.Control
{
    public class readWordFile : IReadWordFile
    {
        public List<string> ReadWords(int charCount)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string filePath = Path.Combine(currentDirectory, $"Domain\\TextFiles\\Words{charCount}.txt");
            List<String> wordList = File.ReadAllLines(filePath).ToList();
            return wordList;
        }
    }
}
