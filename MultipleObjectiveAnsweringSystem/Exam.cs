using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MultipleObjectiveAnsweringSystem
{
    class Exam
    {
        Dictionary<string, string> Questions = new Dictionary<string, string>();
        List<Student> Participating = new List<Student>();

        public void CheckIfParticipating(List<Student> sList)
        {
            Random rand = new Random();
            int luck = rand.Next(0, 2);

            foreach(Student s in sList)
            {
                if (luck == 0)
                {
                    Participating.Add(s);

                    Console.WriteLine($"Student {s.StudentName}, ID: {s.StudentID} will be participating in the exam.");
                    Console.WriteLine();

                    ExamStart(s);

                } 
                else if( luck == 1)
                {
                    Console.WriteLine($"Unfortunately, {s.StudentName}, ID {s.StudentID} has decuded not to participate in the exam.");
                    Console.WriteLine();
                }
            }
        }

        public void ExamStart(Student s)
        {
            s.Participated = true;

            int results = 0;

            Console.WriteLine("Starting the exam now!");
            Console.WriteLine();

            Questions.Add("Q1", "Thomas Edison");
            Questions.Add("Q2", "Issac Newton");
            Questions.Add("Q3", "Neil Armstrong");
            Questions.Add("Q4", "Makoto Shinkai");
            Questions.Add("Q5", "Hayao Miyazaki");

            string[] studentAns = new string[5];

            Console.WriteLine("Q1: Who invted light bulbs?");
            Console.WriteLine();
            Console.WriteLine("1) Thomas Edison"); //Answer
            Console.WriteLine("2) Albert Einstien");
            Console.WriteLine("3) Adolf Hitler");
            Console.WriteLine("4) Desmond Doss");
            int Q1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (Q1 == 1)
            {
                studentAns[0] = "Thomas Edison";
                results += 2;
            }
            else if (Q1 == 2)
            {
                studentAns[0] = "Albert Einstien";
            }
            else if (Q1 == 3)
            {
                studentAns[0] = "Adolf Hitler";
            }
            else if (Q1 == 4)
            {
                studentAns[0] = "Desmond Doss";
            }

            Console.WriteLine("Q2: Who founded gravity?");
            Console.WriteLine();
            Console.WriteLine("1) Mary Curie");
            Console.WriteLine("2) Desmond Doss");
            Console.WriteLine("3) Isacc Newton"); //Answer
            Console.WriteLine("4) Simo Häyhä");
            int Q2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (Q2 == 3)
            {
                studentAns[1] = "Isacc Newton";
                results += 2;
            }
            else if (Q1 == 1)
            {
                studentAns[1] = "Mary Curie";
            }
            else if (Q1 == 2)
            {
                studentAns[1] = "Desmond Doss";
            }
            else if (Q1 == 4)
            {
                studentAns[1] = "Simo Häyhä";
            }

            Console.WriteLine("Q3: Who is the first person to land on moon?");
            Console.WriteLine();
            Console.WriteLine("1) Arm Neilstrong");
            Console.WriteLine("2) Neil Armstrong"); //Answer
            Console.WriteLine("3) Strongarm Neil");
            Console.WriteLine("4) Neil Patrick Harris");
            int Q3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (Q3 == 2)
            {
                studentAns[2] = "Neil Armstrong";
                results += 2;
            }
            else if (Q3 == 1)
            {
                studentAns[2] = "Arm Neilstrong";
            }
            else if (Q3 == 3)
            {
                studentAns[2] = "Strongarm Neil";
            }
            else if (Q3 == 4)
            {
                studentAns[2] = "Neil Patrick Harris";
            }

            Console.WriteLine("Q4: Who is the director of the movie [Your Name] ?");
            Console.WriteLine();
            Console.WriteLine("1) Makoto Kai");
            Console.WriteLine("2) Makoto Shinkai"); //Answer
            Console.WriteLine("3) Mako Toshinkai");
            Console.WriteLine("4) Shinhai Makoto");
            int Q4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (Q4 == 2)
            {
                studentAns[3] = "Makoto Shinkai";
                results += 2;
            }
            else if (Q4 == 1)
            {
                studentAns[3] = "Makoto Kai";
            }
            else if (Q4 == 3)
            {
                studentAns[3] = "Mako Toshinkai";
            }
            else if (Q4 == 4)
            {
                studentAns[3] = "Shinhai Makoto";
            }

            Console.WriteLine("Q5: Who is the director of the movie [Spitited Away] ?");
            Console.WriteLine();
            Console.WriteLine("1) Minozaki Ayano");
            Console.WriteLine("2) Misazaki Hayato");
            Console.WriteLine("3) Hayai Miyazaki");
            Console.WriteLine("4) Hayao Miyazaki"); //Answer
            int Q5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (Q5 == 4)
            {
                studentAns[4] = "Hayao Miyazaki";
                results += 2;
            }
            else if (Q5 == 1)
            {
                studentAns[4] = "Minozaki Ayano";
            }
            else if (Q5 == 2)
            {
                studentAns[4] = "Misazaki Hayato";
            }
            else if (Q5 == 3)
            {
                studentAns[4] = "Hayai Miyazaki";
            }

            int[] stdAnswers = new int[] {Q1,Q2,Q3,Q4,Q5 };

            Console.WriteLine();
            Console.WriteLine("That's the end of the exam!");
            Console.WriteLine("Displaying results");
            Console.WriteLine();

            Console.WriteLine($"{s.StudentName}'s answers are:");
            Console.WriteLine($"Question 1: {stdAnswers[0]} - {studentAns[0]}");
            Console.WriteLine($"Question 2: {stdAnswers[1]} - {studentAns[1]}");
            Console.WriteLine($"Question 3: {stdAnswers[2]} - {studentAns[2]}");
            Console.WriteLine($"Question 4: {stdAnswers[3]} - {studentAns[3]}");
            Console.WriteLine($"Question 5: {stdAnswers[4]} - {studentAns[4]}");
            Console.WriteLine();

            Console.WriteLine("Correct answers are...");
            foreach(KeyValuePair<string,string> vals in Questions)
            {
                Console.WriteLine($"{vals.Key} - {vals.Value}");
            }

            Console.WriteLine();
            Console.WriteLine($"Student Name: {s.StudentName}");
            Console.WriteLine($"Student ID: {s.StudentID}");
            Console.WriteLine($"Your score for this exam is: {results}/10");
            Console.WriteLine();
        }
    }
}
