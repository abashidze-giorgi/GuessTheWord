namespace GuessTheWord.Domain.Models
{
    public class GameOverModel
    {
        public List<string> GameOver { get; set; } = new List<string>()
        {
            "You Have Won. Number of steps -",
            "თქვენ მოიგეთ. სვლების რაოდენობა -",
            "Вы выиграли. количество ходов -"
        };
    }
}
