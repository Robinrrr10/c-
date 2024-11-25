using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleC_Project
{
    public class Person2
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }

        public static Person2 setPer(string n)
        {
            var per = new Person2();
            per.Name = n;
            return per;
        }
    }

    public class Tutorial2Classes2
    {
        static void Main(string[] args)
        {
            Person2 person = Person2.setPer("Job");
            person.Introduce("Ra");
        }
    }
}