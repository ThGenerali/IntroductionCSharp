using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Contents
    {
        public static void consoleCommandsContent()
        {
            Console.WriteLine("Hello, World!" +
                "\n Console.WriteLine(); - is a comnmand that prints text to a console");
            string input = Console.ReadLine();
            Console.WriteLine("Console.ReadLine This command captures which type you declare in a variable that a user types into the console." +
                "\n The data this command gets is: " + input);
        }
        public static void commentsContent()
        {
            Console.WriteLine("Comments are lines of code that are ignored by your computer; they’re intended to be read by developers." +
                "\nUse '//' for short, one-line comments and '/*'-beginning '*/'-final for anything longer");
        }
        public static void dataTypesAndVariasblesContent()
        {
            Console.WriteLine(@"
Data types represent the different types of information that we can use in our programs and how they should be used.
Variable represent a place that saves in your computer a data with a specified type (you delcare a data type you want your variable saves when you delcare your variable).

Common C# data types: 
    Type|	Description|	Size (bytes)|	.NET type|	Range|
__________________________________________________________________________________________________________________________
    bool|	Boolean values|	1|	            System.Boolean|	true or false|
    int	|   Whole numbers|	4|	            System.Int32|	-2,147,483,648 to 2,147,483,647|
    long|   Whole numbers (larger range)|8|	System.Int64|	-9,223,372,036,854,775,808 to 9,223,372,036,854,775,807|
   float|   Floating point numbers|4|	    System.Single|	±3.4 x 10^38|
  double|   Floating point numbers (more precise than float)|-|8|-|System.Double|-|±1.7 x 10^308|
 decimal|	Monetary values|16|	            System.Decimal|	28 significant figures|
    char|	Single characters|2|	        System.Char|	N/A — Any Unicode character|
  string|	Sequences of characters|-|2 per character|-|System.String|-|N/A — Any Unicode string|
DateTime|	Moments in time|8|	            System.DateTime|0:0:00 on January 1, 0001 to 23:59:59 on December 31, 9999|
__________________________________________________________________________________________________________________________

Variables:
    data types and variables are closely intertwined. Every time we declare a variable, we have to specify what kind of data type that variable is going to hold.
    There are two ways we can assign variables. We can do it on two lines:
        'int myAge;
        myAge = 32;'

        'string countyNmae = 'Brasil';'
    Once we’ve defined a variable, we can use them throughout our program. If we want to change the values, it’s only necessary to change it in one place instead of everywhere it is used.
    Type Inference with var:
        The var keyword in C# enables type inference, which allows the compiler to automatically determine the data type of a variable based on the value assigned to it. This creates more concise code without sacrificing C#’s strong typing principles.
        Key points about var:
            Multiple implicitly-typed variables cannot be initialized in the same statement.
            var is particularly useful with complex types or when the type is obvious from the initialization.
            var doesn’t make C# a dynamically-typed language.
            Using var doesn’t affect performance - it’s purely a compile-time feature.

Converting Data Types:
    Because variables have to be strictly typed, there may be some circumstances where we want to change the type of data a variable is storing. This strategy is known as data type conversion.
    Convert positiveDouble to an int
    'double positiveDouble = 3.2;
     int positiveInt = positiveDouble;' - But if you tried to run this code, it wouldn’t work. 
    However, if you did the reverse and turned an int into a double:
        'int positiveInt = 3;
         double positiveDouble = positiveInt;'
    C# checks to make sure that when we convert data types from one to another that we’re not losing any data because that could cause problems in our code. 
    Because of that, there are a couple of different ways to do data type conversion:
        implicit conversion: happens automatically if no data will be lost in the conversion. That’s why it’s possible to convert an int (which can hold less data) to a double (which can hold more), but not the other way around.
        explicit conversion: requires a cast operator to convert a data type into another one. If we do want to convert a double to an int, we could use the operator (int).
    It’s also possible to convert data types using built-in methods. For most data types, there is a Convert.ToX() method, like Convert.ToString() and Convert.ToDouble(). For a full list of Convert class built-in methods
");
        }

        public static void numbersAndOperatorsContent()
        {
            Console.WriteLine("its me!");
        }
        public static void stringsContent()
        {
            Console.WriteLine("its me!");
        }
        public static void logicContent()
        {
            Console.WriteLine("its me!");
        }
        public static void conditionalsContent()
        {
            Console.WriteLine("its me!");
        }
        public static void arraysContent()
        {
            Console.WriteLine("its me!");
        }
        public static void loopsContent()
        {
            Console.WriteLine("its me!");
        }
        public static void listsContent()
        {
            Console.WriteLine("its me!");
        }
        public static void methodsContent()
        {
            Console.WriteLine("its me!");
        }
        public static void abstractionContent()
        {
            Console.WriteLine("its me!");
        }
        public static void encapsulationContent()
        {
            Console.WriteLine("its me!");
        }
    }
}
