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
    'Console.WriteLine($""Your favorite musician is {yourFaveMusician} and mine is {myFaveMusician}."");'

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
    Data structures are formats designed to store larger amounts of information in an organized fashion.
    An array is one very basic data structure.
    An array is a collection of values that are all the same data type.

Building Arrays
    To create an array, we use square brackets [] after the data type to indicate that we want to store multiple values of that type.
    'int[] myArray = new int[5];'
    We can also initialize an array with values when we declare it:
    'int[] myArray = new int[] { 1, 2, 3, 4, 5 };'
    We can also use the shorthand syntax:
    'int[] myArray = { 1, 2, 3, 4, 5 };'
    The 'new' keyword is optional when we initialize an array with values, but it is required when we declare an empty array.

Implicitly Typed Arrays
    C# also allows us to create implicitly typed arrays using the var keyword. The compiler will infer the data type of the array based on the values we provide.
    'var myArray = new[] { 1, 2, 3, 4, 5 };'
    'var myArray = new[] { ""apple"", ""banana"", ""cherry"" };'
    Implicity typed arrays must be initialized with values, and all values must be of the same data type. The compiler will throw an error if we try to mix data types in an implicitly typed array.

Array Length
    We can find out how many values are in an array using the .Length property.
    'int[] myArray = { 1, 2, 3, 4, 5 };
     int arrayLength = myArray.Length; // Returns 5'

Accessing Array Values
    We can access individual values in an array using bracket notation [] and the index of the value we want to retrieve. 
    Indexes start at 0, so the first value in the array is at index 0, the second value is at index 1, and so on.
    'int[] myArray = { 1, 2, 3, 4, 5 };
     int firstValue = myArray[0]; // Returns 1
     int secondValue = myArray[1]; // Returns 2

Editing Array Values
    We can also change the value of an array element by using bracket notation [] and the index of the value we want to change, along with the assignment operator =.
    'int[] myArray = { 1, 2, 3, 4, 5 };
     myArray[0] = 10; // Changes the first value to 10
     myArray[1] = 20; // Changes the second value to 20

Built-In Array Methods
    C# has several built-in methods that we can use to manipulate arrays, including:
        Array.Sort() — Sorts the elements of an array in ascending order.
        Array.Reverse() — Reverses the order of the elements in an array.
        Array.IndexOf() — Returns the index of the first occurrence of a specified value in an array.
        Array.Resize() — Changes the size of an array to a specified new size.
        'Array.' is a class that contains static methods for working with arrays. We can call these methods by using the class name followed by the method name, like Array.Sort(myArray)
");
        }
        public static void loopsContent()
        {
            Console.WriteLine(@"
Loops
    Loops are control structures that allow us to repeat a block of code multiple times until a certain condition is met.
    C# has several types of loops, including:
        for loops
        while loops
        do-while loops
        foreach loops

    While Loops:
        A while loop will continue to execute a block of code as long as the specified condition evaluates to true.
        'while (condition)
         {
             // Code to execute
         }'

    Do-While Loops:
        A do-while loop is similar to a while loop, but it will always execute the block of code at least once before checking the condition.
        'do
         {
             // Code to execute
         } while (condition);'

    For Loops:
        A for loop is used when we know in advance how many times we want to execute a block of code. It consists of three parts: initialization, condition, and iteration.
        'for (initialization; condition; iteration)
         {
             // Code to execute
         }'

    Foreach Loops:
        A foreach loop is used to iterate over each element in a collection, such as an array or a list. It automatically handles the iteration for us.
        'foreach (var item in collection)
         {
             // Code to execute
         }'

    Comparing Loops:
        We can use comparison operators and logical operators to create complex conditions for our loops. This allows us to control the flow of our program based on multiple criteria.
        In generali:
            while loops are good when you know your stopping condition, but not how many times the loop will need to run.
            do...while loops are only necessary if you definitely want something to run once, but then stop if a condition is met.
            for loops are best if you want something to run a specific number of times, rather than given a certain condition.
            foreach loops are the best way to loop over an array, or any other collection.

    Jump Statements:
        Jump statements are used to alter the flow of control in loops. C# has two main jump statements: break and continue.
        The break statement is used to exit a loop prematurely, while the continue statement is used to skip the current iteration and move on to the next one.
        example of break:
            'for (int i = 0; i < 10; i++)
             {
                 if (i == 5)
                 {
                     break; // Exit the loop when i is 5
                 }
                 Console.WriteLine(i);
             }'
        example of continue:
            'for (int i = 0; i < 10; i++)
             {
                 if (i % 2 == 0)
                 {
                     continue; // Skip even numbers
                 }
                 Console.WriteLine(i);
             }'
");
        }
        public static void listsContent()
        {
            Console.WriteLine(@"
Lists
    Like arrays, they are a sequential collection of values and can hold references to any type. Unlike arrays, they:
        Have (effectively) unlimited length.
        Automatically track the number of elements in the list.
        Have methods to work with multiple elements at a time.

    To use lists, we need to include the System.Collections.Generic namespace at the top of our code file:
    To declare a list, we use the List<T> class, where T is the type of elements in the list. We can initialize a list with or without values:
        'List<int> myList = new List<int>(); // Empty list
         List<string> myList = new List<string> { ""apple"", ""banana"", ""cherry"" }; // List with values'
    
    Adding Elements:
        To add elements to a list, we can use the Add() method:
        'myList.Add(4);
         myList.Add(5);'

    Count and Contains:
        We can find out how many elements are in a list using the Count property, and we can check if a list contains a specific value using the Contains() method:
        'int count = myList.Count; // Returns the number of elements
         bool hasValue = myList.Contains(4); // Returns true if 4 is in the list'

    Removing Elements:
        To remove elements from a list, we can use the Remove() method or the RemoveAt() method:
        'myList.Remove(4); // Removes the first occurrence of 4
         myList.RemoveAt(0); // Removes the element at index 0'

    Clearing a List:
        We can remove all elements from a list using the Clear() method:
        'myList.Clear(); // Removes all elements from the list'
    
    Looping through a List:
        We can use a foreach loop to iterate through each element in a list:
        'foreach (var item in myList)
         {
             Console.WriteLine(item);
         }'
        We also use a for loop with the Count property to access elements by index:
        'for (int i = 0; i < myList.Count; i++)
         {
             Console.WriteLine(myList[i]);
         }'
    
    Accessing Out of Bounds:
        If we try to access an index that is out of bounds, we will get an ArgumentOutOfRangeException. We can check if an index is valid before accessing it:
        'if (index >= 0 && index < myList.Count)
         {
             Console.WriteLine(myList[index]);
         }
         else
         {
             Console.WriteLine(""Index out of bounds"");
         }'
    
    Working with Ranges:
        the GetRange() method to retrieve a range of elements from a list:
        'List<int> subList = myList.GetRange(1, 3); // Gets 3 elements starting from index 1'

        the RemoveRange() method to remove a range of elements:
        'myList.RemoveRange(1, 3); // Removes 3 elements starting from index 1

        the InsertRange() method to insert a range of elements at a specific index:
        'List<int> newElements = new List<int> { 6, 7, 8 };
         myList.InsertRange(1, newElements); // Inserts newElements starting at index 1

        the AddRange() method to add a range of elements to the end of the list:
        'List<int> newElements = new List<int> { 6, 7, 8 };
         myList.AddRange(newElements); // Adds newElements to the end of the list

    Generaic Collections:
        Lists are part of the System.Collections.Generic namespace, which provides a variety of generic collection types that can be used to store and manipulate data in a type-safe manner. Other generic collections include Dictionary<TKey, TValue>, Queue<T>, and Stack<T>.

");
        }
        public static void methodsContent()
        {
            Console.WriteLine(@"
Calling Methods
    A method is a block of code that performs a specific task. We can call a method by using its name followed by parentheses ().
    'MethodName();'
    Some methods require parameters, which are values that we pass into the method to customize its behavior. We can pass parameters by placing them inside the parentheses when we call the method.
    'MethodName(parameter1, parameter2);'
    Some methods return a value, which we can capture in a variable or use directly in an expression. We can use the return keyword to specify the value that a method should return.
    This is an example of a method that takes two parameters, adds them together, and returns the result:
    'public static int Add(int a, int b)
     {
         return a + b;
     }'
    

");
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
