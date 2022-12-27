using System.ComponentModel;
using System.Globalization;
using System.Configuration;

namespace GuessTheWord.Domain.Models
{
    public class LocalizationClass
    {
        public void SetLocalisation(Form form, Type type)
        {
            var language = Properties.Settings.Default.LanguageString;
            Thread.CurrentThread.CurrentCulture = new CultureInfo(language);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(language);
        }
    }
}
