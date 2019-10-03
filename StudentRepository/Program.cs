using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StudentRepository
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Enter date: ");
            String date = Console.ReadLine();
            DateTime dt = Convert.ToDateTime(date);
            Console.WriteLine(dt);
            Console.ReadKey();*/

            StringBuilder sb = new StringBuilder();
            sb.Append("Numbers: ");
            for (int index = 1; index <= 200; index++)
            {
                sb.Append(index);
            }
            Console.WriteLine(sb.ToString());
            Console.ReadKey();




        }
    }
}
