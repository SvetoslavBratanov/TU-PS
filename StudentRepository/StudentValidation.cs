using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserLogin;

namespace StudentRepository
{
    public class StudentValidation
    {
        Student GetStudentDataByUser(User u)
        {
            if(u == null)
            {
                Console.WriteLine("Entered user is invaled!");
            }
            else
            {
                if(!u.FacultyNumber.Equals(String.Empty))
                {
                    foreach (Student s in StudentData.TestStudents)
                    {
                        if(u.FacultyNumber.Equals(s.FacultyNumber))
                        {
                            return s;
                        }
                    }
                    Console.WriteLine("We couldn't find student within provided information from this user!");
                }
                else
                {
                    Console.WriteLine("Entered user doesn't have faculty number!");
                }
            }
            return null;
        }
    }
}
