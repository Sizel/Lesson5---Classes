using System;
using System.Collections.Generic;

namespace Overriding_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Max");
            person.SayHi();
            Employee employee = new Employee("Vlad", "Google");
            employee.SayHi();
        }
    
    }

    class Person
    {
        public string Name { get; set; }
        public virtual void SayHi()
        {
            Console.WriteLine($"Hi! My name is { Name }");
        }
        public virtual void SayHi(string greeting)
        {
            Console.WriteLine($"{ greeting } My name is { Name }");
        }

        public Person(string name)
        {
            Name = name;
        }
    }

    class Employee : Person
    {
        public string CompanyName { get; set; }
        public override void SayHi()
        {
            base.SayHi();
            Console.WriteLine($"I work in { CompanyName }");
        }

        public Employee(string name, string comapanyName) : base(name)
        {
            CompanyName = comapanyName;
        }
    }

}
