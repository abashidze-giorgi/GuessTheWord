using GuessTheWord.Interfaces;
using GuessTheWord.Domain.Models;

namespace GuessTheWord.Logic
{
    public class CheckAnswer : ICheckAnswer
    {
        public List<int> CheckUserAnswer(AnswerModel model)
        {
            string secretText = model.SecretText;
            string answerText = model.AnswerText;

            List<int> exactMatched = ExactMatchedComparisson(secretText, answerText);

            return exactMatched;
        }
       
        private List<int> ExactMatchedComparisson(string word1, string word2)
        {
            List<int> matchedSymbols = new List<int> { 0, 0 };
            int lenght = word1.Length;
            string tempWord1 = word1;
            string tempWord2 = word2;
            for (int i = lenght - 1; i >= 0; i--)
            {
                if (word1[i] == word2[i])
                {
                    tempWord1 = tempWord1.Remove(i, 1);
                    tempWord2 = tempWord2.Remove(i, 1);
                    matchedSymbols[0]++;
                }
            }
            int remainingLenght = tempWord1.Length;
            for (int i = remainingLenght - 1; i >= 0; i--)
            {
                for (int x = tempWord2.Length - 1; x >= 0; x--)
                {
                    if (tempWord2[x] == tempWord1[i])
                    {
                        tempWord2 = tempWord2.Remove(x, 1);
                        tempWord1 = tempWord1.Remove(i, 1);
                        matchedSymbols[1]++;
                        break;
                    }
                }
            }
            return matchedSymbols;
        }
    }
}
