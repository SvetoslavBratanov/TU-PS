using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace UserLogin
{
    static public class UserData
    {
        static private ObservableCollection<User> _testUsers = new ObservableCollection<User>();
        static public ObservableCollection<User> TestUsers
        {
            get {
                ResetTestUserData();
                return _testUsers;
            }
            set { }
        }

        static private void ResetTestUserData()
        {
            _testUsers.Add(new User("admin", "admin", "14122", 1));
            _testUsers.Add(new User("pesho", "hacker", "14114", 4));
            _testUsers.Add(new User("gosho", "programmer", "14067", 4));
            foreach(User user in _testUsers)
            {
                user.Created = DateTime.Now;
                user.ActiveUntil = DateTime.MaxValue;
            }
           
        }

        static public User IsUserPassCorrect(String username, String pass)
        {
            if ((from u in TestUsers
                 where u.Username.Equals(username) && u.Password.Equals(pass)
                 select u).Any())
            {
                return (from u in _testUsers
                        where u.Username.Equals(username) && u.Password.Equals(pass)
                        select u).First();
            }
            else
            {
                return null;
            }
        }

        static public void SetUserActiveTo(int userIndex, DateTime ActiveTo)
        {
             _testUsers.ElementAt(userIndex).ActiveUntil = ActiveTo;
             Console.WriteLine("Successfully changed activity of " + _testUsers.ElementAt(userIndex).Username);
             Console.WriteLine("Active Until: " + _testUsers.ElementAt(userIndex).ActiveUntil);
             Logger.LogActivity("Successfully changed activity of " + _testUsers.ElementAt(userIndex).Username);
        }

        static public void AssignUserRole(int userIndex, UserRoles role)
        {
            _testUsers.ElementAt(userIndex).Role = Convert.ToInt32(role);
            Console.WriteLine("Successfully changed role of " + _testUsers.ElementAt(userIndex).Username);
            Console.WriteLine("New role: " + (UserRoles)_testUsers.ElementAt(userIndex).Role);
            Logger.LogActivity("Successfully changed role of " + _testUsers.ElementAt(userIndex).Username);    
        }

        static public Dictionary<string, int> AllUsersUsernames()
        {
            Dictionary<string, int> result = new Dictionary<string, int>();
            for (int i = 0; i < _testUsers.Count; i++)
            {
                result.Add(_testUsers[i].Username, i);
            }
            return result;
        }


    }
}
