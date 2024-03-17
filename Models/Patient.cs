using System;

namespace vrgoserver.Models 
{
    public class Patient : User
    {
        private string _pathology;
        private string[] _affectedRegion;

        public Patient(
            string firstName, 
            string lastName, 
            string dateOfBirth, 
            string email, 
            bool gender, 
            string pathology, 
            string[] affectedRegion)
            : base(
                firstName, 
                lastName, 
                dateOfBirth, 
                email, 
                gender)
        {
            _pathology = pathology;
            _affectedRegion = affectedRegion;
        }

        public string Pathology
        {
            get { return _pathology; }
            set { _pathology = value; }
        }

        public string[] AffectedRegion
        {
            get { return _affectedRegion; }
            set { _affectedRegion = value; }
        }
    }
}