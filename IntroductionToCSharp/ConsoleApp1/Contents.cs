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
            Console.WriteLine(@"
Numerical Data Types
    Int:
        An int is a whole integer value, like 4, 100, or -2349. They are for counting individual units of things.
    Decimal and Double:
        If we need to use a decimal value, we have a few options: float, double, and decimal.
        A double is usually the best choice of the three because it is more precise than a float, but faster to process than a decimal. However, for financial applications, be sure to use a decimal, as it is the most precise.
        To declare a decimal variable you have to put the letter 'm' at the final of the number.
        To declare a float variable you have to put the letter 'f' at the final of numbe.

Arithmetic Operators
    Are expressions to use with numerical data.
    Arithmetic operators include:
        addition +
        subtraction -
        multiplication *
        division /
    We can use these symbols to perform operations on numbers and create new values.
    when two different numerical types are used with an arithmetic operator, the result will always be of the type that is more precise.
    C# follows a specific order of operations to determine which operator(s) should be assessed first when multiple operators are used in a single expression. In terms of arithmetic operators, the order is:
        1- Parentheses: () — Operators within parentheses will be assessed before those outside parentheses. If one set of parentheses is nested within another, the nested group will be assessed before the outer group.
        2- Multiplicative: *, /, % — % is the modulo operator, which we will cover later in this lesson.
        3- Additive: +, -

Operator Shortcuts
    C# has a shorthand syntax for adding 1 to an existing variable, ++, called the increment operator. We can also do the same with the subtraction symbol --, called the decrement operator.
    When you want to any expressions with 2 or more to an existing variable you use the compound assignment operators ('+=', '-=', '*=', and '/='.) 'apple += 3;'.

Modulo
    One arithmetic operator that we haven’t covered yet is modulo. A modulo returns a remainder, the value left over when we divide a number by another number.
    Modulo uses the % symbol.

Built-In Methods
    There are several built-in methods that we can use to manipulate numerical data and perform more complex mathematical calculations:
        Math.Abs() — Finds the absolute value of a number. Math.Abs(-5) returns 5.
        Math.Sqrt() — Finds the square root of a given double. Example: Math.Sqrt(16) returns 4.
        Math.Floor() — Rounds the given double or decimal down to the nearest whole number. Example: Math.Floor(8.65) returns 8.
        Math.Ceiling() — The counterpart of Math.Floor(), rounds a given double or decimal up to the nearest whole number. Example: Math.Ceiling(8.65) returns 9.
        Math.Min() — Returns the smaller of two numbers of the same type. Example: Math.Min(39, 12) returns 12.
        Math.Max() — The counterpart of Math.Min(), returns the larger of two numbers of the same type. Example: Math.Max(39, 12) returns 39.

    We can combine multiple arithmetic methods by nesting them within one another:
        'Math.Min(Math.Abs(-10), Math.Abs(8)); // 8'
");
        }
        public static void stringsContent()
        {
            Console.WriteLine(@"
Building Strings
    A string is a group of characters surrounded by quotation marks.
    Escape Character Sequences:
        An escape sequence places a backslash (\) before the inner quotation marks so the program doesn’t read them accidentally as the end of the sequence.
        To make a new line, use the character combination \n.

String Concatenation
    String concatenation is when we combine strings using the addition symbol (+), literally adding one string to another.
    If we want to concatenate a string with something that is another data type, C# will implicitly convert that value to a string.
    Make sure you include spaces and proper punctuation so that when it prints out, your variable strings are not squished between the rest of the statement. Notice how we must create a one-character string at the end to include a period.

String Interpolation
    string interpolation, which enables us to insert our variable values and expressions in the middle of a string, without needing to consider spaces and punctuation separately.
    Notice how we just have one string, which we prepend with the dollar sign symbol $
    'Console.WriteLine($\""Your favorite musician is {yourFaveMusician} and mine is {myFaveMusician}.\"");'

Get Info About Strings
    In addition to containing the value of a piece of text, strings also include information about themselves. It can be helpful to know these properties when working with strings.
    
    Length:
        Since strings are composed of a set of characters, we can find out how many characters exist in a string with the .Length method.
        'userTweet.Length; // Returns the length of the tweet'
    
    IndexOf:
        We can also find the position of a specific character or substring using .IndexOf(). This method is useful for checking if something exists in a string.
        Positions start at 0.
        Since positioning starts at 0, the second thing in the string will return a 1. If it does not exist in the string, the method will return a -1. If we pass it an empty string, it will return 0. If it occurs more than once, it will return the first instance.
        'string word = ""radio"";
        word.IndexOf(""a""); // Returns 1'

Get Parts of Strings
    We can also use built-in .NET methods to grab parts of strings or specific characters in a string.
    Substring:
        .Substring() grabs part of a string using the specified character position, continues until the end of the string, and then returns a new string.
        'string plantName = ""Cactaceae, Cactus""; 
         int charPosition = plantName.IndexOf(""Cactus""); // Returns 11
         string commonName = plantName.Substring(charPosition); // Returns Cactus'
        .Substring() is useful if we only want to use part of a string but keep the original data intact.
        We can also pass .Substring() a second argument, which will determine the number of characters in the resulting substring.

    Bracket Notation:
        Bracket notation is a style of syntax that uses brackets [] and an integer value to identify a particular value in a collection.
        'string plantName = ""Cactaceae, Cactus"";
        int charPosition = plantName.IndexOf(""u""); // Returns 15
        char u = plantName[charPosition]; // Returns u'

Manipulate Strings
    There are also built-in .NET methods that we can use to manipulate text data.
    ToUpper, ToLower:
        These methods are useful if we want to make our text to be all capitalized or all lowercase, respectively.

");         
        }
        public static void logicContent()
        {
            Console.WriteLine(@"
Logic in C#
    Boolean logic is based on evaluating true or false values. Computers use binary logic by turning on and off electric circuits, where “on” equals true and “off” equals false.
    Boolean Data Types:
        In C#, we can represent Boolean values using the bool data type.
    
    Equality Operators:
        Equality operator '==': evaluates to true if the value before == is equal to the value after the operator.
        Inequality operator '!=': evaluates to true if the 2 values are not equal

    Comparison Operators:
        comparison operators allow us to create Boolean expressions, but instead of equality, they evaluate 2 values and the relationship between them. Comparison operators include:
            Less than '<': evaluates to true if the first value is less than the second value.
            Greater than '>': evaluates to true if the first value is greater than the value to the right.
            Less than or equal to '<=': evaluates to true if the first value is less than or equal to the second value.
            Greater than or equal to '>=': evaluates to true if the first value is greater than or equal to the second value.
    
    Logical Operators:
        Logical operators, also known as Boolean operators, can be used to create Boolean expressions.
        Logical operators include:
            AND '&&': The expression will evaluate to true only if both expressions evaluate to true. Otherwise, it will evaluate to false.
            OR '||': The expression will evaluate to true if at least one of the expressions evaluates to true. Otherwise, it will evaluate to false.
            NOT '!': Evaluates to the opposite of the expression it is applied to. A true expression will evaluate to false, and a false expression will evaluate to true.
");
        }
        public static void conditionalsContent()
        {
            Console.WriteLine(@"
Conditional Statements
    We will need our programs to be able to make decisions based on different conditions. 
    The order in which computer programs execute a set of instructions is known as control flow. 
    Control structures to change what instructions we execute based on conditions we define.
    structures that use Boolean logic to control the flow of our programs, including:
        if statements
        if/else statements.
        else if statements.
        switch statements.
        Ternary operators.
    Ternary Operators:
        ________________IF____________________?__YES___:__NO_____;
        string movement = (color == ""green"") ? ""go"" : ""stop"";
    ");
        }
        public static void arraysContent()
        {
            Console.WriteLine(@"
Arrays
                     

");
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
