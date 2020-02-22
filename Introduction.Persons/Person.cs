using System;
using System.Collections.Generic;
using Logging;

namespace Introduction.Persons
{
    public class Person
    {
        // Fields
        private List<Person> _children;
        private string _firstName = "Default";

        public const string Male = "Male";
        public const string Female = "Female";
        public const string Other = "Unknown";

        // Constructor 1 aka 'default constructor'
        public Person()
        {
            _children = new List<Person>();
        }

        // Constructor 2
        public Person(string firstName, string lastName, string middleName = null)
        {
            _children = new List<Person>();
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
        }

        ~Person()
        {

        }

        // Properties
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("First Name can't be null");
                }
                LogMessage(string.Format("First Name previous value: '{0}'", _firstName));
                _firstName = value;
                LogMessage(string.Format("First Name new value: '{0}'", _firstName));
            }
        }

        private void LogMessage(string textToLog)
        {
            Logger.Log(textToLog);
            Logger.Log("OMG. This is hidden");
        }

        public string Sex { get; set; }

        public string MothersName { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public List<Person> Children {
            get { return _children; }
            set { _children = value; }
        }

        public string FullName
        {
            get
            {
                string fullName = string.IsNullOrWhiteSpace(FirstName) ? "" : FirstName;
                fullName += string.IsNullOrWhiteSpace(MiddleName) ? "" : " " + MiddleName;
                fullName += string.IsNullOrWhiteSpace(LastName) ? "" : " " + LastName;
                return fullName.Trim();
            }
        } 

        public string FullName2
        {
            get
            {
                string fullName = string.Format("{0}{1}{2}",
                    string.IsNullOrWhiteSpace(FirstName) ? "" : FirstName.Trim(),
                    string.IsNullOrWhiteSpace(MiddleName) ? "" : " " + MiddleName.Trim(),
                    string.IsNullOrWhiteSpace(LastName) ? "" : " " + LastName.Trim());
                return fullName.Trim();
            }
        }

        // Method

        /// <summary>
        /// This method will output the <see cref="textToSay"/> text to the console
        /// </summary>
        /// <param name="textToSay">The text the person should say</param>
        public void SaySomething(string textToSay)
        {
            string output = string.Format("{0} says: '{1}'", FullName, textToSay);
            Console.WriteLine(output);
        }
    }
}