using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace UserLogin
{
    class Program
    {
        public static void errorMsg(String s)
        {
            Console.WriteLine("!!!" + s + "!!!");
        }
        static void Main(string[] args)
        {
            Console.Write("Enter username: ");
            String username = Console.ReadLine();
            Console.Write("Enter password: ");
            String pass = Console.ReadLine();
            LoginValidation login = new LoginValidation(username, pass, errorMsg);

            User u = null;
            
            if (login.ValidateUserInput(ref u))
            {
                Console.WriteLine();
                Console.WriteLine("Username: " + u.Username);
                Console.WriteLine("Faculty number: " + u.FacultyNumber);
                switch (LoginValidation.CurrentUserRole)
                {
                    case UserRoles.ANONYMOUS:
                        Console.WriteLine("Still Annonymous!");
                        break;
                    case UserRoles.ADMIN:
                        Console.WriteLine("Welcome Admin!");
                        AdministratorMenu(u);
                        break;
                    case UserRoles.INSPECTOR:
                        Console.WriteLine("Welcome Inspector!");
                        break;
                    case UserRoles.PROFESSOR:
                        Console.WriteLine("Welcome Professor!");
                        break;
                    case UserRoles.STUDENT:
                        Console.WriteLine("Welcome Student!");
                        break;
                }
             
            }          
            Console.ReadKey();
        }

        static void AdministratorMenu(User admin)
        {
            int option;
            do
            {
                Console.WriteLine("\n" +
                                        "Choose an option: \n" +
                                        "0: Exit\n" +
                                        "1: Change the role of user\n" +
                                        "2: Change activity of user\n" +
                                        "3: List of users\n" +
                                        "4: Show me log file of activities\n" +
                                        "5: Show me current activity");
            } while (!int.TryParse(Console.ReadLine(), out option) || option < 0 || option > 5);
            
            Dictionary<string, int> allusers = UserData.AllUsersUsernames();
            String UserToEdit = null;
            switch (option)
            {
                case 0:
                    return;
                case 1:
                    UserToEdit = GetUser(allusers);
                    if(UserToEdit != null)
                    {
                       ChangeTheRoleOfUser(allusers, UserToEdit);
                    }
                    else
                    {
                        AdministratorMenu(admin);
                    }
                    break;
                case 2:
                    UserToEdit = GetUser(allusers);
                    if (UserToEdit != null)
                    {
                        ChangeActivityOfUser(allusers, UserToEdit);
                    }
                    else
                    {
                        AdministratorMenu(admin);
                    }                            
                    break;
                case 3:
                    ListOfUsers(allusers);
                    break;
                case 4:
                    ShowMeLogFileActivities();
                    break;
                case 5:
                    ShowMeCurrentActivity();              
                    break;
            }      
        }
        private static string GetUser(Dictionary<string, int> users)
        {
            String UserToEdit = null;
            while (String.IsNullOrEmpty(UserToEdit) || UserToEdit.Length < 5)
            {
                Console.WriteLine("Enter username: ");
                UserToEdit = Console.ReadLine();
            }
            if(users.ContainsKey(UserToEdit))
            {
                return UserToEdit;
            }
            else
            {
                Console.WriteLine("The system doesn't contain user with entered username! Better check the list of users!");
                return null;
            }
            
        }

        private static void ChangeTheRoleOfUser(Dictionary<string, int> users, String user)
        {
            int Role;
            do
            {
                Console.WriteLine("Enter role: \n" +
                "1: ADMIN\n" +
                "2: INSPECTOR\n" +
                "3: PROFESSOR\n" +
                "4: STUDENT");
            } while (!int.TryParse(Console.ReadLine(), out Role) || Role < 1 || Role > 4);
            UserRoles NewUserRole = (UserRoles)Role;
            UserData.AssignUserRole(users[user], NewUserRole);
            Console.WriteLine();
        }

        private static void ChangeActivityOfUser(Dictionary<string, int> users, String user)
        {

            String Date = null;
            DateTime NewDateTime;
            while (String.IsNullOrEmpty(Date))
            {

                Console.WriteLine("Enter date in format (DD/MM/YYYY):");
                Date = Console.ReadLine();
                if (DateTime.TryParse(Date, out NewDateTime))
                {
                    String.Format("{0:d/MM/yyyy}", NewDateTime);
                }
                else
                {
                    Console.WriteLine("Invalid date!");
                    return;
                }
            }
            NewDateTime = Convert.ToDateTime(Date);
            UserData.SetUserActiveTo(users[user], NewDateTime);
        }

        private static void ListOfUsers(Dictionary<string, int> users)
        {
            Console.WriteLine();
            foreach (KeyValuePair<string, int> item in users)
            {
                Console.WriteLine(item.Key);
            }
            Console.WriteLine();
        }

        private static void ShowMeLogFileActivities()
        {
            StreamReader sr = new StreamReader("log.txt");
            StringBuilder sb = new StringBuilder();
            while (true)
            {
                String line = sr.ReadLine();
                if (line == null)
                {
                    break;
                }
                sb.AppendLine(line);
            }
            Console.WriteLine(sb.ToString());
            sr.Close();
        }

        private static void ShowMeCurrentActivity()
        {
            Console.WriteLine("Enter filter:");
            String filter = Console.ReadLine();
            Logger.GetCurrentSessionActivities(filter);
        }
    }
}
