using System;
using System.Linq;

namespace BibliographicalWorks
{
    public class Author
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        private readonly string[] NameJunctions = new[]
        {
            "da", "de", "do", "das", "dos"
        };

        public string GetName(string fullName)
        {
            var arrayNames = fullName.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (arrayNames.Length > 1)
            {
                for (int i = 0; i < arrayNames.Length; i++)
                {
                    if (i == 0)
                    {
                        FirstName = arrayNames[i];
                    }
                    else if (i == 1)
                    {
                        if (NameJunctions.Contains(arrayNames[i].ToLower()))
                        {
                            MiddleName = arrayNames[i].ToLower();
                        }
                        else
                        {
                            LastName = LastName + " " + arrayNames[i].ToUpper();
                        }
                    }
                    else
                    {
                        var name = NameJunctions.Contains(arrayNames[i].ToLower()) ? arrayNames[i].ToLower() : arrayNames[i].ToUpper();
                        LastName = LastName + " " + name;
                    }
                }
                return $"{LastName}, {FirstCharToUpper(FirstName)} {MiddleName}".TrimEnd();
            }
            else
            {
                return " " + fullName.ToUpper();
            }

        }

        public static string FirstCharToUpper(string FirstName)
        {
            switch (FirstName)
            {
                case null: throw new ArgumentNullException(nameof(FirstName));
                case "": throw new ArgumentException($"{nameof(FirstName)} não pode ser vazio.", nameof(FirstName));
                default: return FirstName.First().ToString().ToUpper() + FirstName.Substring(1);
            }
        }
    }
}
