using System;

namespace DataTypes_and_Variables
{
    class Program
    {
        static int unassined;
        static int age = 15;

        static void Main(string[] args)
        {
            Console.WriteLine($"age before local value was assigned is {age}");
            age = 20;
            Console.WriteLine($"age after local value was assigned is {age}");
            Console.WriteLine($"in c# when value is not assigned and called it is {unassined}");

            //declaring a variable
            int num1;
            //assigning a value to a variable;
            num1 = 13;
            //declaring and initializing a variable in one go;
            int num2 = 14;
            // we can override the value of a variable. The last value assigned will be used.
            num2 = 100;

            //String interpolation
            Console.WriteLine($"sum of num1: {num1} + and num2: {num2} is {num1 + num2}.");

            //declaring multiple variables at once
            double d1, d2, dDiv;
            d1 = 3.1415;
            d2 = 5.1;
            dDiv = d1 / d2;
            Console.WriteLine($"d1: {d1} divied by d2: {d2} gives : {dDiv}");

            //declaring multiple variables at once
            float f1, f2, fDiv;
            f1 = 3.1415f;
            f2 = 5.1f;
            fDiv = f1 / f2;
            Console.WriteLine($"d1: {f1} divied by d2: {f2} gives : {fDiv}");



            //String
            string myName = "Dhiraj";
            string message = $"My name is {myName}.";
            string capsMessage = message.ToUpper();
            string lowerCaseMessage = message.ToLower();
            Console.WriteLine(message);
            Console.WriteLine(capsMessage);
            Console.WriteLine(lowerCaseMessage);



            Console.ReadLine();
        }
    }
}

/*

## Primitive data types

# Integral
sbyte x = 1; range from -128 - 127
short x = 1; range from -32,768 - 32,767
integer x = 1; range from -2,147,483,648 - 2,147,483,647
long x = 1; range from –9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
Choose the smallest type your value fits into.


# Floating point
float x = 0.5f; range from 1.5 × 10^−45 - 3.4 × 10^38, 7-digit precision
double x = 0.5; range from 5.0 × 10^−324 - 1.7 × 10^308, 15-digit precision
decimal x = 0.5m; range from –7.9 × 10^−28 - 7.9 × 10^28, 28-digit precision

Use float for 3D graphics, double for everything (except money calculations) and decimal for
financial applications.


# Boolean
bool switch = true;

Use a boolean if you want to set something to true or false (just like a toggle).


# Unicode characters and strings
char c = ‘A’;
string name = “John Doe”;

Use a string for a path, username, birthdate...

 */

