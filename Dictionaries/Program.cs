//Exercises: Control Flow & Collections

//TODO: Write your code for Dictionary Practice below:

Console.WriteLine("Hello, Dictionary!");
Dictionary<int, string> dictionary = new();

bool isLoop = true;

while (isLoop)
{

    Console.WriteLine("Enter your students' names and ID numbers (or ENTER to finish):");

    Console.WriteLine("Please enter student's name: ");
    string studentName = Console.ReadLine();

    if (studentName != "")
    {
        Console.WriteLine("Please enter student's ID number: ");
        int studentID = int.Parse(Console.ReadLine());
        
        dictionary.Add(studentID, studentName);
    } else if (studentName == "")
    {
        Console.WriteLine("\nClass Roster:");

        foreach (KeyValuePair<int, string> student in dictionary)
        {
            Console.WriteLine(student.Value + "'s ID: " + student.Key);
        }

        Console.WriteLine("Number of students in roster: " + dictionary.Count);

        isLoop = false;

    }

}






