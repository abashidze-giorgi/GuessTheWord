namespace GuessTheWord.Control
{
    public class GetRandomWord
    {
        public static string GetRandomWordFromFiles()
        {
            ChooseWordLenght randomLenght = new ChooseWordLenght();
            readWordFile readFile = new readWordFile();
            ChooseRandomWord rndWord = new ChooseRandomWord();

            int minWordLenght = 4;
            int maxWordLenght = 7;

            var wordLenght = randomLenght.ChooseRandomInt(minWordLenght, maxWordLenght + 1);
            List<string> wordList = readFile.ReadWords(wordLenght);

            return rndWord.ChooseWord(wordList);
        }
    }
}
