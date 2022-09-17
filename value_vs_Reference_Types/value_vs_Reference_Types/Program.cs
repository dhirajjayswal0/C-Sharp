using System;

namespace value_vs_Reference_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}



/*

## Value Type and Reference Type


In C#, these data types are categorized based on how they store their value in the memory.
C# includes the following categories of data types:

Value type
Reference type
Pointer type



# Value Type
A data type is a value type if it holds a data value within its own memory space.
It means the variables of these data types directly contain values.
For example, consider integer variable int i = 100;
The system stores 100 in the memory space allocated for the variable i.

The following data types are all of value type:
bool
byte
char
decimal
double
enum
float
int
long
sbyte
short
struct
uint
ulong
ushort




# Reference Type
Unlike value types, a reference type doesn't store its value directly.
Instead, it stores the address where the value is being stored.
In other words, a reference type contains a pointer to another memory location that holds the data.

The followings are reference type data types:
String
Arrays (even if their elements are value types)
Class
Delegate

*/