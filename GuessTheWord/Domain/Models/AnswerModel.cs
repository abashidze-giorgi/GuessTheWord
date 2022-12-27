namespace GuessTheWord.Domain.Models
{
    public class AnswerModel
    {
        public string SecretText { get; set; }
        public string AnswerText { get; set; }
        public List<int> Positions { get; set; } = new List<int>();
    }
}
