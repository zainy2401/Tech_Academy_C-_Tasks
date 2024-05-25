using System;

namespace MethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Operations test = new Operations();
            Console.WriteLine("Please enter a first Number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Optionally enter a second number or just press enter to skip: ");
            try
            {
                int secondNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(test.addition(firstNumber, secondNumber));
            }
            catch
            {
                Console.WriteLine(test.addition(firstNumber));
            }
        }
    }
}
