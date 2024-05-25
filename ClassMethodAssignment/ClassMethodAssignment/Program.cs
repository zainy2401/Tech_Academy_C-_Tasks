using System;

namespace ClassMethodAssignment
{
    static class Program
    {
        static void Main(string[] args)
        {
            Operations operation = new Operations();
            Console.WriteLine("Please enter a number to divide by 2: ");
            int input = Convert.ToInt32(Console.ReadLine());
            operation.divide(input);
            operation.output();
            Console.WriteLine("Please enter something to output: ");
            string input2 = Console.ReadLine();
            operation.output(input2);
            
        }
    }
}
