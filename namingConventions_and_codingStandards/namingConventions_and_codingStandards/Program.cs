using System;

namespace namingConventions_and_codingStandards
{
    // Class names like clientActivity
    class Program
    {
        // Method name like CalculateValue
        // method arguements like firstName
        static void Main(string[] args)
        {
            // local variables like itemCount

            // use userControl instead of userCtrl

            // don't use numbers at the start of variable names
            // eg: use cars3 = 5;  instead of 3cars = 5;

            // Avoide using underscore at the middle of the variable names.
            // but it is ok to start a variable name with underscore.

            Console.WriteLine("Naming Conventions and Coding Standards");
            Console.ReadLine();
        }
    }
}



/*

## Class Names
do use PascalCasing for class names and method names.
eg : ClientActivity


## Variable Names
do use camelCasing for local variables and method arguments.
eg : itemCount


## Identifiers
do not use Hungarian notation or any other type identification in identifiers.
eg : 
// Correct
int counter;
string name;
 
// Avoid
int iCounter;
string strName;


## Constants
do not use Screaming Caps for constants or readonly variables.
eg:
// Correct
public static const string ShippingType = "DropShip";
 
// Avoid
public static const string SHIPPINGTYPE = "DropShip";


## Abbreviations
avoid using Abbreviations.
Exceptions: abbreviations commonly used as names, such as Id, Xml, Ftp, Uri.

// Correct
UserGroup userGroup;
Assignment employeeAssignment;
eg : 
// Avoid
UserGroup usrGrp;
Assignment empAssignment;
 
// Exceptions
CustomerId customerId;
XmlDocument xmlDocument;
FtpHelper ftpHelper;
UriPart uriPart;


## Abbreviation Casing
do use PascalCasing for abbreviations 3 characters or more (2 chars are both uppercase)

HtmlHelper htmlHelper;
FtpTransfer ftpTransfer;
UIControl uiControl;


## No Underscores
do not use Underscores in identifiers.
Exception: you can prefix private static variables with an underscore.
eg : 
// Correct
public DateTime clientAppointment;
public TimeSpan timeLeft;
 
// Avoid
public DateTime client_Appointment;
public TimeSpan time_Left;
 
// Exception
private DateTime _registrationDate;


## Type Names
do use predefined type names instead of system type names like Int16, Single, UInt64, etc
eg : 
// Correct
string firstName;
int lastIndex;
bool isSaved;
 
// Avoid
String firstName;
Int32 lastIndex;
Boolean isSaved;


## Implicit Types
do use implicit type var for local variable declarations.
Exception: primitive types (int, string, double, etc) use predefined names.
eg : 
var stream = File.Create(path);
var customers = new Dictionary();
 
// Exceptions
int index = 100;
string timeSheet;
bool isCompleted;


## Noun Class Names
do use noun or noun phrases to name a class.
eg :
public class Employee
{
}
public class BusinessLocation
{
}
public class DocumentCollection
{
}


## Interfaces
do prefix interfaces with the letter I.  Interface names are noun (phrases) or adjectives.
eg : 
public interface IShape
{
}
public interface IShapeCollection
{
}
public interface IGroupable
{
}


## File Names
do name source files according to their main classes.
Exception: file names with partial classes reflect their source or purpose.
e.g. designer, generated, etc.

// Located in Task.cs
public partial class Task
{
    //...
}
// Located in Task.generated.cs
public partial class Task
{
    //...
}


## Namespaces
do organize namespaces with a clearly defined structure
eg : 
namespace Company.Product.Module.SubModule
namespace Product.Module.Component
namespace Product.Layer.Module.Group


## Curly Brackets
do vertically align curly brackets.
eg : 
// Correct
class Program
{
    static void Main(string[] args)
    {
    }
}


## Member Variables
do declare all member variables at the top of a class, with static variables at the very top.
eg : 
// Correct
public class Account
{
    public static string BankName;
    public static decimal Reserves;
 
    public string Number {get; set;}
    public DateTime DateOpened {get; set;}
    public DateTime DateClosed {get; set;}
    public decimal Balance {get; set;}
 
    // Constructor
    public Account()
    {
        // ...
    }
}


## Enums
do use singular names for enums. Exception: bit field enums.
eg : 
// Correct
public enum Color
{
    Red,
    Green,
    Blue,
    Yellow,
    Magenta,
    Cyan
}
 
// Exception
[Flags]
public enum Dockings
{
    None = 0,
    Top = 1, 
    Right = 2, 
    Bottom = 4,
    Left = 8
}


## Enum Types
do not explicitly specify a type of an enum or values of enums (except bit fields)
eg :
// Don't
public enum Direction : long
{
    North = 1,
    East = 2,
    South = 3,
    West = 4
}
 
// Correct
public enum Direction
{
    North,
    East,
    South,
    West
}


## Enum Suffix
do not suffix enum names with Enum
eg : 
// Don't
public enum CoinEnum
{
    Penny,
    Nickel,
    Dime,
    Quarter,
    Dollar
}
 
// Correct
public enum Coin
{
    Penny,
    Nickel,
    Dime,
    Quarter,
    Dollar
}

*/