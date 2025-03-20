using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", 3, 16);
        string scriptureText = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";

        Scripture myScripture = new Scripture(reference, scriptureText);

        myScripture.Display();

        while (true)
        {
            Console.WriteLine("Press Enter to hide more words, type 'type' to try memorizing the verse or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;  
            }

            if (input == "")
            {
                myScripture.HideRandomWords();  
                myScripture.Display();  

                
                if (myScripture.IsCompletelyHidden())
                {
                    Console.WriteLine("All words are hidden! The game is over.");
                    break; 
                }
            }
            if (input.ToLower() == "type")
            {
                Console.WriteLine("Please type the entire verse:");
                string userInput = Console.ReadLine().Trim();
                if (userInput.Equals(scriptureText, StringComparison.OrdinalIgnoreCase))
                {
                    Console.Clear();
                    Console.WriteLine("Congratulations! You've memorized the verse!");
                    break; 
                }
                else
                {
                    Console.WriteLine("Oops! That's not correct. Please try again.");
                }
            }
            
        }

        Console.WriteLine("Goodbye!");
    }
        

    
}
// I added a program to prompt the user to type the memorized verse