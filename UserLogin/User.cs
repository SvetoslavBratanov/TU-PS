using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    public class User
    {
        public String Username;
        public String Password;
        public String FacultyNumber;
        public Int32 Role;
        public DateTime Created;
        public DateTime ActiveUntil;

        public User (String Username, String Pass, String FNum, Int32 Role)
        {
            this.Username = Username;
            this.Password = Pass;
            this.FacultyNumber = FNum;
            this.Role = Role;
        }

        public User()
        {
        }
    }
}
