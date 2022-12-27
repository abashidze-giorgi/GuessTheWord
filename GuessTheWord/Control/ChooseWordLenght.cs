using GuessTheWord.Interfaces;

namespace GuessTheWord.Control
{
    internal class ChooseWordLenght : IChooseWordLenght
    {
        public int ChooseRandomInt(int min, int max)
        {
            Random rnd = new Random();
            return rnd.Next(min, max);
        }
    }
}
