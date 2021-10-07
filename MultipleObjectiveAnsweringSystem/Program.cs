using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MultipleObjectiveAnsweringSystem
{
    class Program
    {   
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name of Student: ");
            string StudentName = Console.ReadLine();
            Console.WriteLine("Enter student ID: ");
            int StudentID = Convert.ToInt32(Console.ReadLine());

            Student s = new Student(StudentName, StudentID, false);

            Console.WriteLine($"Does the student, {StudentName}, wish to sign up for the exam?");
            Console.WriteLine("1) Yes");
            Console.WriteLine("2) No");

            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            switch (choice)
            {
                case 1:
                    s.SignUp(s);
                    break;
                case 2:
                    Console.WriteLine("Then why are you here in the first place? Good bye!");
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Please answer to the question!");
                    break;
            }

            Console.ReadLine();
        }
    }
}
