using System.Reflection;

namespace Reflection
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.DisplayPublicProperties(student);
            Console.WriteLine();
            student.CreateInstance();
        }
    }
}