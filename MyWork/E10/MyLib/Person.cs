using System;

namespace MyLib
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                string fullName = "";
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    fullName += FirstName;
                }
                if (!string.IsNullOrWhiteSpace(LastName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                        fullName = $"{fullName} {LastName}";
                    else
                        fullName += LastName;
                }
                return fullName;
            }
        }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

    }
}
