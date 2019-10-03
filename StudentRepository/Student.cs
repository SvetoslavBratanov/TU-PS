using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRepository
{
    public class Student : INotifyPropertyChanged
    {
        public string Forename;
        public string FatherName;
        public string Surname;
        public string Faculty;
        public string Specialty;
        public string EducationalQualificationDegree;
        public string Status;
        private string _facultyNumber;
        public string FacultyNumber
        {
            get { return _facultyNumber; }
            private set { }
        }
        public int Year;
        public int Stream;
        public int Group; 
        private DateTime LastSignedSemester;
        private DateTime LastSemesterPayment;

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public Student()
        {

        }

        public Student(string forename, string fatherName, string surname, 
            string faculty, string specialty, string educationalQualificationDegree, 
            string status, string facultyNumber, int year, int stream, 
            int group, DateTime lastSemesterPayment)
        {
            Forename = forename;
            FatherName = fatherName;
            Surname = surname;
            Faculty = faculty;
            Specialty = specialty;
            EducationalQualificationDegree = educationalQualificationDegree;
            Status = status;
            _facultyNumber = facultyNumber;
            Year = year;
            Stream = stream;
            Group = group;
            LastSemesterPayment = lastSemesterPayment;
        }
         
    }
}
