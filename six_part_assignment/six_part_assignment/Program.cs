using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Assignment PART 1
        string[] animals = { "dog", "cat", "hamster", "bird" }; // Creates a string array of animals
        Console.WriteLine("Please enter some text"); // Asks user for some text
        string addedText = Console.ReadLine(); //Takes in user input as string
        // For loops thorugh the animal string array
        for (int i = 0; i < animals.Length; i++)
        {
            animals[i] = animals[i] + " " + addedText; // Concatenates the string array item with the user input
        }
        // Foreach loops through the changed animals string array
        foreach (string word in animals)
        {
            Console.WriteLine(word); //Outputs each element in the array
        }

        //Assignment PART 2
        //Originall in the statment below the loop condition was that as long as the integer i is not equal to -1 then decrement the integer i and print "hello world", this was fixed by changing the decrement to an increment
        for (int i = 0; i != -1; i--)
        {
            Console.WriteLine("Hello World");
        }

        Assignment PART 3
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("");
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine(i);
        }

        //Assignment PART 4
        List<string> names = new List<string>() { "John", "Jack", "Jill", "Jane" }; // Creates a list of string
        Console.WriteLine("Please enter a name: "); // Asks user for string input
        string search = Console.ReadLine(); // Takes in user input
        bool found = false; // Creates a boolean value to determine wether the result is found or not
        // While loop to continue the code until a search item is found
        while (!found)
        {
            // Loops through the length of the names list
            for (int i = 0; i < names.Count; i++)
            {
                //Checks if the user input matches with a value in the list
                if (names[i] == search)
                {
                    Console.WriteLine(i); //Outputs index of the found string
                    found = true; //Sets boolean value to true meaning found
                    break; //breaks the iteration
                }
                else
                {
                    Console.WriteLine("Sorry that names doesn't exist in this list, please enter another name: ");
                    search = Console.ReadLine();
                }
            }
        }

        //Assignment PART 5
        List<string> names2 = new List<string>() { "John", "Jack", "Jill", "Jane", "Jessie", "Jessie" }; //Creates a string list of names
        Console.WriteLine("Please enter a name: "); // Asks the user for an input
        string search2 = Console.ReadLine(); //Takes in the user input as a string
        bool found2 = false; // Creates a bool variable to check if a matching name was found in the list
        // Loops through the string list
        for (int i = 0; i < names2.Count; i++)
        {
            // Checks if the user input matches the value at the index of the list
            if (search2 == names2[i])
            {
                Console.WriteLine("Found at index: " + i); //Outputs at which index of the list the matching value was found
                found2 = true; // Sets bool variable to true to negate the next if statement
            }
        }
        // If statement to tell the user the matching value was not found in the list
        if (!found2)
        {
            Console.WriteLine("Sorry the name does not exist in this list.");
        }

        //Assignment PART 6
        List<string> names3 = new List<string>() { "Jack", "John", "Jane", "Jill", "Jessie", "Jessie" };
        List<string> duplicates = new List<string>();
        foreach (string name in names3)
        {
            Console.WriteLine(name);
            if (duplicates.Contains(name))
            {
                Console.WriteLine("This name was repeated!");
            }
            else
            {
                Console.WriteLine("This name is unique");
            }
            duplicates.Add(name);
        }



    }
}
