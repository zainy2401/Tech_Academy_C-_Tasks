using System;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Operations test = new Operations();
            Console.WriteLine(test.addition(5));
            Console.WriteLine(test.addition(4.5f));
            Console.WriteLine(test.addition("10"));
        }
    }
}
