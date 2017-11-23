using System;
using System.Linq;
using System.Collections.Generic;

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

                db.Students.Add(new Student()
                {
                    StudentName = "Nakar Adraga",
                    StudentDivision = 99
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

            //var sortedStudents = db.Students.Where(s => s.StudentName.StartsWith("Kar"));// karing is de persoon die terug komt omdat ik die heb toegevoed
            //sortedStudents = sortedStudents.OrderBy(s => s.StudentName);

            foreach(var s in db.Students)
            {
                Console.WriteLine(String.Format("Student ID: {0} Student name: {1}", s.StudentNumber, s.StudentName));
            }

            dbStudentNamesAndNumberOrderedByName(db);
            dbSelectStudentNameAndNumberWithStudentNumber(db, 1010);
            dbSelectStudentNameAndNumberAndheighttOrderedByHeightWhenHeightLargerThanGiven(db, 185.00m);
            Console.ReadKey();

        }

        static void dbStudentNamesAndNumberOrderedByName(SchoolContext db)
        {
            Console.WriteLine("");
            Console.WriteLine("Student Names and Numbers");
            var items = db.Students.OrderBy(s => s.StudentName).Select( s => new { Name = s.StudentName, Number = s.StudentNumber});
            foreach (var item in items)
            {
                Console.WriteLine(String.Format("Student name: {0},     Student number: {1}",item.Name, item.Number));
            }
        }

        static void dbSelectStudentNameAndNumberWithStudentNumber(SchoolContext db, int number)
        {
            Console.WriteLine("");
            Console.WriteLine("Student Name and Number ");
            var item = db.Students.Where(s => s.StudentNumber == number).Select(s => new { Name = s.StudentName, Number = s.StudentNumber }).SingleOrDefault();
            Console.WriteLine(String.Format("Student name: {0},     Student number: {1}", item.Name, item.Number));
        }
        
        static void dbSelectStudentNameAndNumberAndheighttOrderedByHeightWhenHeightLargerThanGiven(SchoolContext db, decimal height)
        {
            Console.WriteLine("");
            Console.WriteLine("Student Names and Numbers and height");
            var items = db.Students.Where(s => s.StudentHeight > height).OrderBy(s => s.StudentName).Select(s => new { Name = s.StudentName, Number = s.StudentNumber, Height = s.StudentHeight });
            foreach (var item in items)
            {
                Console.WriteLine(String.Format("Student name: {0},     Student number: {1},    Student height: {2}", item.Name, item.Number, item.Height));
            }
        }
    }
}
