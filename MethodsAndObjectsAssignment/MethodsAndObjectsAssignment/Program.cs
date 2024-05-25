using System;

namespace MethodsAndObjectsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee test =  new Employee() { FirstName = "Sample", LastName = "Student" };
            test.SayName();
        }
    }
}
