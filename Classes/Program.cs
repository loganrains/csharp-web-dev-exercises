// TODO: Instantiate your objects and test your exercise solutions with print statements here.

using System.Runtime.CompilerServices;
using Classes;
using SchoolPractice;

Student Logan = new Student("Logan");
Logan.NumberOfCredits = 1;
Logan.Gpa = 4.0;
Logan.Description();

Course.Teacher Robert = new("Robert", "Yang", "Biochemistry", 37);
Robert.Description();

List<Student> AdvBioChemEnrolled = new List<Student>();
AdvBioChemEnrolled.Add(Logan);


Course AdvBioChem = new("Advanced BioChemistry 450", Robert, AdvBioChemEnrolled);
AdvBioChem.Description();


