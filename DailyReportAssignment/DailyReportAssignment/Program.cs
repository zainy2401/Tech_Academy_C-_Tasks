using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReportAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Academy of Learning Career College. \nStudent Daily Report"); //Prints a string of words to the console. A header for the program.
            Console.WriteLine("What is your name?"); //Prints a string of words to the console. A question.
            string name = Console.ReadLine(); //Creates variable and stores user input as string.

            Console.WriteLine("What Course are you on?"); //Prints a string of words to the console. A question.
            string coursName = Console.ReadLine(); //Creates variable and stores user input as string.

            Console.WriteLine("What page number?"); //Prints a string of words to the console. A question.
            int pageNumber = Convert.ToInt32(Console.ReadLine()); //Creates variable and stores user input as integer by being converted first.

            Console.WriteLine("Do you need help with anything? Please answer \"true or false\" "); //Prints a string of words to the console. A question.
            bool needHelp = Convert.ToBoolean(Console.ReadLine()); //Creates variable and stores user input as boolean by being converted first.

            Console.WriteLine("Was there any positive experiences you'd like to share? Please give specifics"); //Prints a string of words to the console. A question.
            string experience = Console.ReadLine(); //Creates variable and stores user input as string.

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific"); //Prints a string of words to the console. A question.
            string feedback = Console.ReadLine(); //Creates variable and stores user input as string.

            Console.WriteLine("How many hours did you study today?"); //Prints a string of words to the console. A question.
            int hoursStudied = Convert.ToInt32(Console.ReadLine()); //Creates variable and stores user input as integer by being converted first.

            Console.WriteLine("Thank you for your answers. An instructor will respond shortly. Have a great day!"); //Prints a string of words to the console. A closing statement.
        }
    }
}
