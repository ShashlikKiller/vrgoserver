using System;


namespace vrgoserver.Models 
{
    public class User
    {
        private string _firstName;
        private string _lastName;
        private string _dateOfBirth;
        private string _email;  // ID
        private bool _gender;

        public User(string firstName, string lastName, string dateOfBirth, string email, bool gender)
        {
            _firstName = firstName;
            _lastName = lastName;
            _dateOfBirth = dateOfBirth;
            _email = email;
            _gender = gender;
        }

        public bool Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string DateOfBirth
        {
            get { return _dateOfBirth; }
            set { _dateOfBirth = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
    }
}
