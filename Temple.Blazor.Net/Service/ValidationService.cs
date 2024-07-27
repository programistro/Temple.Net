using System.Globalization;

namespace Temple.Net.Service;

public class ValidationService
{
    public IEnumerable<string> Validation(string input)
    {
        CultureInfo culture = new CultureInfo("ru-RU");

        string[] formats = { "dd.MM.yyyy", "MM.yyyy", "yyyy" };

        DateOnly dateTime;

        bool sucess = DateOnly.TryParseExact(input, formats, culture, DateTimeStyles.None, out dateTime);

        if (!sucess)
        {
            yield return "Не правильно введёная дата";
        }
    }

    public IEnumerable<string> ValidationOnlyYear(string input)
    {
        CultureInfo culture = new CultureInfo("ru-RU");

        string[] formats = { "yyyy" };

        DateOnly dateTime;

        bool sucess = DateOnly.TryParseExact(input, formats, culture, DateTimeStyles.None, out dateTime);

        if (!sucess)
        {
            yield return "Не правильно введёная дата";
        }
    }
}