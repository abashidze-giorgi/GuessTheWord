using GuessTheWord.Logic;
using GuessTheWord.Control;
using System.Globalization;
using GuessTheWord.Domain.Models;
using System.Configuration;
using GuessTheWord.Domain.Resources;

namespace GuessTheWord
{
    public partial class Form1 : Form
    {
        private protected string secretWord = "";
        private AnswerModel model = new AnswerModel();
        WrongAnswerModel wrongAnswer = new WrongAnswerModel();
        private bool hided = true;
        private int step = 0;
        public Form1()
        {
            InitializeComponent();
            Cmb_Language.SelectedIndex = Properties.Settings.Default.Language;
            GameOver();
            GetWord();
        }

        private void GetWord()
        {
            ClearDesck();
            secretWord = GetRandomWord.GetRandomWordFromFiles();
            MakeLabelTextSecreted();
            model.SecretText = secretWord;
        }

        #region Buttons
        private void Btn_answer_Click(object sender, EventArgs e)
        {
            UserAnswer();
        }

        private void Btn_reset_Click(object sender, EventArgs e)
        {
            GetWord();
        }
        private void Btn_show_Click(object sender, EventArgs e)
        {
            if (hided)
            {
                Lbl_secret_text.Text = secretWord;
                hided = false;
            }
            else
            {
                MakeLabelTextSecreted();
                hided = true;
            }
        }
        private void Txt_answer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                UserAnswer();
            }
        }
        private void Cmb_Language_DropDownClosed(object sender, EventArgs e)
        {
            Properties.Settings.Default.Language = Cmb_Language.SelectedIndex;
            Properties.Settings.Default.Save();
            switch (Cmb_Language.SelectedIndex)
            {
                case 0:
                    MessageBox.Show(GlobalStrings.changeLanguageMessageEn);
                    break;
                case 1:
                    MessageBox.Show(GlobalStrings.changeLanguageMessageRu);
                    break;
                case 2:
                    MessageBox.Show(GlobalStrings.changeLanguageMessageGe);
                    break;
            }
            SelectLanguage();
        }
       
        #endregion

        #region Help Voids
        private void StepUp()
        {
            step++;
            Lbl_step.Text = step.ToString();
        }
        private void UserAnswer()
        {
            try
            {
                model.AnswerText = Txt_answer.Text = Txt_answer.Text.ToLower();
                if (model.AnswerText == model.SecretText)
                {
                    StepUp();
                    GameOver("a");
                    Lbl_secret_text.Text = model.SecretText;
                    hided = false;

                }
                else
                {
                    if (!string.IsNullOrEmpty(model.AnswerText) && model.AnswerText.Length == model.SecretText.Length)
                    {
                        var checkAnswer = new CheckAnswer();
                        List<int> answerList = checkAnswer.CheckUserAnswer(model);
                        List_words.Items.Add(model.AnswerText);
                        List_positions.Items.Add($"Точное совп: {answerList[0]}, Присутс: {answerList[1]}");
                        StepUp();
                    }
                    else
                    {
                        switch (Cmb_Language.Text)
                        {
                            case "English":
                                MessageBox.Show(wrongAnswer.WrongAnswer[0]);
                                break;
                            case "ქართული":
                                MessageBox.Show(wrongAnswer.WrongAnswer[1]);
                                break;
                            case "Русский":
                                MessageBox.Show(wrongAnswer.WrongAnswer[2]);
                                break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
            }
            Txt_answer.Text = "";
            Txt_answer.Focus();
        }
        private void GameOver(string text = null)
        {
            if (text == null)
            {
                Lbl_gameover.Text = "";
            }
            else
            {
                string language = Cmb_Language.Text;
                var gameOver = new GameOverModel();
                switch (language)
                {
                    case "English":
                        Lbl_gameover.Text = $"{gameOver.GameOver[0]}{step}";
                        break;
                    case "ქართული":
                        Lbl_gameover.Text = $"{gameOver.GameOver[1]}{step}";
                        break;
                    case "Русский":
                        Lbl_gameover.Text = $"{gameOver.GameOver[2]}{step}";
                        break;
                }
            }
        }
        private void MakeLabelTextSecreted()
        {
            int secretTextLenght = secretWord.Length;
            Lbl_secret_text.Text = "";
            for (int i = 0; i < secretTextLenght; i++)
            {
                Lbl_secret_text.Text += "* ";
            }
        }
        private void ClearDesck()
        {
            List_words.Items.Clear();
            List_positions.Items.Clear();
            Txt_answer.Clear();
            Lbl_step.Text = "0";
            model.AnswerText = "";
            model.SecretText = "";
            Lbl_gameover.Text = "";
        }
        private void SelectLanguage()
        {

            switch (Cmb_Language.SelectedIndex)
            {
                case 0:
                    ChangeLanguage("en");
                    break;
                case 1:
                    ChangeLanguage("Ka-Ge");
                    break;
                case 2:
                    ChangeLanguage("ru-RU");
                    break;
            }
        }
        private void ChangeLanguage(string v)
        {
            Properties.Settings.Default.LanguageString = v;
            Properties.Settings.Default.Save();

            //var lenguageClass = new LocalizationClass();
            //lenguageClass.SetLocalisation(this, this.GetType());

            
        }

        #endregion
    }
}