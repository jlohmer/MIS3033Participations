//Jason Lohmer
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_Loops_Collections_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Parallel Arrays
            int[] studentIds = new int[3];
            string[] studentFirstNames = new string[3];
            string[] studentLastNames = { "Harris", "Ackerman", "Johnson" };
            studentIds[0] = 1;
            studentIds[1] = 2;
            studentIds[2] = 3;
            studentFirstNames[0] = "Katie";
            studentFirstNames[1] = "Adam";
            studentFirstNames[2] = "Harry";

            for (int i = 0; i < studentIds.Length; i++)
            {
                Console.WriteLine($"{studentLastNames[i]}, {studentFirstNames[i]}, [{studentIds[i]}]");
            }

            //Dictionary - key/value pairs
            Dictionary<int, string> students = new Dictionary<int, string>();
            students.Add(1, "Katie Harris");
            students.Add(2, "Adam Ackerman");
            students.Add(3, "Jason Lohmer");

            foreach (var key in students.Keys)
            {
                Console.WriteLine($"{students[key]} [{key}]");
            }

            List<Student> studs = new List<Student>();

            Student katie = new Student();
            katie.FirstName = "Katie";
            katie.LastName = "Harris";
            katie.ID = 1;
            katie.Birthdate = Convert.ToDateTime("3/11/1998");

            for (int i = 0; i < studentIds.Length; i++)
            {
                Student s = new Student();
                s.FirstName = studentFirstNames[i];
                s.LastName = studentLastNames[i];
                s.ID = studentIds[i];

                studs.Add(s);
            }

            foreach (var student in studs)
            {
                Console.WriteLine($"{student.LastName}, {student.FirstName}, [{student.ID}], was born on {student.Birthdate.ToLongDateString()}");
                bool isUpper = true;
                string crazyFirstName = "";
                foreach (var letter in student.FirstName)
                {
                    if (isUpper == true)
                    {
                        crazyFirstName += letter.ToString().ToUpper();
                        isUpper = false;
                    }
                    else
                    {
                        crazyFirstName += letter.ToString().ToLower();
                        isUpper = true;
                    }
                }
                Console.WriteLine($"Crazy firstname is {crazyFirstName}");

            }
            
            Console.ReadKey();
        }
    }
}
