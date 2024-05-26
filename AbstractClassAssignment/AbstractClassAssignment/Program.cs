using System;

namespace AbstractClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee test = new Employee() { firstName = "Sample", lastName = "Student"};
            test.SayName();
        }
    }
}
