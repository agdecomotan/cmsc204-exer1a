using System;

// Anelie Decomotan
// 2017-30211
// March 9, 2019

namespace Exercise1A
{
    class Program
    {
        // Properties
        static string[] notebookArray;
        static int top = 0, stackSize = 10;

        // Main function
        static void Main(string[] args)
        {
            // Initialize stack
            notebookArray = new string[stackSize];
            mainMenu();
        }

        static void mainMenu()
        {
            // Show main menu
            string instruction = "[1] Add Notebook \n" +
                "[2] Check Notebook \n" +
                "[3] Peek at Notebook \n" +
                "[4] Check All \n" +
                "[5] Exit ";
            Console.WriteLine(instruction);

            // Get user input
            string input = Console.ReadLine();

            // Process user input and call corresponding function
            switch (input)
            {
                case "1":
                    addNotebook();
                    break;
                case "2":
                    checkNotebook();
                    break;
                case "3":
                    peekNotebook();
                    break;
                case "4":
                    checkAllNotebook();
                    break;
                case "5":
                    exitApplication();
                    break;
                default:
                    mainMenu();
                    Console.WriteLine("Invalid input.");
                    break;
            }

            // Return to main menu
            mainMenu();
        }

        static void addNotebook()
        {
            // Prompt user to input notebook's owner name
            Console.WriteLine("Enter notebook's owner name:");
            string input = Console.ReadLine();

            // Push new item/notebook in the stack
            notebookArray[top] = input;
            top++;
        }

        static void checkNotebook()
        {
            if (top > 0)
            {
                // Remove/pop item/notebook on top of the stack
                top--;
                string topNotebook = notebookArray[top];
                notebookArray[top] = "";
                Console.WriteLine(topNotebook + "’s notebook is being checked.");
            }
            else
            {
                Console.WriteLine("Notebook list is empty.");
            }
        }

        static void peekNotebook()
        {
            if (top > 0)
            {
                // Get item on top of the stack
                string topNotebook = notebookArray[top - 1];
                Console.WriteLine(topNotebook);
            }
            else
            {
                Console.WriteLine("Notebook list is empty.");
            }
        }

        static void checkAllNotebook()
        {
            // Remove all the contents of the stack
            while (top > 0)
            {
                top--;
                string topNotebook = notebookArray[top];
                notebookArray[top] = "";
            }

            Console.WriteLine("Checked all notebooks.");
        }

        static void exitApplication()
        {
            Environment.Exit(1);
        }
    }
}