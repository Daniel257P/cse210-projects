/*
Creative Enhancements to Scripture Memorizer:
I added to the program a random scripture selector so each time the program starts or the user chooses 'new',
a scripture is randomly selected from a file. Also the user can type 'new' to immediately switch to a different scripture and
users can type 'reveal' to display all words in the scripture again.
*/

class Program
{
    static void Main(string[] args)
    {
        string filePath = "scripture.txt";
        List<Scripture> scriptures = new List<Scripture>();

        if (!File.Exists(filePath))
        {
            Console.WriteLine("Scripture file not found.");
            return;
        }

        foreach (string line in File.ReadAllLines(filePath))
        {
            if (string.IsNullOrWhiteSpace(line))
                continue;

            string[] parts = line.Split('|');
            if (parts.Length < 4)
                continue;

            string book = parts[0];
            int chapter = int.Parse(parts[1]);
            int verse = int.Parse(parts[2]);
            string text = string.Join("|", parts.Skip(3));

            scriptures.Add(new Scripture(new Reference(book, chapter, verse), text));
        }

        Random random = new Random();

        while (true)
        {
            Scripture currentScripture = GetRandomScripture(scriptures, random);

            while (true)
            {
                Console.Clear();
                Console.WriteLine(currentScripture.GetDisplayText());

                Console.WriteLine("\nPress Enter to start");
                Console.WriteLine("Type 'new' to see another scripture");
                Console.WriteLine("Type 'quit' to exit");

                string input = Console.ReadLine().ToLower();

                if (input == "quit")
                    return;

                if (input == "new")
                {
                    currentScripture = GetRandomScripture(scriptures, random);
                    continue; 
                }

                break; 
            }

            while (!currentScripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(currentScripture.GetDisplayText());

                Console.WriteLine("\nPress Enter to hide words");
                Console.WriteLine("Type 'back' to change scripture");
                Console.WriteLine("Type 'reveal' to show all words again");
                Console.WriteLine("Type 'quit' to exit");

                string input = Console.ReadLine().ToLower();

                if (input == "quit")
                    return;

                if (input == "back")
                    break; 

                if (input == "reveal")
                {
                    currentScripture.RevealAllWords();
                    continue;
                }

                currentScripture.HideRandomWords(3);
            }

            Console.Clear();
            Console.WriteLine(currentScripture.GetDisplayText());
            Console.WriteLine("\nType 'new' to keep memorizing another scripture");
            Console.WriteLine("Type anything else to exit");

            string choice = Console.ReadLine();
            if (choice != "new")
                break; 
        }
    }

    static Scripture GetRandomScripture(List<Scripture> scriptures, Random random)
    {
        return scriptures[random.Next(scriptures.Count)];
    }
}
