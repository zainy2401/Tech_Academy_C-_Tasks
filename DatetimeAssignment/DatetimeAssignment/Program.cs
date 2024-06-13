using System;

namespace DatetimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The current date is: ");
            Console.Write(DateTime.Now);
            Console.WriteLine("Please enter in a number: ");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("In {0} hours, the time will be {1}", input, (DateTime.Now.AddHours(input)));
        }
    }
}
