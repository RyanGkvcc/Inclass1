using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass1
{
    public static class StaticUserInterface
    {
        //Private Variables - No need for local variables, so there are no private
        //variables declarations for this class.

        //Properties - Since there are no local variables, there is no need for 
        //public properties, so I don't need that ssection either.

        //Public methods  -  we will have sone of these!

        //This will print the menu to the screen, and await a valid input
        //from the user. Once the input is valid, it will return the 
        //number that they selected.


        //We made the method static and it is inside a static class
        //This means that this method can be called using the class name
        //in the program class. It still does all the same work as the 
        //instanced version, only it cannot use the 'this' keyword because
        //this refers to an instance and since this is static, there is
        // no instance. Only this one.
        public static int GetUserInput()
        {
            
            printMenu();

            
            String input = Console.ReadLine();

            //While the input is NOT valid
            while (input != "1" && input != "2")
            {
                
                Console.WriteLine("That is not a valid entry");
                Console.WriteLine("Please make a valid choice");
                Console.WriteLine();
                //Reprint the menu for the user.
                printMenu();
                //Re-fetch the user input from the console
                input = Console.ReadLine();
            }

            
            return Int32.Parse(input);
        }
        
        public static void PrintAllOutput(string allOutput)
        {
            Console.WriteLine(allOutput);
        }
        
        private static void printMenu()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Print List");
            Console.WriteLine("2. Exit");
        }

        
    }
}
