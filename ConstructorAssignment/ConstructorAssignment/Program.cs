using System;

namespace ConstructorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            const string name = "Zain";
            var age = 22;

            Person person = new Person(name, age);
            Console.WriteLine("Person 1 Name: {0}, Age: {1}", person.name, person.age);

            Person person2 = new Person("Bob");
            Console.WriteLine("Person 1 Name: {0}, Age: {1}", person2.name, person2.age);
        }
    }
}
