using System;

namespace callingMethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Task newTask = new Task();
            Console.WriteLine("Please enter a number: ");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your input, " + input + ", added by 2 is " + newTask.Add(input));
            Console.WriteLine("Your input, " + input + ", subtracted by 2 is " + newTask.Subtract(input));
            Console.WriteLine("Your input, " + input + ", multiplied by 2 is " + newTask.Multiply(input));
        }
    }
}
