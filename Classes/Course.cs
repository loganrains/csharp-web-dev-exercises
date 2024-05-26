using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;
using Classes;


namespace SchoolPractice;
    public class Course
    {
        private string Topic;
        private Teacher Instructor;
        private List<Student> EnrolledStudents;

        public Course (string topic, Teacher instructor, List<Student> enrolledStudents)
            {
                Topic = topic;
                Instructor = instructor;
                EnrolledStudents = enrolledStudents;
            }

        public void Description()
            {
                Console.WriteLine(this.Topic + " taught by " + this.Instructor.FirstName + " has these students enrolled:");
                foreach(Student student in EnrolledStudents)
                {
                    Console.WriteLine(student.Name);
                }
            }

        public class Teacher
        {
            public string FirstName {get; set;}
            private string LastName {get; set;}
            private string Subject {get; set;}
            private int YearsTeaching {get; set;}

            public Teacher (string firstName, string lastName, string subject, int yearsTeaching)
            {
                FirstName = firstName;
                LastName = lastName;
                Subject = subject;
                YearsTeaching = yearsTeaching;
            }

            public void Description()
            {
                Console.WriteLine("The instructor for " + this.Subject + " for the last " + this.YearsTeaching + " years is " + this.FirstName + " " + this.LastName + ".");
            }
        }
    }



