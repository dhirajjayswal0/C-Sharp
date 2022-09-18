using System;

namespace Challenge3
{
    class Program
    {
        static void Main(string[] args)
        {
            string textString;
            string textChar;

            Console.Write("Enter a string here: ");
            textString = Console.ReadLine();

            Console.Write("Enter the character to search: ");
            textChar = Console.ReadLine();

            int indexofString = textString.IndexOf(textChar);
            Console.WriteLine(indexofString);


            // Now for concatination

            string firstName;
            string LastName;

            Console.Write("Enter First Name: ");
            firstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            LastName = Console.ReadLine();

            String fullName = $"{firstName} {LastName}";
            Console.WriteLine(fullName);

            Console.ReadLine();
        }
    }
}

