using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Average_Student_Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int loopRepeats = int.Parse(Console.ReadLine());
            var studentGrades = new Dictionary<string, List<double>>();
            for (int i = 0; i < loopRepeats; i++)
            {
                string[] stundentInformation = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string studentName = stundentInformation[0];
                double grade = double.Parse(stundentInformation[1]);
                if (studentGrades.ContainsKey(studentName))
                {
                    studentGrades[studentName].Add(grade);
                }
                if (!studentGrades.ContainsKey(studentName))
                {
                    studentGrades[studentName] = new List<double>();
                    studentGrades[studentName].Add(grade);
                }
            }

            foreach(var student in studentGrades)
            {
                string studentName = student.Key;
                Console.Write($"{studentName} -> ");
                foreach(var grade in student.Value)
                {
                    Console.Write($"{grade:F2} ");
                }
                Console.WriteLine($"(avg: ({student.Value.Average():F2})");
            }
        }
    }
}
