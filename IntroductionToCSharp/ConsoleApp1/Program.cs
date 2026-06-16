

namespace ConsoleApp1
{
    public static class Program
    {
        static bool doWhileLoop = true;
        public static void optionsFunctions(int choose)
        {

            switch (choose)
            {
                case 1:
                    Contents.consoleCommandsContent();
                    break;
                case 2:
                    Contents.commentsContent();
                    break;
                case 3:
                    Contents.dataTypesAndVariasblesContent();
                    break;
                case 4:
                    Contents.numbersAndOperatorsContent();
                    break;
                case 5:
                    Contents.stringsContent();
                    break;
                case 6:
                    Contents.logicContent();
                    break;
                case 7:
                    Contents.conditionalsContent();
                    break;
                case 8:
                    Contents.arraysContent();
                    break;
                case 9:
                    Contents.loopsContent();
                    break;
                case 10:
                    Contents.listsContent();
                    break;
                case 11:
                    Contents.methodsContent();
                    break;
                case 12:
                    Contents.abstractionContent();
                    break;
                case 13:
                    Contents.encapsulationContent();
                    break;
                case 0:
                    Console.WriteLine("This was everything about introduction to C#!" +
                        "\nSee you soon!");
                    doWhileLoop = false;
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }
            static void Main(string[] args)
        {
            
            Console.WriteLine("Hello leaner! this is a program that shows a introduction of a C#!");
            string options = @"
CONTENTS

1- Console Commands
2- Comments
3- Data Types and Variables
4- Numbers and Operators
5- Strings
6- Logic
7- Conditionals
8- Arrays
9- Loops
10- Lists
11- Methods
12- Intro to Classes (abstraction)
13- Encapsulation
0- Exit

What would you want to learn?";
            
            
            do
            {
                Console.WriteLine(options);
                int choose = int.Parse(Console.ReadLine()!);
                optionsFunctions(choose);
            } while (doWhileLoop == true);
        }
    }
}
           
        

