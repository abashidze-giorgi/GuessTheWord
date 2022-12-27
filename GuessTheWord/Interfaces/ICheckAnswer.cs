using GuessTheWord.Domain.Models;

namespace GuessTheWord.Interfaces
{
    public interface ICheckAnswer
    {
        public List<int> CheckUserAnswer(AnswerModel model);
    }
}
