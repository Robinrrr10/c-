﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleC_Project
{
    public class Person
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }
    }

    public class Tutorial2Classes
    {
        static void Main2(string[] args)
        {
            Person person = new Person();
            person.Name = "John";
            person.Introduce("Ram");
        }
    }
}