namespace Students
{
    public class Student
    {
        public string Age { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string HomeTown { get; set; }

        // Constructor
        public Student(string firstName, string lastName, string age, string homeTown)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            HomeTown = homeTown;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Student> students = new List<Student>();

            while (command != "end")
            {
                string[] studentsData = command.Split();
                string firstName = studentsData[0];
                string lastName = studentsData[1];
                string age = studentsData[2];
                string homeTown = studentsData[3];

                Student currentStudent = new Student(firstName, lastName, age, homeTown);
                students.Add(currentStudent);

                command = Console.ReadLine();
            }

            string targetTown = Console.ReadLine();

            List<Student> filterStudents = students.Where(a => a.HomeTown == targetTown).ToList();

            foreach (Student student1 in filterStudents)
            {
                Console.WriteLine($"{student1.FirstName} {student1.LastName} is {student1.Age} years old.");
            }
        }
    }
}
