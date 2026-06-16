

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool doWhileLoop = true;
            Console.WriteLine("Hello leaner! this is a program that shows a introduction of a C#!" +
                "\nWhat would you want to learn?");
            string options = @"
1- 
2- 
3-
0-";

            do { 
                Console.WriteLine();
                int choose = int.Parse(Console.ReadLine()!);
                void optionsFunctions(int choose)
                {

                switch (choose)
                    {
                        case 1:
                            Contents.consoleCommands();
                            break;  
                        case 0:
                            Console.WriteLine("See you soon!");
                            doWhileLoop = false;
                            break;
                    }
                }
            } while (doWhileLoop == true);
            
        }
    }
}
