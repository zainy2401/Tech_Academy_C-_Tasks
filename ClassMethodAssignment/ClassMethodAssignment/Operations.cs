using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodAssignment
{
    public class Operations
    {
        public void divide(int num1)
        {
            Console.WriteLine(num1 + " divided by 2 is " + (num1 / 2));
        }

        public void output()
        {
            Console.WriteLine("Hello World!");
        }

        public void output(string input)
        {
            Console.WriteLine("Your message was: " + input);
        }
    }
}
