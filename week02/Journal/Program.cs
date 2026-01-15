using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
       Journal journal = new Journal();
       PromptGenerator promptGenerator = new PromptGenerator();
       int choice = 0;
       while (choice != 5)
       {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write a new journal entry");
            Console.WriteLine("2. Display all journal entries");
            Console.WriteLine("3. Load journal entries from a file");
            Console.WriteLine("4. Save journal entries to a file");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.Write("Enter your journal entry: ");
                string entryText = Console.ReadLine();
                string date = DateTime.Now.ToString("yyyy-MM-dd");
                Entry newEntry = new Entry(date, prompt, entryText);
                journal.AddEntry(newEntry);
            }
            else if (choice == 2)
            {
                journal.DisplayJournal();
            }
            else if (choice == 3)
            {
                Console.Write("Enter the filename to load from: ");
                string loadFile = Console.ReadLine();
                journal.LoadFromFile(loadFile);
            }
            else if (choice == 4)
            {
                Console.Write("Enter the filename to save to: ");
                string saveFile = Console.ReadLine();
                journal.SaveToFile(saveFile);
            }
            else if (choice == 5)
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }

}