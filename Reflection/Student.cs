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

        public void DisplayPublicProperties(Student student)
        {
            Console.WriteLine($"Sou um aluno e meu tipo é {student.GetType()}");
            PropertyInfo[] propertyInfos = student.GetType().GetProperties();
            Console.WriteLine($"Usando reflexão, descobri que tenho {propertyInfos.Length} propriedades públicas:");
            foreach (var propertyInfo in propertyInfos)
            {
                Console.WriteLine($" - {propertyInfo.Name}, do tipo '{propertyInfo.PropertyType.Name}'.");
            }
        }

        public void CreateInstance()
        {
            var student = Activator.CreateInstance<Student>();

            PropertyInfo[] propertyInfos = student.GetType().GetProperties();
            foreach (PropertyInfo propertyInfo in propertyInfos)
            {
                if (propertyInfo.Name == "Name")
                {
                    propertyInfo.SetValue(student, "Lais Fernandes");
                }

                if (propertyInfo.Name == "University")
                {
                    propertyInfo.SetValue(student, "Let's Code");
                }

                if (propertyInfo.Name == "RollNumber")
                {
                    propertyInfo.SetValue(student, 26478);
                }
            }

            MethodInfo[] methodInfos = student.GetType().GetMethods();
            foreach (MethodInfo methodInfo in methodInfos)
            {
                if (methodInfo.Name.Equals("DisplayInfo", StringComparison.Ordinal))
                {
                    methodInfo.Invoke(student, null);
                }
            }
        }
    }
}