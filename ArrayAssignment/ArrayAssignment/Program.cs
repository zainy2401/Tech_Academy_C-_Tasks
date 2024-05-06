using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        String[] animals = { "dog", "cat", "cow", "duck", "chicken", "pigeon" }; // Creates an array of strings containing animal names
        Console.WriteLine("Choose a number from 1 - 6 to see a farm animal!"); // Asks for user input
        int stringChoice = Convert.ToInt32(Console.ReadLine()); // Gets user input and converts to integer
        stringChoice--; // Decrements user input to read the array correctly
        // While block checks to make sure that the user input is within the length of the array to avoid error
        while (stringChoice < 0 || stringChoice > 5)
        {
            Console.WriteLine("Invalid! Please choose a number from 1 - 6");
            stringChoice = Convert.ToInt32(Console.ReadLine());
            stringChoice--;
        }
        Console.WriteLine(animals[stringChoice]); // Outputs the array value at the index the user entered.

        int[] numArray = { 100, 200, 300, 400, 500, 600, 700, 800, 900, 1000 }; // Creates an array of integers
        Console.WriteLine("Choose a number from 1 - 10 inclusive"); // Asks for user input
        int numChoice = Convert.ToInt32(Console.ReadLine()); // Gets user input and converts to integer
        numChoice--; // Decrements user input to read the array correctly
        // While block checks to make sure that the user input is within the length of the array to avoid error
        while (numChoice < 0 || numChoice > 9)
        {
            Console.WriteLine("Invalid! Please choose a number from 1 - 10!");
            numChoice = Convert.ToInt32(Console.ReadLine());
            numChoice--;
        }
        Console.WriteLine(numArray[numChoice]); // Outputs the array value at the index the user entered.

        List<String> names = new List<String>();
        names.Add("John");
        names.Add("James");
        names.Add("Jeff");
        names.Add("Jared");
        Console.WriteLine("Choose a number from 1 - 4 to see a name"); // Asks for user input
        int nameChoice = Convert.ToInt32(Console.ReadLine()); // Gets user input and converts to integer
        nameChoice--; // Decrements user input to read the array correctly
        // While block checks to make sure that the user input is within the length of the array to avoid error
        while (nameChoice < 0 || nameChoice > 3)
        {
            Console.WriteLine("Invalid! Please choose a number from 1 - 4");
            nameChoice = Convert.ToInt32(Console.ReadLine());
            nameChoice--;
        }
        Console.WriteLine(names[nameChoice]); // Outputs the array value at the index the user entered.

        Console.ReadLine();
    }
}