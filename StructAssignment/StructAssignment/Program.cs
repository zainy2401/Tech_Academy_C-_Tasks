using System;

namespace StructAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Number num1 = new Number() { Amount = 6.9m }; //Creates and initalises an object of type Number struct, making it a value type
            Console.WriteLine(num1.Amount); //Outputs the value of the property of the object
        }
    }
}
