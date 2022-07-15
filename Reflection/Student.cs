using System.Reflection;

namespace Reflection
{
    public class Student
    {
        public string Name { get; set; }
        public string University { get; set; }
        public int RollNumber { get; set; }
        public Student() { }
        public Student(string name, string university, int rollNumber)
        {
            Name = name;
            University = university;
            RollNumber = rollNumber;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"{Name} - {University} - {RollNumber}");
        }
    }
}