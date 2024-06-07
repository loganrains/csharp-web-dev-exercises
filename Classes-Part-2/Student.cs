using System;
namespace Classes_Part_2
{
	public class Student
	{
        private static int nextStudentId = 1;
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        public Student(string name, int studentId,
            int numberOfCredits, double gpa)
        {
            Name = name;
            StudentId = studentId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public Student(string name, int studentId)
        : this(name, studentId, 0, 0) { }

        public Student(string name)
        : this(name, nextStudentId)
        {
            nextStudentId++;
        }

        // TODO: Complete the AddGrade method.
        public void AddGrade(int courseCredits, double grade)
        {

            int previousCredits = this.NumberOfCredits;
            double previousGpa = this.Gpa;

            this.NumberOfCredits = previousCredits + courseCredits;


            double points = previousCredits * previousGpa;

            if (grade >= 90)
            {
                points += 4 * courseCredits;
            }
            else if (grade < 90 && grade >= 80)
            {
                points += 3 * courseCredits;
            }
            else if (grade < 80 && grade >= 70)
            {
                points += 2 * courseCredits;
            }
            else if (grade < 70 && grade >= 60)
            {
                points += 1 * courseCredits;
            }

            this.Gpa = points / this.NumberOfCredits;
        }

        //TODONE: Complete the GetGradeLevel method here:
        public string GetGradeLevel(int credits)
        {
            if (credits <= 29)
            {
                return "Freshman";
            }
            else if (credits <= 59)
            {
                return "Sophomore";
            }
            else if (credits <= 89)
            {
                return "Junior";
            }
            else
            {
                return "Senior";
            }
        }

        // TODONE: Add your custom 'ToString' method here. Make sure it returns a well-formatted string rather
        //  than just the class fields.
        public override string ToString()
        {
            return Name + " (Credits: " + NumberOfCredits + ", GPA: " + Gpa + ")";
        }


        // TODONE: Add your custom 'Equals' method here. Consider which fields should match in order to call two Student objects equal.
        public bool Equals(Student student)
        {
            if (student == this)
            {
                return true;
            }

            if (student == null)
            {
                return false;
            }

            if (student.GetType() != this.GetType())
            {
                return false;
            }

            return this.StudentId == student.StudentId;
        }
    }
}

