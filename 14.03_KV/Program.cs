namespace _14._03_KV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
        {
            new Student { Name = "Юлька", Faculty = "Математика", Grades = new List<int> { 2, 4, 4, 5 } },
            new Student { Name = "Владик", Faculty = "Математика", Grades = new List<int> { 5, 4, 5, 5 } },
            new Student { Name = "Юлька", Faculty = "Русский", Grades = new List<int> { 5, 3, 5, 5 } },
            new Student { Name = "Владик", Faculty = "Русский", Grades = new List<int> { 5, 3, 4, 3 } },
        };

            var facultyGroups = students.GroupBy(s => s.Faculty);

            foreach (var facultyGroup in facultyGroups)
            {
                double facultyAverage = facultyGroup.Average(s => s.AverageGrade);
                var bestStudent = facultyGroup.OrderByDescending(s => s.AverageGrade).First();
                Console.WriteLine($"Факультет: {facultyGroup.Key}");
                Console.WriteLine($"Средний балл: {facultyAverage}");
                Console.WriteLine($"Лучший студент: {bestStudent.Name} (Средний балл: {bestStudent.AverageGrade})");
                Console.WriteLine();
            }
        }
    }
}
