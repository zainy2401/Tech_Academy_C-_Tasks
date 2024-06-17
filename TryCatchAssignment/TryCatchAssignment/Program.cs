using System;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Please enter your age: ");
                int age = Convert.ToInt32(Console.ReadLine());
                if(age <= 0)
                {
                    throw new ArgumentException("Age must not be 0 or negative");
                }
                DateTime currentDate = DateTime.Now;
                int yearOfBirth = currentDate.Year - age;
                Console.WriteLine(yearOfBirth);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("An unknown error ocurred, please contact system administrator.");
            }
        }
    }
}
