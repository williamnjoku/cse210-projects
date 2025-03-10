using System;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();

        while (true)
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Add Entry");
            Console.WriteLine("2. Display Entries");
            Console.WriteLine("3. Save Entries");
            Console.WriteLine("4. Load Entries");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Entry newEntry = new Entry(promptGen);
                myJournal.AddEntry(newEntry);  
            }
            else if (choice == "2")
            {
                myJournal.DisplayAll();
            }
            else if (choice == "3")
            {
                myJournal.SaveToFile();  
            }
            else if (choice == "4")
            {
                Console.Write("Enter filename to load: ");
                string loadFile = Console.ReadLine();
                myJournal.LoadFromFile(loadFile);
            }
            else if (choice == "5")
            {
                Console.WriteLine("Goodbye!");
                return; 
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
            }
        }   
    }
}