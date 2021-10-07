using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleObjectiveAnsweringSystem
{
    class Student
    {
        public string StudentName;
        public int StudentID;
        public bool Participated = false;

        public Student(string name, int ID, bool participated)
        {
            StudentName = name;
            StudentID = ID;
            Participated = participated;
        }

        public void SignUp(Student s)
        {
            Random rand = new Random();
            int luck = rand.Next(0,2);
            
            Admin LazyAdmin = new Admin();

            if(luck == 0)
            {
                if(s.Participated == true)
                {
                    LazyAdmin.RejectApplication(s);
                }
                else
                {
                    LazyAdmin.GrantPermission(s);
                }

            }else if(luck == 1)
            {
                LazyAdmin.RejectApplication(s);
            }
        }
    }
}
