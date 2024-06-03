namespace Будни_Программиста.Model
{
    internal class DatesChoice
    {
        public string? Date;
        public List<Language>? Languages;

        public static DatesChoice Create(string? date, List<Language>? languages)
        {
            var newDate = new DatesChoice
            {
                Date = date,
                Languages = languages
            };
            return newDate;
        }
    }
}
