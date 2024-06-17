using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorAssignment
{
    public class Person
    {
        public Person(string name) : this(name, 23)
        {
            this.name = name;
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string name { get; set; }
        public int age { get; set; }
    }
}
