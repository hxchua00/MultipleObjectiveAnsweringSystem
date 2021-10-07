using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MultipleObjectiveAnsweringSystem
{
    
    class Admin
    {
        List<Student> ExamCandidates = new List<Student>();
        List<Student> RejectedCandidates = new List<Student>();

        Exam e = new Exam();

        public void GrantPermission(Student s)
        {
            if(s.Participated == true)
            {
                RejectApplication(s);
            }
            else
            {
                ExamCandidates.Add(s);
                Console.WriteLine($"Student Name: {s.StudentName}, \nStudent ID: {s.StudentID} \nhas been permitted to take the exam.");

                e.CheckIfParticipating(ExamCandidates);
            }
        }

        public void RejectApplication(Student s)
        {
            RejectedCandidates.Add(s);
            Console.WriteLine($"Sorry!\nStudent name: {s.StudentName},\nStudent ID: {s.StudentID} \nhas been rejected!");
        }
    }
}
