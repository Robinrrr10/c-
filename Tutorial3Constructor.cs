using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleC_Project
{
    class Student
    {
        public int Id;
        public string Name;

        public Student() 
        {
            
        }

        public Student(int id)
        {
            this.Id = id;
        }

        public Student(int id, string name) {
            this.Id = id;
            this.Name = name;
        }
    }

    public class MyMainClass
    {
        public static void Main(string[] args)
        {
            Student student = new Student();
            student.Id = 23;
            student.Name = "Babu";
            Console.WriteLine(student.Id);
            Console.WriteLine(student.Name);

            Student student2 = new Student(78, "Ram");
            Console.WriteLine(student2.Id);
            Console.WriteLine(student2.Name);
        }
    }
}
