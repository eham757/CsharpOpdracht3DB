using System;

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
                db.Add(new Student() {StudentName = "ARYA Aenster",
                    StudentDivision = 'a',
                    StudentHeight = 165.50m,
                    StudentWeight = 65 });

                db.Add(new Student()
                {
                    StudentName = "Willfred NortMarkr",
                    StudentDivision = 'b',
                    StudentHeight = 187.00m,
                    StudentWeight = 81
                });

                db.Add(new Student()
                {
                    StudentName = "Ys Nortgæn",
                    StudentDivision = 'b',
                    StudentHeight = 193.00m,
                    StudentWeight = 84
                });


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

            foreach(Student s in db.Students)
            {
                Console.WriteLine(String.Format("Student ID: {0} Student name: {1}", s.StudentID, s.StudentName));
            }


        }
    }
}
