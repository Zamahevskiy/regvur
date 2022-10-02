using System;
using System.Text.RegularExpressions;

namespace regvur
{
    public class Timetable
    {
        public void uTimetable()
        {
            string ras = "Утром: подъём 07:00, сижу в интернете(просыпаюсь) 07:30, путешествие в ад 08:00, завтрак 13:30. " +
                    "Вечером: зарядка 17:00, душ 17:30, обед 17:40, въетнамские флешбеки 666:999, ужин 00:00, отбой 02:00";
            Regex regex = new Regex(@"\b(?:[01][0-9]|2[0-3]):[0-5][0-9]\b");
            MatchCollection matches = regex.Matches(ras);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                    Console.WriteLine(match.Value);
            }
        }
    }
}