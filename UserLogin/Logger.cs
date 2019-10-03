using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections.ObjectModel;

namespace UserLogin
{
    static public class Logger
    {
        static private ObservableCollection<string> currentSessionActivities = new ObservableCollection<string>();

        static public void LogActivity(String activity)
        {
            String activityLine = DateTime.Now + ";"
                 + LoginValidation.currentUserUsername + ";"
                 + LoginValidation.CurrentUserRole + ";"
                 + activity + "\n";
            currentSessionActivities.Add(activityLine);
            
            if(File.Exists("log.txt"))
            {
                File.AppendAllText("log.txt", activityLine);
            }
        }

        static public void GetCurrentSessionActivities(String filter)
        {
            StringBuilder sb = new StringBuilder();
            List<String> list = (from activity in currentSessionActivities
                                 where activity.Contains(filter)
                                 select activity).ToList();
            if(!list.Any())
            {
                Console.WriteLine("We couldn't find any activity according to the entered filter!");
            }
            else
            {
                foreach (String action in list)
                {
                    sb.Append(action);
                }
                Console.WriteLine(sb.ToString());
            }
        }
    }
}
