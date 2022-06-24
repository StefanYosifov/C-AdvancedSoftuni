using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassroomProject
{
    public class Classroom
    {
        public Classroom(int capacity)
        {
            this.collection = new List<Student>();
            Capacity = capacity;
        }

        private List<Student> collection;

        public int Capacity { get; set; }
        public int Count => this.collection.Count;

        public string RegisterStudent(Student student)
        {
            if (this.collection.Count < this.Capacity)
            {
                this.collection.Add(student);
                return $"Added student {student.FirstName} {student.LastName}".Trim(); 
            }
            return $"No seats in the classroom".Trim();
        }

        public string DismissStudent(string firstName,string lastName)
        {
            if(this.collection.Any(x=>x.FirstName==firstName && x.LastName == lastName))
            {
                var student=this.collection.FirstOrDefault(x=>x.FirstName==firstName && x.LastName==lastName);
                this.collection.Remove(student);
                return $"Dismissed student {firstName} {lastName}".Trim();
            }
            return "Student not found".Trim();
        }

        public string GetSubjectInfo(string subject)
        {
            if (this.collection.Any(x => x.Subject == subject))
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"Subject: {subject}");
                sb.AppendLine($"Students:");
                foreach (var student in this.collection.Where(x => x.Subject == subject))
                {
                    sb.AppendLine($"{student.FirstName} {student.LastName}");
                }
                return sb.ToString().Trim();
            }
            return $"No students enrolled for the subject".Trim();
        }

        public int GetStudentsCount()
        {
            return this.collection.Count;
        }

        public Student GetStudent(string firstName, string lastName)
        {
            return this.collection.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);
        }
    }
}
