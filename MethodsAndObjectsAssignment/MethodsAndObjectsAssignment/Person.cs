﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MethodsAndObjectsAssignment
{
    public class Person
    {
        public string FirstName;
        public string LastName;

        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
