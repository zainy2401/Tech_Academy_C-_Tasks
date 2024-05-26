using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassAssignment
{
    public class Employee : Person
    {
        public int Id;

        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
    }
}
