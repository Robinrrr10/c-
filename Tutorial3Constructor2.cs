using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleC_Project
{
    class Student2
    {
        public int Id;
        public string Name;
        public List<Exam> exams;

        public Student2() 
        {
            exams = new List<Exam>();
        }

        public Student2(int id)
            : this() //This will call above constructor first
        {
            this.Id = id;
        }

        public Student2(int id, string name) 
            : this(id)  //This will call above constructor first
        {
            this.Name = name;
        }
    }

    public class MyMainClass2
    {
        public static void Main(string[] args)
        {
          var student = new Student2(34, "Raju");
          Console.WriteLine(student.Id);
          Console.WriteLine(student.Name);
        }
    }
}
