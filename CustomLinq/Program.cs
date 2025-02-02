using DelegateAndLambda;

namespace CustomLinq
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public static class MyLinq
    {
        public static IEnumerable<T> CheckStudentAgeLessThan20<T>(this IEnumerable<T> source, Predicate<T> predicate) where T : class
        {
            foreach (var item in source)
            {
                if (predicate(item)) yield return item;
            }
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student { Name = "A", Age = 7 },
                new Student { Name = "B", Age = 8 },
                new Student { Name = "C", Age = 12 },
                new Student { Name = "D", Age = 15 },
                new Student { Name = "E", Age = 23 },
                new Student { Name = "F", Age = 45 },
                new Student { Name = "G", Age = 57 },
            };
            var result = students.CheckStudentAgeLessThan20(s => s.Age < 20);
            foreach (var item in result)
            {
                Console.WriteLine($"Name: {item.Name} - Age: {item.Age}");
            }
        }
    }
}
