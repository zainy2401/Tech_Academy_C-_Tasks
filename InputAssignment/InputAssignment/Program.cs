using System;
using System.IO;

namespace InputAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            int input = Convert.ToInt32(Console.ReadLine());
            using (StreamWriter file = new StreamWriter(@"C:\Users\zaiqu\Desktop\InputAssignment.txt", true))
            {
                file.WriteLine(input);
            }
            Console.WriteLine("Here is what is in the text file: ");
            Console.WriteLine(File.ReadAllText(@"C:\Users\zaiqu\Desktop\InputAssignment.txt"));
        }
    }
}
