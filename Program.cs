using System;
using System.Collections.Generic;

namespace NSSOrientation
{
    public class Program
    {
        public static void Main()
        {
            List<string> students = new List<string>()
            {
                "Mori",
                "Travis",
                "Braxton",
                "Parker",
                "Ember",
                "Matt",
                "CJ",
                "Sam",
                "Jerry",
                "Terra",
                "Brady"
            };

            // Can't do this easily with a base array
            students.Add("Adam");
            students.Insert(3, "Rose");

            if (students.Contains("Rose"))
            {
                Console.WriteLine("Must be cohort 43");
            }

            // This looks a lot like JavaScript!
            students.ForEach(stu => Console.WriteLine(stu));
        }
    }
}