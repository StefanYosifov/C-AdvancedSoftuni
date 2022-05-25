using System;
using System.Collections.Generic;
using System.Linq;

namespace _9.__SoftUni_Exam_Results
{
    class Student
    {
        public Student()
        {

        }

        public Student(string language,int points)
        {
           
            this.Language = language;
            this.Points = points;
        }

        
        public int Name { get; set; }
        public string Language { get; set; }
        public int Points { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
           string input=Console.ReadLine();
            Dictionary<string,List<Student>> students=new Dictionary<string,List<Student>>();
            while(input!="exam finished")
            {
                string[] information=Console.ReadLine().Split('-').ToArray();
                string name=information[0];
                string language=information[1];
                int points=int.Parse(information[2]);
                Student student=new Student(language,points);
                if (!students.ContainsKey(name))
                {
                   
                    students[name].Add(student);
                }
            }

            Console.WriteLine($"Results: ");
            foreach(var student in students.Keys)
            {
                Console.WriteLine(student);
                
                
            }

        }
    }
}
