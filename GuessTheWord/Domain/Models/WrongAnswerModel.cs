namespace GuessTheWord.Domain.Models
{
    public class WrongAnswerModel
    {
        public List<string> WrongAnswer { get; set; } = new List<string>
        {
            "Enter the correct word. the number of letters must match the number of letters in the secret word",
            "შეიყვანეთ სწორი სიტყვა. ასოების რაოდენობა უნდა შეესაბამებოდეს საიდუმლო სიტყვის ასოების რაოდენობას",
            "Введите правильное слово. количество букв должно совпадать с количеством букв секретного слова."
        };
    }
}
