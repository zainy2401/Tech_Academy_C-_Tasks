using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Begins the try block, this code will be tried and if any errors occur then it will move to the catch block and display an error message corresponding to the error.
        try
        {
            List<int> numbers = new List<int>() { 100, 200, 300, 400, 500 }; // Creates and fills in a list of integers.
            Console.WriteLine("The list of numbers are (100, 200, 300, 400, 500, enter a number to divide each number in the list by: "); // Outputs the list of numbers and asks the user to input anumber.
            int num = Convert.ToInt32(Console.ReadLine()); // Takes in the user input and converts it into integer
            // A for loop that loops through the lenght of the list of integers and for each integer in the list it is divided by the user input.
            foreach (int i in numbers)
            {
                Console.WriteLine(i + "/" + num + " = " + (i / num));
            }
        }
        // This catch block will trigger if the user input is not an integer.
        catch(FormatException ex)
        {
            Console.WriteLine(ex.Message);
        }
        // This catch block will trigger if the user input is 0.
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }
        // This catch block will trigger if the user input or any other error occurs.
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.ReadLine();
        }
    }
}