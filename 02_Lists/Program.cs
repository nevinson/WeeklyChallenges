using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            // Output all second tuesday for the current year.
            for (int month = 1; month <= 12; month++)
            {
                // Set the date of the current year
                // The month will change on the loop value
                DateTime currentDate = new DateTime(DateTime.Now.Year, month, 1);

                //
                while (currentDate.DayOfWeek != DayOfWeek.Tuesday)
                {
                    // If the current day of the week is not Tuesday, add 24hrs(1 day) to go to the next day
                    currentDate = currentDate.AddHours(24);
                }

                //if the current day of the week is Tuesday, add 168hrs(7days) to go to next week
                currentDate = currentDate.AddHours(168);

                Console.WriteLine(currentDate.ToString(""));
            }

            Console.ReadLine();
        }
    }
}
