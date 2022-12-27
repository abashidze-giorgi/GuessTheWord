using GuessTheWord.Interfaces;

namespace GuessTheWord.Control
{
    public class ChooseRandomWord : IChooseRandomWord
    {
        public string ChooseWord(List<string> wordList)
        {
            int listSize = wordList.Count;
            Random rnd = new Random();
            return wordList[rnd.Next(0, listSize)];
        }
    }
}
