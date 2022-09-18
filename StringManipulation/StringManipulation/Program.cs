using System;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = "Dhiraj";
            int age = 25;

            // 1. String Concatination
            Console.WriteLine("String Concatination");
            Console.WriteLine("Hello my name is " + name + ", I am " + age + " years old.");


            // 2. String formatting
            Console.WriteLine("\nString formatting");
            Console.WriteLine("Hello my name is {0}, I am {1} years old.", name, age);


            // 3. String interpolation
            Console.WriteLine("\nString interpolation");
            Console.WriteLine($"Hello my name is {name} , I am {age} years old.");


            // 4. Verbatim string
            // Here it will take everything inside the string literally.
            Console.WriteLine("\nVerbatim string");
            Console.WriteLine(@"Hello my name is {name} , I am {age} years old.");

            Console.ReadLine();
        }
    }
}

