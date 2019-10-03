using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    public class LoginValidation
    {
        private String Username;
        private String Password;
        private String ErrorMessage;
        public delegate void ActionOnError(String errorMsg);
        private ActionOnError _errorfunc;
        static private UserRoles _currentUserRole;
        static public UserRoles CurrentUserRole
        {
            get { return _currentUserRole; }
            private set { _currentUserRole = CurrentUserRole; }
        }
        private static string _currentUserUsername;
        public static string currentUserUsername
        {
            get { return _currentUserUsername; }
            private set { }
        }

        public LoginValidation(String username, String pass, ActionOnError a)
        {
            this.Username = username;
            this.Password = pass;
            this._errorfunc = new ActionOnError(a);
            _currentUserUsername = new String(username.ToCharArray());
            _currentUserRole = UserRoles.ANONYMOUS;
        }

        public bool ValidateUserInput(ref User u)
        {
            Boolean emptyUserName = this.Username.Equals(String.Empty);            
            Boolean emptyPassword = this.Password.Equals(String.Empty);
            if (emptyUserName || emptyPassword)
            {
                this.ErrorMessage = "The entered data is empty!";
                _errorfunc(this.ErrorMessage);
                return false;
            }
            if (this.Username.Length < 5 || this.Password.Length < 5)
            {
                this.ErrorMessage = "The username and the password must be at least 5 symbols!";
                _errorfunc(this.ErrorMessage);
                return false;
            }

            User temp = UserData.IsUserPassCorrect(this.Username, this.Password);
            if (temp == null)
            {
                this.ErrorMessage = "Wrong data!";
                _errorfunc(this.ErrorMessage);        
                return false;    
            }
            else
            {
                u = temp;
                _currentUserRole = (UserRoles)u.Role;
                //Console.WriteLine("Successful login!");
                Logger.LogActivity("Successful login!");
                return true;
            }
        }
    }
}
