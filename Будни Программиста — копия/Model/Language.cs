using System.Security.Policy;

namespace Будни_Программиста.Model
{
    internal class Language
    {
        public string? Name;
        public string? PathPicture;
        public bool IsSelected;

        public static Language Create(string name, string pathPicture, bool isSelected = false)
        {
            Language language = new()
            {
                Name = name,
                PathPicture = pathPicture,
                IsSelected = isSelected
            };
            return language;
        }
    }
}
