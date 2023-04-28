using System;

namespace Performance
{
    class Program
    {
        private static void Print(string message) => Console.WriteLine(message);

        private static void Main()
        {
            Student student = new(20);
            student.EnteringGrades();

            Lecturer lecturer = new();
            lecturer.MyEvent += Print;
            lecturer.Message(student.AveragePerformance);
        }
    }
}
