using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace StudentRepository
{
    public class StudentData
    {
        static private ObservableCollection<Student> _testStudents = new ObservableCollection<Student>();
        static public ObservableCollection<Student> TestStudents
        {
            get
            {
                ResetTestUserData();
                return _testStudents;
            }
            private set { _testStudents = TestStudents; }
        }

        static private void ResetTestUserData()
        {
            _testStudents.Add(new Student("Pesho", "Peshev", "Georgiev", "FCST", "Software Engineering",
                "bachelor", "learner", "14114", 1, 6, 24, DateTime.Now));
            _testStudents.Add(new Student("Gosho", "Goshev", "Ivanov", "FCST", "Software Engineering",
                "bachelor", "learner", "14067", 1, 6, 24, DateTime.Now));
            _testStudents.Add(new Student("Misho", "Mishev", "Dimitrov", "FCST", "Software Engineering",
                "bachelor", "learner", "14122", 3, 9, 44, DateTime.Now));

            foreach (Student s in _testStudents)
            {
                    
            }
        }

        static public Student IsThereStudent(String fNum)
        {
            if((from s in TestStudents
                    where s.FacultyNumber.Equals(fNum)
                    select s).Any())
            {
                return (from s in TestStudents
                        where s.FacultyNumber.Equals(fNum)
                        select s).First();
            }
            else
            {
                return null;
            }
            
    
        }

    }


}
