using System;
using System.Linq;

namespace COpdrachtDatabase
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Database Programm preparing");
            Console.WriteLine("Ælver sang 0.5 re");

            var db = new SchoolContext();

            Console.WriteLine("");
            Console.WriteLine("should more entries be added? (Y/N)");
            string answer = Console.ReadLine().ToLower();

            if(answer == "y")
            {
                db.Students.Add(new Student()
                {
                    StudentName = "ARYA Aenster",
                    StudentDivision = 1,
                    StudentHeight = 165.50m,
                    StudentWeight = 65
                });

                db.Students.Add(new Student()
                {
                    StudentName = "Willfred NortMarkr",
                    StudentDivision = 2,
                    StudentHeight = 187.00m,
                    StudentWeight = 81
                });

                db.Students.Add(new Student()
                {
                    StudentName = "Ys Nortgæn",
                    StudentDivision = 3,
                    StudentHeight = 193.00m,
                    StudentWeight = 84
                });

                var count = db.SaveChanges();
                Console.WriteLine("{0} records saved to database", count);


            }
            else if(answer == "n")
            {

            }
            else
            {
                Console.WriteLine("That was unclear for me");
            }

            Console.WriteLine("");
            Console.WriteLine("Current students in Database:");
            Console.WriteLine(string.Format("Total entries: {0}",db.Students.Count()));

            var sortedStudents = db.Students.Where(s => s.StudentName.StartsWith("Kar"));// karing is de persoon die terug komt omdat ik die heb toegevoed
            sortedStudents = sortedStudents.OrderBy(s => s.StudentName);

            foreach(var s in sortedStudents)
            {
                Console.WriteLine(String.Format("Student ID: {0} Student name: {1}", s.StudentID, s.StudentName));
            }
            Console.ReadKey();

        }
    }
}
